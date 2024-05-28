namespace DAL_00011424.Models
{
    public class Song11424
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int DurationInSeconds { get; set; }
        public Album11424? Album { get; set; }
        public required string ArtistName { get; set; }
        public string? Genre { get; set; }
    }
}
