namespace MovieDatabase.Data.Models
{
    public class SeriesRating
    {
        public string SeriesId { get; set; }

        public Series Series { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public double Rating { get; set; }
    }
}
