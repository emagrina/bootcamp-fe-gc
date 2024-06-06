using ex04.Models;

namespace ex04.Repositories
{
    public interface IInvestigadorRepository
    {
        Task<IEnumerable<Investigador>> GetAllAsync();
        Task<Investigador> GetByDNIAsync(string dni);
        Task<Investigador> CreateAsync(Investigador investigador);
        Task<Investigador> UpdateAsync(string dni, Investigador investigador);
        Task<bool> DeleteAsync(string dni);
    }
}
