using ex03.Data;
using ex03.Models;
using Microsoft.EntityFrameworkCore;

namespace ex03.Repositories
{
    public class MaquinaRegistradoraRepository : IMaquinaRegistradoraRepository
    {
        private readonly AppDbContext _context;

        public MaquinaRegistradoraRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MaquinaRegistradora>> GetAllAsync()
        {
            return await _context.MaquinasRegistradoras.ToListAsync();
        }

        public async Task<MaquinaRegistradora> GetByIdAsync(int id)
        {
            return await _context.MaquinasRegistradoras.FindAsync(id);
        }

        public async Task<MaquinaRegistradora> CreateAsync(MaquinaRegistradora maquinaRegistradora)
        {
            _context.MaquinasRegistradoras.Add(maquinaRegistradora);
            await _context.SaveChangesAsync();
            return maquinaRegistradora;
        }

        public async Task<MaquinaRegistradora> UpdateAsync(int id, MaquinaRegistradora maquinaRegistradora)
        {
            if (!_context.MaquinasRegistradoras.Any(m => m.Codigo == id))
                return null;

            maquinaRegistradora.Codigo = id;
            _context.MaquinasRegistradoras.Update(maquinaRegistradora);
            await _context.SaveChangesAsync();
            return maquinaRegistradora;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var maquinaRegistradora = await _context.MaquinasRegistradoras.FindAsync(id);
            if (maquinaRegistradora == null)
                return false;

            _context.MaquinasRegistradoras.Remove(maquinaRegistradora);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
