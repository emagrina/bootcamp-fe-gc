using ex02.Models;

namespace ex02.Repositories
{
    public interface IVideoRepository
    {
        Task<Video> GetByIdAsync(int id);
        Task<IEnumerable<Video>> GetAllAsync();
        Task CreateAsync(Video video);
        Task UpdateAsync(Video video);
        Task DeleteAsync(int id);
    }
}
