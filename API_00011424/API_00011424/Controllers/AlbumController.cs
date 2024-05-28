using DAL_00011424;
using DAL_00011424.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_00011424.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IRepository11424<Album11424> _repository;

        public AlbumController(IRepository11424<Album11424> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Album11424>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var album = await _repository.GetAsync(id);
            if (album != null)
            {
                return Ok(album);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Album11424 album)
        {
            await _repository.CreateAsync(album);
            return CreatedAtAction(nameof(Get), new { id = album.Id }, album);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id, Album11424 album)
        {
            await _repository.EditAsync(id, album);
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
