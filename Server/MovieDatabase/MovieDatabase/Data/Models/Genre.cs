namespace MovieDatabase.Data.Models
{
    using System.Collections.Generic;

    public class Genre
    {
        public Genre()
        {
            this.Movies = new HashSet<MovieGenre>();
            this.Series = new HashSet<SeriesGenre>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<MovieGenre> Movies { get; set; }

        public ICollection<SeriesGenre> Series { get; set; }
    }
}
