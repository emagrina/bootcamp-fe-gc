using ex01.Models;
using ex01.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ex01.Controllers
{
    [ApiController]
    [Route("api/piezas")]
    public class PiezaController : ControllerBase
    {
        private readonly IPiezaRepository _repository;

        public PiezaController(IPiezaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pieza>>> GetPiezas()
        {
            var piezas = await _repository.GetAllAsync();
            return Ok(piezas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pieza>> GetPieza(int id)
        {
            var pieza = await _repository.GetByIdAsync(id);

            if (pieza == null)
            {
                return NotFound();
            }

            return Ok(pieza);
        }

        [HttpPost]
        public async Task<ActionResult<Pieza>> CreatePieza(Pieza pieza)
        {
            var createdPieza = await _repository.CreateAsync(pieza);
            return CreatedAtAction(nameof(GetPieza), new { id = createdPieza.Codigo }, createdPieza);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePieza(int id, Pieza pieza)
        {
            var updatedPieza = await _repository.UpdateAsync(id, pieza);

            if (updatedPieza == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePieza(int id)
        {
            var deleted = await _repository.DeleteAsync(id);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
