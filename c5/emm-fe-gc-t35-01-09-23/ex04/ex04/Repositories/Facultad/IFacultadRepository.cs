using ex04.Models;

namespace ex04.Repositories
{
    public interface IFacultadRepository
    {
        Task<IEnumerable<Facultad>> GetAllAsync();
        Task<Facultad> GetByCodeAsync(int codigo);
        Task<Facultad> CreateAsync(Facultad facultad);
        Task<Facultad> UpdateAsync(int codigo, Facultad facultad);
        Task<bool> DeleteAsync(int codigo);
    }
}

