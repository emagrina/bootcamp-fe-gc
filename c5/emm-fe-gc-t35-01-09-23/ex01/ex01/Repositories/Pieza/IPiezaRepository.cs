using ex01.Models;

namespace ex01.Repositories
{
    public interface IPiezaRepository
    {
        Task<IEnumerable<Pieza>> GetAllAsync();
        Task<Pieza> GetByIdAsync(int id);
        Task<Pieza> CreateAsync(Pieza pieza);
        Task<Pieza> UpdateAsync(int id, Pieza pieza);
        Task<bool> DeleteAsync(int id);
    }
}

