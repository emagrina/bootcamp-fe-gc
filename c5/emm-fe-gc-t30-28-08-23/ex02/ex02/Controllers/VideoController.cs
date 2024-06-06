using Microsoft.AspNetCore.Mvc;
using ex02.Repositories;
using ex02.Models;

namespace ex02.Controllers
{
    [ApiController]
    [Route("api/videos")]
    public class VideoController : ControllerBase
    {
        private readonly IVideoRepository _videoRepository;

        public VideoController(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var videos = await _videoRepository.GetAllAsync();
            return Ok(videos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var video = await _videoRepository.GetByIdAsync(id);
            if (video == null)
            {
                return NotFound();
            }
            return Ok(video);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Video video)
        {
            if (ModelState.IsValid)
            {
                await _videoRepository.CreateAsync(video);
                return CreatedAtAction(nameof(GetById), new { id = video.Id }, video);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Video video)
        {
            if (id != video.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                await _videoRepository.UpdateAsync(video);
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var video = await _videoRepository.GetByIdAsync(id);
            if (video == null)
            {
                return NotFound();
            }

            await _videoRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
