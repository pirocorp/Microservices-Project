namespace MovieDatabase.Data.Models
{
    public class MovieRating
    {
        public string MovieId { get; set; }

        public Movie Movie { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public double Rating { get; set; }
    }
}
