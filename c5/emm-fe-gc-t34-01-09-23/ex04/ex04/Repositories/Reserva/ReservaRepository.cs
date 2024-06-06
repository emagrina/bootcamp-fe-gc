using ex04.Data;
using ex04.Models;
using Microsoft.EntityFrameworkCore;

namespace ex04.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly AppDbContext _context;

        public ReservaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Reserva>> GetAllAsync()
        {
            return await _context.Reservas.ToListAsync();
        }

        public async Task<Reserva> GetByDNIAndNumSerieAsync(string dni, string numSerie)
        {
            return await _context.Reservas
                .Where(r => r.DNI == dni && r.NumSerie == numSerie)
                .FirstOrDefaultAsync();
        }

        public async Task<Reserva> CreateAsync(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            await _context.SaveChangesAsync();
            return reserva;
        }

        public async Task<Reserva> UpdateAsync(string dni, string numSerie, Reserva reserva)
        {
            var existingReserva = await GetByDNIAndNumSerieAsync(dni, numSerie);

            if (existingReserva == null)
            {
                return null;
            }

            _context.Entry(existingReserva).State = EntityState.Detached;
            _context.Reservas.Update(reserva);
            await _context.SaveChangesAsync();
            return reserva;
        }

        public async Task<bool> DeleteAsync(string dni, string numSerie)
        {
            var existingReserva = await GetByDNIAndNumSerieAsync(dni, numSerie);

            if (existingReserva == null)
            {
                return false;
            }

            _context.Reservas.Remove(existingReserva);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

