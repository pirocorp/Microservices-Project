namespace MovieDatabase.Data.Seed
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    public class MovieDatabaseDbContextSeeder : ISeeder
    {
        public async Task SeedAsync(MovieDatabaseDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            var logger = serviceProvider
                .GetService<ILoggerFactory>()
                .CreateLogger(typeof(MovieDatabaseDbContextSeeder));

            var seeders = new List<ISeeder>
            {
                new RolesSeeder(),
                new GenresSeeder(),
                new PersonSeeder(),
                new MovieSeeder(),
                new SeriesSeeder(),
            };

            foreach (var seeder in seeders)
            {
                await seeder.SeedAsync(dbContext, serviceProvider);
                await dbContext.SaveChangesAsync();
                logger.LogInformation($"Seeder {seeder.GetType().Name} done.");
            }
        }
    }
}
