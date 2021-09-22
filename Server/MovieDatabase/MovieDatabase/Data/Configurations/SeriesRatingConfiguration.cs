namespace MovieDatabase.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class SeriesRatingConfiguration : IEntityTypeConfiguration<SeriesRating>
    {
        public void Configure(EntityTypeBuilder<SeriesRating> builder)
        {
            builder
                .HasKey(mr => new { mr.SeriesId, mr.UserId });

            builder
                .HasOne(mr => mr.Series)
                .WithMany(m => m.Ratings)
                .HasForeignKey(mr => mr.SeriesId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(mr => mr.User)
                .WithMany(u => u.SeriesRatings)
                .HasForeignKey(mr => mr.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
