using ex02.Data;
using ex02.Models;
using Microsoft.EntityFrameworkCore;

namespace ex02.Repositories
{
    public class VideoRepository : IVideoRepository
    {
        private readonly AppDbContext _dbContext;

        public VideoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Video> GetByIdAsync(int id)
        {
            return await _dbContext.Videos.FindAsync(id);
        }

        public async Task<IEnumerable<Video>> GetAllAsync()
        {
            return await _dbContext.Videos.ToListAsync();
        }

        public async Task CreateAsync(Video video)
        {
            _dbContext.Videos.Add(video);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Video video)
        {
            _dbContext.Entry(video).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var video = await _dbContext.Videos.FindAsync(id);
            if (video != null)
            {
                _dbContext.Videos.Remove(video);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
