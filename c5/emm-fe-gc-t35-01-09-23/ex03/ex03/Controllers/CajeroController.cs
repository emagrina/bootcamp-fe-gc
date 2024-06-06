using ex03.Models;
using ex03.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ex03.Controllers
{
    [ApiController]
    [Route("api/cajeros")]
    public class CajeroController : ControllerBase
    {
        private readonly ICajeroRepository _cajeroRepository;

        public CajeroController(ICajeroRepository cajeroRepository)
        {
            _cajeroRepository = cajeroRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Cajero>> GetAll()
        {
            return await _cajeroRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cajero>> GetById(int id)
        {
            var cajero = await _cajeroRepository.GetByIdAsync(id);
            if (cajero == null)
                return NotFound();

            return cajero;
        }

        [HttpPost]
        public async Task<ActionResult<Cajero>> Create(Cajero cajero)
        {
            var createdCajero = await _cajeroRepository.CreateAsync(cajero);
            return CreatedAtAction(nameof(GetById), new { id = createdCajero.Codigo }, createdCajero);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Cajero cajero)
        {
            var updatedCajero = await _cajeroRepository.UpdateAsync(id, cajero);
            if (updatedCajero == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _cajeroRepository.DeleteAsync(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}