namespace MovieDatabase.Infrastructure
{
    using Data;
    using Data.Seed;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseMigrations(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var serviceProvider = serviceScope.ServiceProvider;

            var db = serviceProvider.GetRequiredService<MovieDatabaseDbContext>();

            db.Database.Migrate();

            return app;
        }

        public static IApplicationBuilder UseSeed(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var serviceProvider = serviceScope.ServiceProvider;

            var db = serviceProvider.GetRequiredService<MovieDatabaseDbContext>();

            new MovieDatabaseDbContextSeeder()
                .SeedAsync(db, serviceScope.ServiceProvider)
                .GetAwaiter()
                .GetResult();

            return app;
        }
    }
}
