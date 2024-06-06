using Microsoft.AspNetCore.Mvc;
using ex02.Repositories;
using ex02.Models;

namespace ex02.Controllers
{
    [ApiController]
    [Route("api/cientificos")]
    public class CientificoController : ControllerBase
    {
        private readonly ICientificoRepository _cientificoRepository;

        public CientificoController(ICientificoRepository cientificoRepository)
        {
            _cientificoRepository = cientificoRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Cientifico>> GetAll()
        {
            return await _cientificoRepository.GetAllAsync();
        }

        [HttpGet("{dni}")]
        public async Task<ActionResult<Cientifico>> GetByDni(string dni)
        {
            var cientifico = await _cientificoRepository.GetByDniAsync(dni);
            if (cientifico == null)
            {
                return NotFound();
            }
            return cientifico;
        }

        [HttpPost]
        public async Task<ActionResult<Cientifico>> Create(Cientifico cientifico)
        {
            await _cientificoRepository.CreateAsync(cientifico);
            return CreatedAtAction(nameof(GetByDni), new { dni = cientifico.Dni }, cientifico);
        }

        [HttpPut("{dni}")]
        public async Task<IActionResult> Update(string dni, Cientifico cientifico)
        {
            if (dni != cientifico.Dni)
            {
                return BadRequest();
            }

            await _cientificoRepository.UpdateAsync(cientifico);
            return NoContent();
        }

        [HttpDelete("{dni}")]
        public async Task<IActionResult> Delete(string dni)
        {
            var cientifico = await _cientificoRepository.GetByDniAsync(dni);
            if (cientifico == null)
            {
                return NotFound();
            }

            await _cientificoRepository.DeleteAsync(dni);
            return NoContent();
        }
    }
}
