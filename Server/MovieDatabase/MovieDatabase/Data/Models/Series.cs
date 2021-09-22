namespace MovieDatabase.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Series
    {
        public Series()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Comments = new HashSet<SeriesComment>();
            this.Genres = new HashSet<SeriesGenre>();
            this.Ratings = new HashSet<SeriesRating>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public int StartYear { get; set; }

        public int? EndYear { get; set; }

        public string MPAA { get; set; }

        public string Poster { get; set; }

        public string Storyline { get; set; }

        public ICollection<SeriesComment> Comments { get; set; }

        public ICollection<SeriesGenre> Genres { get; set; }

        public ICollection<SeriesRating> Ratings { get; set; }
    }
}
