namespace MovieDatabase.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    using static DataConstants.Comment;

    public class SeriesCommentConfiguration : IEntityTypeConfiguration<SeriesComment>
    {
        public void Configure(EntityTypeBuilder<SeriesComment> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Content)
                .IsRequired()
                .HasMaxLength(ContentMaxLength);

            builder
                .Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(TitleMaxLength);

            builder
                .Property(c => c.UserId)
                .IsRequired();

            builder
                .HasOne(c => c.User)
                .WithMany(u => u.SeriesComments)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Parent)
                .WithMany(p => p.Replies)
                .HasForeignKey(c => c.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Series)
                .WithMany(m => m.Comments)
                .HasForeignKey(c => c.SeriesId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
