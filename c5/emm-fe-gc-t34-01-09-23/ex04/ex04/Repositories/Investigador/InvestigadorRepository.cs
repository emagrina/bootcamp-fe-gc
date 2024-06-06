using ex04.Data;
using ex04.Models;
using Microsoft.EntityFrameworkCore;

namespace ex04.Repositories
{
    public class InvestigadorRepository : IInvestigadorRepository
    {
        private readonly AppDbContext _context;

        public InvestigadorRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Investigador>> GetAllAsync()
        {
            return await _context.Investigadores.ToListAsync();
        }

        public async Task<Investigador> GetByDNIAsync(string dni)
        {
            return await _context.Investigadores.FindAsync(dni);
        }

        public async Task<Investigador> CreateAsync(Investigador investigador)
        {
            _context.Investigadores.Add(investigador);
            await _context.SaveChangesAsync();
            return investigador;
        }

        public async Task<Investigador> UpdateAsync(string dni, Investigador investigador)
        {
            if (!_context.Investigadores.Any(i => i.DNI == dni))
            {
                return null;
            }

            _context.Entry(investigador).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return investigador;
        }

        public async Task<bool> DeleteAsync(string dni)
        {
            var investigador = await _context.Investigadores.FindAsync(dni);
            if (investigador == null)
            {
                return false;
            }

            _context.Investigadores.Remove(investigador);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
