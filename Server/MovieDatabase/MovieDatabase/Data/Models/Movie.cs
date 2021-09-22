﻿namespace MovieDatabase.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class Movie
    {
        public Movie()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Comments = new HashSet<MovieComment>();
            this.Genres = new HashSet<MovieGenre>();
            this.Ratings = new HashSet<MovieRating>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string MPAA { get; set; }

        public string Storyline { get; set; }

        public string Poster { get; set; }

        public int Year { get; set; }

        public string WriterId { get; set; }

        public Person Writer { get; set; }

        public string DirectorId { get; set; }

        public Person Director { get; set; }

        public ICollection<MovieComment> Comments { get; set; }

        public ICollection<MovieGenre> Genres { get; set; }

        public ICollection<MovieRating> Ratings { get; set; }
    }
}
