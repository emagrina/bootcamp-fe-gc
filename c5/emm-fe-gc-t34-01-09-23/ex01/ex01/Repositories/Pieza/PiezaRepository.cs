using ex01.Data;
using ex01.Models;
using Microsoft.EntityFrameworkCore;

namespace ex01.Repositories
{
    public class PiezaRepository : IPiezaRepository
    {
        private readonly AppDbContext _context;

        public PiezaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pieza>> GetAllAsync()
        {
            return await _context.Piezas.ToListAsync();
        }

        public async Task<Pieza> GetByIdAsync(int id)
        {
            return await _context.Piezas.FindAsync(id);
        }

        public async Task<Pieza> CreateAsync(Pieza pieza)
        {
            _context.Piezas.Add(pieza);
            await _context.SaveChangesAsync();
            return pieza;
        }

        public async Task<Pieza> UpdateAsync(int id, Pieza pieza)
        {
            var existingPieza = await _context.Piezas.FindAsync(id);

            if (existingPieza == null)
                return null;

            existingPieza.Nombre = pieza.Nombre;

            await _context.SaveChangesAsync();

            return existingPieza;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var pieza = await _context.Piezas.FindAsync(id);

            if (pieza == null)
                return false;

            _context.Piezas.Remove(pieza);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
