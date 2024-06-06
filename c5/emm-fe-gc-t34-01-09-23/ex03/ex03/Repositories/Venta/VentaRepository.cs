using ex03.Data;
using ex03.Models;
using Microsoft.EntityFrameworkCore;

namespace ex03.Repositories
{
    public class VentaRepository : IVentaRepository
    {
        private readonly AppDbContext _context;

        public VentaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Venta>> GetAllAsync()
        {
            return await _context.Ventas.ToListAsync();
        }

        public async Task<Venta> GetByIdAsync(int cajeroCodigo, int productoCodigo, int maquinaCodigo)
        {
            return await _context.Ventas
                .FirstOrDefaultAsync(v => v.CajeroCodigo == cajeroCodigo && v.ProductoCodigo == productoCodigo && v.MaquinaCodigo == maquinaCodigo);
        }

        public async Task<Venta> CreateAsync(Venta venta)
        {
            _context.Ventas.Add(venta);
            await _context.SaveChangesAsync();
            return venta;
        }

        public async Task<Venta> UpdateAsync(Venta venta)
        {
            _context.Entry(venta).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentaExists(venta.CajeroCodigo, venta.ProductoCodigo, venta.MaquinaCodigo))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }
            return venta;
        }

        public async Task<bool> DeleteAsync(int cajeroCodigo, int productoCodigo, int maquinaCodigo)
        {
            var venta = await GetByIdAsync(cajeroCodigo, productoCodigo, maquinaCodigo);
            if (venta == null)
            {
                return false;
            }

            _context.Ventas.Remove(venta);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Venta>> SearchAsync(int? cajeroCodigo, int? productoCodigo, int? maquinaCodigo)
        {
            var query = _context.Ventas.AsQueryable();

            if (cajeroCodigo.HasValue)
            {
                query = query.Where(v => v.CajeroCodigo == cajeroCodigo.Value);
            }

            if (productoCodigo.HasValue)
            {
                query = query.Where(v => v.ProductoCodigo == productoCodigo.Value);
            }

            if (maquinaCodigo.HasValue)
            {
                query = query.Where(v => v.MaquinaCodigo == maquinaCodigo.Value);
            }

            return await query.ToListAsync();
        }

        private bool VentaExists(int cajeroCodigo, int productoCodigo, int maquinaCodigo)
        {
            return _context.Ventas.Any(v => v.CajeroCodigo == cajeroCodigo && v.ProductoCodigo == productoCodigo && v.MaquinaCodigo == maquinaCodigo);
        }
    }
}
