using ex03.Models;

namespace ex03.Repositories
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetAllAsync();
        Task<Producto> GetByIdAsync(int id);
        Task<Producto> CreateAsync(Producto producto);
        Task<Producto> UpdateAsync(int id, Producto producto);
        Task<bool> DeleteAsync(int id);
    }
}
