using ex04.Data;
using ex04.Models;
using Microsoft.EntityFrameworkCore;

namespace ex04.Repositories
{
    public class EquipoRepository : IEquipoRepository
    {
        private readonly AppDbContext _context;

        public EquipoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Equipo>> GetAllAsync()
        {
            return await _context.Equipos.ToListAsync();
        }

        public async Task<Equipo> GetByNumSerieAsync(string numSerie)
        {
            return await _context.Equipos.FindAsync(numSerie);
        }

        public async Task<Equipo> CreateAsync(Equipo equipo)
        {
            _context.Equipos.Add(equipo);
            await _context.SaveChangesAsync();
            return equipo;
        }

        public async Task<Equipo> UpdateAsync(string numSerie, Equipo equipo)
        {
            if (!_context.Equipos.Any(e => e.NumSerie == numSerie))
            {
                return null;
            }

            _context.Entry(equipo).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return equipo;
        }

        public async Task<bool> DeleteAsync(string numSerie)
        {
            var equipo = await _context.Equipos.FindAsync(numSerie);
            if (equipo == null)
            {
                return false;
            }

            _context.Equipos.Remove(equipo);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

