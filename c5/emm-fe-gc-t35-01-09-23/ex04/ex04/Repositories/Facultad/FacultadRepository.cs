using ex04.Data;
using ex04.Models;
using Microsoft.EntityFrameworkCore;

namespace ex04.Repositories
{
    public class FacultadRepository : IFacultadRepository
    {
        private readonly AppDbContext _context;

        public FacultadRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Facultad>> GetAllAsync()
        {
            return await _context.Facultades.ToListAsync();
        }

        public async Task<Facultad> GetByCodeAsync(int codigo)
        {
            return await _context.Facultades.FindAsync(codigo);
        }

        public async Task<Facultad> CreateAsync(Facultad facultad)
        {
            _context.Facultades.Add(facultad);
            await _context.SaveChangesAsync();
            return facultad;
        }

        public async Task<Facultad> UpdateAsync(int codigo, Facultad facultad)
        {
            if (!_context.Facultades.Any(f => f.Codigo == codigo))
            {
                return null;
            }

            _context.Entry(facultad).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return facultad;
        }

        public async Task<bool> DeleteAsync(int codigo)
        {
            var facultad = await _context.Facultades.FindAsync(codigo);
            if (facultad == null)
            {
                return false;
            }

            _context.Facultades.Remove(facultad);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

