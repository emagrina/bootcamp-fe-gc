using ex02.Data;
using ex02.Models;
using Microsoft.EntityFrameworkCore;

namespace ex02.Repositories
{
    public class CientificoRepository : ICientificoRepository
    {
        private readonly AppDbContext _dbContext;

        public CientificoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Cientifico> GetByDniAsync(string dni)
        {
            return await _dbContext.Cientificos.FindAsync(dni);
        }

        public async Task<IEnumerable<Cientifico>> GetAllAsync()
        {
            return await _dbContext.Cientificos.ToListAsync();
        }

        public async Task CreateAsync(Cientifico cientifico)
        {
            _dbContext.Cientificos.Add(cientifico);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Cientifico cientifico)
        {
            _dbContext.Entry(cientifico).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(string dni)
        {
            var cientifico = await _dbContext.Cientificos.FindAsync(dni);
            if (cientifico != null)
            {
                _dbContext.Cientificos.Remove(cientifico);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
