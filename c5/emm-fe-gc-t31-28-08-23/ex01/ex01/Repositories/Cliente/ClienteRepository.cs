using ex01.Data;
using ex01.Models;
using Microsoft.EntityFrameworkCore;

namespace ex01.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _dbContext;

        public ClienteRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Cliente> GetByIdAsync(int id)
        {
            return await _dbContext.Clientes.FindAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _dbContext.Clientes.ToListAsync();
        }

        public async Task CreateAsync(Cliente cliente)
        {
            _dbContext.Clientes.Add(cliente);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Cliente cliente)
        {
            _dbContext.Entry(cliente).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var cliente = await _dbContext.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _dbContext.Clientes.Remove(cliente);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
