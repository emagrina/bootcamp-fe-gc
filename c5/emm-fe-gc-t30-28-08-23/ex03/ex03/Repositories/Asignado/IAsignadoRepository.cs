using ex03.Models;

namespace ex03.Repositories
{
    public interface IAsignadoRepository
    {
        Task<IEnumerable<Asignado_A>> GetByCientificoDniAsync(string dni);
        Task<IEnumerable<Asignado_A>> GetByProyectoIdAsync(string id);
        Task<Asignado_A> GetByIdAsync(int id);
        Task CreateAsync(Asignado_A asignado);
        Task UpdateAsync(Asignado_A asignado);
        Task DeleteAsync(int id);
    }
}
