using ex02.Data;
using ex02.Models;
using Microsoft.EntityFrameworkCore;

namespace ex02.Repositories
{
    public class AsignadoRepository : IAsignadoRepository
    {
        private readonly AppDbContext _dbContext;

        public AsignadoRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Asignado_A>> GetByCientificoDniAsync(string dni)
        {
            return await _dbContext.Asignados
                .Where(a => a.CientificoDni == dni)
                .ToListAsync();
        }

        public async Task<IEnumerable<Asignado_A>> GetByProyectoIdAsync(string id)
        {
            return await _dbContext.Asignados
                .Where(a => a.ProyectoId == id)
                .ToListAsync();
        }

        public async Task<Asignado_A> GetByIdAsync(int id)
        {
            return await _dbContext.Asignados.FindAsync(id);
        }

        public async Task CreateAsync(Asignado_A asignado)
        {
            _dbContext.Asignados.Add(asignado);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Asignado_A asignado)
        {
            _dbContext.Entry(asignado).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var asignado = await _dbContext.Asignados.FindAsync(id);
            if (asignado != null)
            {
                _dbContext.Asignados.Remove(asignado);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
