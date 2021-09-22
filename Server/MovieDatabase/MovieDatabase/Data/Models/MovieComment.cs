namespace MovieDatabase.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class MovieComment
    {
        public MovieComment()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Replies = new HashSet<MovieComment>();
        }

        public string Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public string ParentId { get; set; }

        public MovieComment Parent { get; set; }

        public string MovieId { get; set; }

        public Movie Movie { get; set; }

        public ICollection<MovieComment> Replies { get; set; }  
    }
}
