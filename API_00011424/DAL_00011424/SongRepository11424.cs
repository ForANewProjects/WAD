using DAL_00011424.Context;
using DAL_00011424.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL_00011424
{
    public class SongRepository11424 : IRepository11424<Song11424>
    {
        private readonly MusicContext11424 _context;

        public SongRepository11424(MusicContext11424 context)
        {
            _context = context;
        }

        public async Task CreateAsync(Song11424 entity)
        {
            if(entity.Album != null)
                entity.Album = await _context.Albums.FirstOrDefaultAsync(x => x.Id == entity.Album.Id);
            await _context.Songs.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var song = await GetAsync(id);
            if(song != null)
            {
                _context.Songs.Remove(song);
                await _context.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int id, Song11424 entity)
        {
            var song = await GetAsync(id);
            if(song != null)
            {
                _context.Entry(song).State = EntityState.Modified;

                if (entity.Album != null)
                    entity.Album = await _context.Albums.FirstOrDefaultAsync(x => x.Id == entity.Album.Id);

                song.ArtistName = entity.ArtistName;
                song.DurationInSeconds = entity.DurationInSeconds;
                song.Genre = entity.Genre;
                song.Name = entity.Name;

                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Song11424>> GetAllAsync()
        {
            return await _context.Songs.Include(s => s.Album).ToListAsync();
        }

        public async Task<Song11424?> GetAsync(int id)
        {
            return await _context.Songs.FindAsync(id);
        }
    }
}
