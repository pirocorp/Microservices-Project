namespace MovieDatabase.Data.Models
{
    using System;
    using System.Collections.Generic;

    public class SeriesComment
    {
        public SeriesComment()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Replies = new HashSet<SeriesComment>();
        }

        public string Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public string ParentId { get; set; }

        public SeriesComment Parent { get; set; }

        public string SeriesId { get; set; }

        public Series Series { get; set; }

        public ICollection<SeriesComment> Replies { get; set; }  
    }
}
