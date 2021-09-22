namespace MovieDatabase.Data.Models
{
    public class SeriesGenre
    {
        public string SeriesId { get; set; }

        public Series Series { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
