namespace MovieDatabase.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class MovieRatingConfiguration : IEntityTypeConfiguration<MovieRating>
    {
        public void Configure(EntityTypeBuilder<MovieRating> builder)
        {
            builder
                .HasKey(mr => new { mr.MovieId, mr.UserId });

            builder
                .HasOne(mr => mr.Movie)
                .WithMany(m => m.Ratings)
                .HasForeignKey(mr => mr.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(mr => mr.User)
                .WithMany(u => u.MoviesRatings)
                .HasForeignKey(mr => mr.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
