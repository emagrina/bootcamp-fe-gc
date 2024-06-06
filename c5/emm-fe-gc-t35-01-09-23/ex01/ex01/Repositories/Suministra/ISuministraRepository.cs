using ex01.Models;

namespace ex01.Repositories
{
    public interface ISuministraRepository
    {
        Task<IEnumerable<Suministra>> GetAllAsync();
        Task<Suministra> GetByCodigoPiezaIdProveedorAsync(int codigoPieza, string idProveedor);
        Task<Suministra> CreateAsync(Suministra suministra);
        Task<Suministra> UpdateAsync(int codigoPieza, string idProveedor, Suministra suministra);
        Task<bool> DeleteAsync(int codigoPieza, string idProveedor);
    }
}