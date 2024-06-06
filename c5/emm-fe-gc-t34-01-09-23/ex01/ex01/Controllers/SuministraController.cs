using System.Collections.Generic;
using System.Threading.Tasks;
using ex01.Models;
using ex01.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ex01.Controllers
{
    [ApiController]
    [Route("api/suministra")]
    public class SuministraController : ControllerBase
    {
        private readonly ISuministraRepository _repository;

        public SuministraController(ISuministraRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Suministra>>> GetSuministros()
        {
            var suministros = await _repository.GetAllAsync();
            return Ok(suministros);
        }

        [HttpGet("{codigoPieza}/{idProveedor}")]
        public async Task<ActionResult<Suministra>> GetSuministra(int codigoPieza, string idProveedor)
        {
            var suministra = await _repository.GetByCodigoPiezaIdProveedorAsync(codigoPieza, idProveedor);

            if (suministra == null)
            {
                return NotFound();
            }

            return Ok(suministra);
        }

        [HttpPost]
        public async Task<ActionResult<Suministra>> CreateSuministra(Suministra suministra)
        {
            var createdSuministra = await _repository.CreateAsync(suministra);
            return CreatedAtAction(nameof(GetSuministra), new { codigoPieza = createdSuministra.CodigoPieza, idProveedor = createdSuministra.IdProveedor }, createdSuministra);
        }

        [HttpPut("{codigoPieza}/{idProveedor}")]
        public async Task<IActionResult> UpdateSuministra(int codigoPieza, string idProveedor, Suministra suministra)
        {
            var updatedSuministra = await _repository.UpdateAsync(codigoPieza, idProveedor, suministra);

            if (updatedSuministra == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{codigoPieza}/{idProveedor}")]
        public async Task<IActionResult> DeleteSuministra(int codigoPieza, string idProveedor)
        {
            var deleted = await _repository.DeleteAsync(codigoPieza, idProveedor);

            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
