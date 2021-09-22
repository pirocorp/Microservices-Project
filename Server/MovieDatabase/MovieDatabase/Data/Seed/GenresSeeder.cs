namespace MovieDatabase.Data.Seed
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Models;

    public class GenresSeeder : ISeeder
    {
        public async Task SeedAsync(MovieDatabaseDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Genres.Any())
            {
                return;
            }

            var genres = new string[]
                {
                    "Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", "Drama", "Family",
                    "Fantasy", "Film Noir", "History", "Horror", "Musical", "Mystery", "Romance", "Sci-Fi", "Short Film",
                    "Sport", "Superhero", "Thriller", "War", "Western"
                }
                .Select(g => new Genre(){ Name = g })
                .ToArray();

            await dbContext.Genres.AddRangeAsync(genres);
            await dbContext.SaveChangesAsync();
        }
    }
}
