using ex03.Models;

namespace ex03.Repositories
{
    public interface IMaquinaRegistradoraRepository
    {
        Task<IEnumerable<MaquinaRegistradora>> GetAllAsync();
        Task<MaquinaRegistradora> GetByIdAsync(int id);
        Task<MaquinaRegistradora> CreateAsync(MaquinaRegistradora maquinaRegistradora);
        Task<MaquinaRegistradora> UpdateAsync(int id, MaquinaRegistradora maquinaRegistradora);
        Task<bool> DeleteAsync(int id);
    }
}