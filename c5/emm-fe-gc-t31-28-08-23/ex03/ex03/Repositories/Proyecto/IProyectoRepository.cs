using ex03.Models;

namespace ex03.Repositories
{
    public interface IProyectoRepository
    {
        Task<Proyecto> GetByIdAsync(string id);
        Task<IEnumerable<Proyecto>> GetAllAsync();
        Task CreateAsync(Proyecto proyecto);
        Task UpdateAsync(Proyecto proyecto);
        Task DeleteAsync(string id);
    }
}
