using Microsoft.AspNetCore.Mvc;
using ex02.Repositories;
using ex02.Models;

namespace ex02.Controllers
{
    [ApiController]
    [Route("api/proyectos")]
    public class ProyectoController : ControllerBase
    {
        private readonly IProyectoRepository _proyectoRepository;

        public ProyectoController(IProyectoRepository proyectoRepository)
        {
            _proyectoRepository = proyectoRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Proyecto>> GetAll()
        {
            return await _proyectoRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Proyecto>> GetById(string id)
        {
            var proyecto = await _proyectoRepository.GetByIdAsync(id);
            if (proyecto == null)
            {
                return NotFound();
            }
            return proyecto;
        }

        [HttpPost]
        public async Task<ActionResult<Proyecto>> Create(Proyecto proyecto)
        {
            await _proyectoRepository.CreateAsync(proyecto);
            return CreatedAtAction(nameof(GetById), new { id = proyecto.Id }, proyecto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Proyecto proyecto)
        {
            if (id != proyecto.Id)
            {
                return BadRequest();
            }

            await _proyectoRepository.UpdateAsync(proyecto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var proyecto = await _proyectoRepository.GetByIdAsync(id);
            if (proyecto == null)
            {
                return NotFound();
            }

            await _proyectoRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
