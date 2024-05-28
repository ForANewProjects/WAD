using DAL_00011424.Context;
using DAL_00011424.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL_00011424
{
    public class AlbumRepository11424 : IRepository11424<Album11424>
    {
        private readonly MusicContext11424 _context;

        public AlbumRepository11424(MusicContext11424 context)
        {
            _context = context;
        }

        public async Task CreateAsync(Album11424 entity)
        {
            await _context.Albums.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            if (entity != null)
            {
                _context.Albums.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int id, Album11424 entity)
        {
            var album = await GetAsync(id);
            if (album != null)
            {
                _context.Entry(album).State = EntityState.Modified;
                album.AlbumName = entity.AlbumName;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Album11424>> GetAllAsync()
        {
            return await _context.Albums.ToListAsync();
        }

        public async Task<Album11424?> GetAsync(int id)
        {
            return await _context.Albums.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
