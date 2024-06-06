using ex03.Models;

namespace ex03.Repositories
{
    public interface ICientificoRepository
    {
        Task<Cientifico> GetByDniAsync(string dni);
        Task<IEnumerable<Cientifico>> GetAllAsync();
        Task CreateAsync(Cientifico cientifico);
        Task UpdateAsync(Cientifico cientifico);
        Task DeleteAsync(string dni);
    }
}
