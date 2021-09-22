namespace MovieDatabase.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    public class SeriesGenreConfiguration : IEntityTypeConfiguration<SeriesGenre>
    {
        public void Configure(EntityTypeBuilder<SeriesGenre> builder)
        {
            builder
                .HasKey(sg => new { sg.SeriesId, sg.GenreId });

            builder
                .HasOne(sg => sg.Series)
                .WithMany(s => s.Genres)
                .HasForeignKey(mg => mg.SeriesId)
                .IsRequired();

            builder
                .HasOne(mg => mg.Genre)
                .WithMany(m => m.Series)
                .HasForeignKey(mg => mg.GenreId)
                .IsRequired();
        }
    }
}
