using ex04.Models;
using ex04.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ex04.Controllers
{
    [Route("api/reservas")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaRepository _repository;

        public ReservaController(IReservaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reserva>>> GetReservas()
        {
            var reservas = await _repository.GetAllAsync();
            return Ok(reservas);
        }

        [HttpGet("{dni}/{numSerie}")]
        public async Task<ActionResult<Reserva>> GetReserva(string dni, string numSerie)
        {
            var reserva = await _repository.GetByDNIAndNumSerieAsync(dni, numSerie);

            if (reserva == null)
            {
                return NotFound();
            }

            return Ok(reserva);
        }

        [HttpPost]
        public async Task<ActionResult<Reserva>> PostReserva(Reserva reserva)
        {
            var createdReserva = await _repository.CreateAsync(reserva);
            return CreatedAtAction(nameof(GetReserva), new { dni = createdReserva.DNI, numSerie = createdReserva.NumSerie }, createdReserva);
        }

        [HttpPut("{dni}/{numSerie}")]
        public async Task<IActionResult> PutReserva(string dni, string numSerie, Reserva reserva)
        {
            if (dni != reserva.DNI || numSerie != reserva.NumSerie)
            {
                return BadRequest();
            }

            var updatedReserva = await _repository.UpdateAsync(dni, numSerie, reserva);

            if (updatedReserva == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{dni}/{numSerie}")]
        public async Task<IActionResult> DeleteReserva(string dni, string numSerie)
        {
            var deleted = await _repository.DeleteAsync(dni, numSerie);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

