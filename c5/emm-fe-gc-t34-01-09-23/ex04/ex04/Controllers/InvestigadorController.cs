using ex04.Models;
using ex04.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ex04.Controllers
{
    [Route("api/investigadores")]
    [ApiController]
    public class InvestigadorController : ControllerBase
    {
        private readonly IInvestigadorRepository _repository;

        public InvestigadorController(IInvestigadorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Investigador>>> GetInvestigadores()
        {
            var investigadores = await _repository.GetAllAsync();
            return Ok(investigadores);
        }

        [HttpGet("{dni}")]
        public async Task<ActionResult<Investigador>> GetInvestigador(string dni)
        {
            var investigador = await _repository.GetByDNIAsync(dni);

            if (investigador == null)
            {
                return NotFound();
            }

            return Ok(investigador);
        }

        [HttpPost]
        public async Task<ActionResult<Investigador>> PostInvestigador(Investigador investigador)
        {
            var createdInvestigador = await _repository.CreateAsync(investigador);
            return CreatedAtAction(nameof(GetInvestigador), new { dni = createdInvestigador.DNI }, createdInvestigador);
        }

        [HttpPut("{dni}")]
        public async Task<IActionResult> PutInvestigador(string dni, Investigador investigador)
        {
            if (dni != investigador.DNI)
            {
                return BadRequest();
            }

            var updatedInvestigador = await _repository.UpdateAsync(dni, investigador);

            if (updatedInvestigador == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{dni}")]
        public async Task<IActionResult> DeleteInvestigador(string dni)
        {
            var deleted = await _repository.DeleteAsync(dni);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

