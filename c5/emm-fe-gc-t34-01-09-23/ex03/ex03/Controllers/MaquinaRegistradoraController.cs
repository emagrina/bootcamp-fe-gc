using ex03.Models;
using ex03.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ex03.Controllers
{
    [ApiController]
    [Route("api/maquinas-registradoras")]
    public class MaquinaRegistradoraController : ControllerBase
    {
        private readonly IMaquinaRegistradoraRepository _maquinaRegistradoraRepository;

        public MaquinaRegistradoraController(IMaquinaRegistradoraRepository maquinaRegistradoraRepository)
        {
            _maquinaRegistradoraRepository = maquinaRegistradoraRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<MaquinaRegistradora>> GetAll()
        {
            return await _maquinaRegistradoraRepository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MaquinaRegistradora>> GetById(int id)
        {
            var maquinaRegistradora = await _maquinaRegistradoraRepository.GetByIdAsync(id);
            if (maquinaRegistradora == null)
                return NotFound();

            return maquinaRegistradora;
        }

        [HttpPost]
        public async Task<ActionResult<MaquinaRegistradora>> Create(MaquinaRegistradora maquinaRegistradora)
        {
            var createdMaquinaRegistradora = await _maquinaRegistradoraRepository.CreateAsync(maquinaRegistradora);
            return CreatedAtAction(nameof(GetById), new { id = createdMaquinaRegistradora.Codigo }, createdMaquinaRegistradora);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, MaquinaRegistradora maquinaRegistradora)
        {
            var updatedMaquinaRegistradora = await _maquinaRegistradoraRepository.UpdateAsync(id, maquinaRegistradora);
            if (updatedMaquinaRegistradora == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _maquinaRegistradoraRepository.DeleteAsync(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}