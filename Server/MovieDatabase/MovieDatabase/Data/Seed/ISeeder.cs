namespace MovieDatabase.Data.Seed
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(MovieDatabaseDbContext dbContext, IServiceProvider serviceProvider);
    }
}
