namespace MovieDatabase.Data.Models
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        public User()
        {
            this.MoviesComments = new HashSet<MovieComment>();
            this.MoviesRatings = new HashSet<MovieRating>();
            this.SeriesComments = new HashSet<SeriesComment>();
            this.SeriesRatings = new HashSet<SeriesRating>();
        }

        public ICollection<MovieComment> MoviesComments { get; set; }

        public ICollection<MovieRating> MoviesRatings { get; set; }

        public ICollection<SeriesComment> SeriesComments { get; set; }

        public ICollection<SeriesRating> SeriesRatings { get; set; }
    }
}
