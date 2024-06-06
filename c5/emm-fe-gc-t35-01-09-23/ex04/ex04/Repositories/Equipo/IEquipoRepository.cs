using ex04.Models;

namespace ex04.Repositories
{
    public interface IEquipoRepository
    {
        Task<IEnumerable<Equipo>> GetAllAsync();
        Task<Equipo> GetByNumSerieAsync(string numSerie);
        Task<Equipo> CreateAsync(Equipo equipo);
        Task<Equipo> UpdateAsync(string numSerie, Equipo equipo);
        Task<bool> DeleteAsync(string numSerie);
    }
}

