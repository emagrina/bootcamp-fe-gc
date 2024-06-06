using ex04.Models;

namespace ex04.Repositories
{
    public interface IReservaRepository
    {
        Task<IEnumerable<Reserva>> GetAllAsync();
        Task<Reserva> GetByDNIAndNumSerieAsync(string dni, string numSerie);
        Task<Reserva> CreateAsync(Reserva reserva);
        Task<Reserva> UpdateAsync(string dni, string numSerie, Reserva reserva);
        Task<bool> DeleteAsync(string dni, string numSerie);
    }
}