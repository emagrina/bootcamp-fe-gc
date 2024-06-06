using ex03.Models;

namespace ex03.Repositories
{
    public interface IVentaRepository
    {
        Task<IEnumerable<Venta>> GetAllAsync();
        Task<Venta> GetByIdAsync(int cajeroCodigo, int productoCodigo, int maquinaCodigo);
        Task<Venta> CreateAsync(Venta venta);
        Task<Venta> UpdateAsync(Venta venta);
        Task<bool> DeleteAsync(int cajeroCodigo, int productoCodigo, int maquinaCodigo);
        Task<IEnumerable<Venta>> SearchAsync(int? cajeroCodigo, int? productoCodigo, int? maquinaCodigo);
    }
}
