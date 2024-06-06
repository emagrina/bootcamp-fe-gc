using System;
using ex04.Models;
using ex04.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ex04.Controllers
{
    [Route("api/equipos")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private readonly IEquipoRepository _repository;

        public EquipoController(IEquipoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipo>>> GetEquipos()
        {
            var equipos = await _repository.GetAllAsync();
            return Ok(equipos);
        }

        [HttpGet("{numSerie}")]
        public async Task<ActionResult<Equipo>> GetEquipo(string numSerie)
        {
            var equipo = await _repository.GetByNumSerieAsync(numSerie);

            if (equipo == null)
            {
                return NotFound();
            }

            return Ok(equipo);
        }

        [HttpPost]
        public async Task<ActionResult<Equipo>> PostEquipo(Equipo equipo)
        {
            var createdEquipo = await _repository.CreateAsync(equipo);
            return CreatedAtAction(nameof(GetEquipo), new { numSerie = createdEquipo.NumSerie }, createdEquipo);
        }

        [HttpPut("{numSerie}")]
        public async Task<IActionResult> PutEquipo(string numSerie, Equipo equipo)
        {
            if (numSerie != equipo.NumSerie)
            {
                return BadRequest();
            }

            var updatedEquipo = await _repository.UpdateAsync(numSerie, equipo);

            if (updatedEquipo == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{numSerie}")]
        public async Task<IActionResult> DeleteEquipo(string numSerie)
        {
            var deleted = await _repository.DeleteAsync(numSerie);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

