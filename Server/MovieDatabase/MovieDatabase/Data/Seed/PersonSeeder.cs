namespace MovieDatabase.Data.Seed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class PersonSeeder : ISeeder
    {
        public async Task SeedAsync(MovieDatabaseDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (await dbContext.Persons.AnyAsync())
            {
                return;
            }

            var persons = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Wachowski",
                    LastName = "Sisters",
                    Picture =
                        "https://www.indiewire.com/wp-content/uploads/2018/10/Screen-Shot-2018-10-25-at-10.23.06-AM.png",
                },
            };

            await dbContext.Persons.AddRangeAsync(persons);
            await dbContext.SaveChangesAsync();
        }
    }
}
