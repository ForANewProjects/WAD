using DAL_00011424.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL_00011424.Context
{
    public class MusicContext11424 : DbContext
    {
        public DbSet<Album11424> Albums { get; set; }
        public DbSet<Song11424> Songs { get; set; }
        public MusicContext11424(DbContextOptions<MusicContext11424> options) : base(options)
        {
            
        }
    }
}
