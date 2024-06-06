using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex01.Data;
using ex01.Models;
using Microsoft.EntityFrameworkCore;

namespace ex01.Repositories
{
    public class SuministraRepository : ISuministraRepository
    {
        private readonly AppDbContext _context;

        public SuministraRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Suministra>> GetAllAsync()
        {
            return await _context.Suministra.ToListAsync();
        }

        public async Task<Suministra> GetByCodigoPiezaIdProveedorAsync(int codigoPieza, string idProveedor)
        {
            return await _context.Suministra.FindAsync(codigoPieza, idProveedor);
        }

        public async Task<Suministra> CreateAsync(Suministra suministra)
        {
            _context.Suministra.Add(suministra);
            await _context.SaveChangesAsync();
            return suministra;
        }

        public async Task<Suministra> UpdateAsync(int codigoPieza, string idProveedor, Suministra suministra)
        {
            var existingSuministra = await _context.Suministra.FindAsync(codigoPieza, idProveedor);

            if (existingSuministra == null)
                return null;

            existingSuministra.Precio = suministra.Precio;

            await _context.SaveChangesAsync();

            return existingSuministra;
        }

        public async Task<bool> DeleteAsync(int codigoPieza, string idProveedor)
        {
            var suministra = await _context.Suministra.FindAsync(codigoPieza, idProveedor);

            if (suministra == null)
                return false;

            _context.Suministra.Remove(suministra);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
