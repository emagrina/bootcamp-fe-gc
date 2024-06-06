using ex04.Models;
using ex04.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ex04.Controllers
{
    [Route("api/faculdades")]
    [ApiController]
    public class FacultadController : ControllerBase
    {
        private readonly IFacultadRepository _repository;

        public FacultadController(IFacultadRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Facultad>>> GetFacultades()
        {
            var facultades = await _repository.GetAllAsync();
            return Ok(facultades);
        }

        [HttpGet("{codigo}")]
        public async Task<ActionResult<Facultad>> GetFacultad(int codigo)
        {
            var facultad = await _repository.GetByCodeAsync(codigo);

            if (facultad == null)
            {
                return NotFound();
            }

            return Ok(facultad);
        }

        [HttpPost]
        public async Task<ActionResult<Facultad>> PostFacultad(Facultad facultad)
        {
            var createdFacultad = await _repository.CreateAsync(facultad);
            return CreatedAtAction(nameof(GetFacultad), new { codigo = createdFacultad.Codigo }, createdFacultad);
        }

        [HttpPut("{codigo}")]
        public async Task<IActionResult> PutFacultad(int codigo, Facultad facultad)
        {
            if (codigo != facultad.Codigo)
            {
                return BadRequest();
            }

            var updatedFacultad = await _repository.UpdateAsync(codigo, facultad);

            if (updatedFacultad == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{codigo}")]
        public async Task<IActionResult> DeleteFacultad(int codigo)
        {
            var deleted = await _repository.DeleteAsync(codigo);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

