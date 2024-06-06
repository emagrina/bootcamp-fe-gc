using ex03.Data;
using ex03.Models;
using Microsoft.EntityFrameworkCore;

namespace ex03.Repositories
{
    public class CajeroRepository : ICajeroRepository
    {
        private readonly AppDbContext _context;

        public CajeroRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cajero>> GetAllAsync()
        {
            return await _context.Cajeros.ToListAsync();
        }

        public async Task<Cajero> GetByIdAsync(int id)
        {
            return await _context.Cajeros.FindAsync(id);
        }

        public async Task<Cajero> CreateAsync(Cajero cajero)
        {
            _context.Cajeros.Add(cajero);
            await _context.SaveChangesAsync();
            return cajero;
        }

        public async Task<Cajero> UpdateAsync(int id, Cajero cajero)
        {
            if (!_context.Cajeros.Any(c => c.Codigo == id))
                return null;

            cajero.Codigo = id;
            _context.Cajeros.Update(cajero);
            await _context.SaveChangesAsync();
            return cajero;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var cajero = await _context.Cajeros.FindAsync(id);
            if (cajero == null)
                return false;

            _context.Cajeros.Remove(cajero);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
