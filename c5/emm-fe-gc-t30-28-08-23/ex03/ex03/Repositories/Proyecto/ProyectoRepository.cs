using ex03.Data;
using ex03.Models;
using Microsoft.EntityFrameworkCore;

namespace ex03.Repositories
{
    public class ProyectoRepository : IProyectoRepository
    {
        private readonly AppDbContext _dbContext;

        public ProyectoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Proyecto> GetByIdAsync(string id)
        {
            return await _dbContext.Proyectos.FindAsync(id);
        }

        public async Task<IEnumerable<Proyecto>> GetAllAsync()
        {
            return await _dbContext.Proyectos.ToListAsync();
        }

        public async Task CreateAsync(Proyecto proyecto)
        {
            _dbContext.Proyectos.Add(proyecto);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Proyecto proyecto)
        {
            _dbContext.Entry(proyecto).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var proyecto = await _dbContext.Proyectos.FindAsync(id);
            if (proyecto != null)
            {
                _dbContext.Proyectos.Remove(proyecto);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
