namespace MovieDatabase.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class MovieGenreConfiguration : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
            builder
                .HasKey(mg => new { mg.MovieId, mg.GenreId });

            builder
                .HasOne(mg => mg.Movie)
                .WithMany(m => m.Genres)
                .HasForeignKey(mg => mg.MovieId)
                .IsRequired();

            builder
                .HasOne(mg => mg.Genre)
                .WithMany(m => m.Movies)
                .HasForeignKey(mg => mg.GenreId)
                .IsRequired();
        }
    }
}
