using ex01.Models;

namespace ex01.Repositories
{
    public interface IProveedorRepository
    {
        Task<IEnumerable<Proveedor>> GetAllAsync();
        Task<Proveedor> GetByIdAsync(string id);
        Task<Proveedor> CreateAsync(Proveedor proveedor);
        Task<Proveedor> UpdateAsync(string id, Proveedor proveedor);
        Task<bool> DeleteAsync(string id);
    }
}

