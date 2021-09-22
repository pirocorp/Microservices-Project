namespace MovieDatabase.Data.Seed
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Infrastructure;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;
    using Models;

    internal class RolesSeeder : ISeeder
    {
        public async Task SeedAsync(MovieDatabaseDbContext dbContext, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<Role>>();

            await SeedRoleAsync(roleManager, GlobalConstants.AdminRole);
        }

        private static async Task SeedRoleAsync(RoleManager<Role> roleManager, string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                var result = await roleManager.CreateAsync(new Role(roleName));
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
