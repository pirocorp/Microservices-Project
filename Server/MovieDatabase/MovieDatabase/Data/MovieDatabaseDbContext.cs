namespace MovieDatabase.Data
{
    using System.Reflection;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;

    public class MovieDatabaseDbContext : IdentityDbContext<User, Role, string>
    {
        public MovieDatabaseDbContext(DbContextOptions<MovieDatabaseDbContext> options)
            : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<MovieComment> MoviesComments { get; set; }

        public DbSet<MovieGenre> MoviesGenres { get; set; }

        public DbSet<MovieRating> MoviesRatings { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Series> Series { get; set; }

        public DbSet<SeriesComment> SeriesComments { get; set; }

        public DbSet<SeriesGenre> SeriesGenres { get; set; }

        public DbSet<SeriesRating> SeriesRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
