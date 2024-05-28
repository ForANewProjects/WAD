using DAL_00011424;
using DAL_00011424.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_00011424.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly IRepository11424<Song11424> _repository;

        public SongController(IRepository11424<Song11424> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Song11424>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var song = await _repository.GetAsync(id);
            if (song != null)
            {
                return Ok(song);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Song11424 song)
        {
            await _repository.CreateAsync(song);
            return CreatedAtAction(nameof(Get), new { id = song.Id }, song);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, Song11424 song)
        {
            await _repository.EditAsync(id, song);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
