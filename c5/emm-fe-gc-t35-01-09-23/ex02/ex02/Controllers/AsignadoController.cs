using Microsoft.AspNetCore.Mvc;
using ex02.Repositories;
using ex02.Models;

namespace ex02.Controllers
{
    [ApiController]
    [Route("api/asignados")]
    public class AsignadoController : ControllerBase
    {
        private readonly IAsignadoRepository _asignadoRepository;

        public AsignadoController(IAsignadoRepository asignadoRepository)
        {
            _asignadoRepository = asignadoRepository;
        }

        [HttpGet("cientifico/{dni}")]
        public async Task<IEnumerable<Asignado_A>> GetByCientificoDni(string dni)
        {
            return await _asignadoRepository.GetByCientificoDniAsync(dni);
        }

        [HttpGet("proyecto/{id}")]
        public async Task<IEnumerable<Asignado_A>> GetByProyectoId(string id)
        {
            return await _asignadoRepository.GetByProyectoIdAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Asignado_A>> Create(Asignado_A asignado)
        {
            await _asignadoRepository.CreateAsync(asignado);
            return CreatedAtAction(nameof(GetByCientificoDni), new { dni = asignado.CientificoDni }, asignado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Asignado_A asignado)
        {
            if (id != asignado.Id)
            {
                return BadRequest();
            }

            await _asignadoRepository.UpdateAsync(asignado);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsignado(int id)
        {
            var asignado = await _asignadoRepository.GetByIdAsync(id);
            if (asignado == null)
            {
                return NotFound();
            }

            await _asignadoRepository.DeleteAsync(id);

            return NoContent();
        }
    }
}
