using ex03.Models;

namespace ex03.Repositories
{
    public interface ICajeroRepository
    {
        Task<IEnumerable<Cajero>> GetAllAsync();
        Task<Cajero> GetByIdAsync(int id);
        Task<Cajero> CreateAsync(Cajero cajero);
        Task<Cajero> UpdateAsync(int id, Cajero cajero);
        Task<bool> DeleteAsync(int id);
    }
}
