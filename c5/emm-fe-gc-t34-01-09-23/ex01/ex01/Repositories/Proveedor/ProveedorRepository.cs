using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex01.Data;
using ex01.Models;
using Microsoft.EntityFrameworkCore;

namespace ex01.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly AppDbContext _context;

        public ProveedorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Proveedor>> GetAllAsync()
        {
            return await _context.Proveedores.ToListAsync();
        }

        public async Task<Proveedor> GetByIdAsync(string id)
        {
            return await _context.Proveedores.FindAsync(id);
        }

        public async Task<Proveedor> CreateAsync(Proveedor proveedor)
        {
            _context.Proveedores.Add(proveedor);
            await _context.SaveChangesAsync();
            return proveedor;
        }

        public async Task<Proveedor> UpdateAsync(string id, Proveedor proveedor)
        {
            var existingProveedor = await _context.Proveedores.FindAsync(id);

            if (existingProveedor == null)
                return null;

            existingProveedor.Nombre = proveedor.Nombre;

            await _context.SaveChangesAsync();

            return existingProveedor;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var proveedor = await _context.Proveedores.FindAsync(id);

            if (proveedor == null)
                return false;

            _context.Proveedores.Remove(proveedor);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}