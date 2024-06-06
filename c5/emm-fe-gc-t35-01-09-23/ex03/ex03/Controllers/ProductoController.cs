using ex03.Models;
using ex03.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ex03.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Producto>> GetAll()
        {
            return await _productoRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetById(int id)
        {
            var producto = await _productoRepository.GetByIdAsync(id);
            if (producto == null)
                return NotFound();

            return producto;
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> Create(Producto producto)
        {
            var createdProducto = await _productoRepository.CreateAsync(producto);
            return CreatedAtAction(nameof(GetById), new { id = createdProducto.Codigo }, createdProducto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Producto producto)
        {
            var updatedProducto = await _productoRepository.UpdateAsync(id, producto);
            if (updatedProducto == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _productoRepository.DeleteAsync(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}
