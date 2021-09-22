namespace MovieDatabase.Data.Seed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class MovieSeeder : ISeeder
    {
        public async Task SeedAsync(MovieDatabaseDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (await dbContext.Movies.AnyAsync())
            {
                return;
            }

            await this.CreateMovie(
                "Dune",
                2021,
                "PG-13",
                "A mythic and emotionally charged hero's journey, \"Dune\" tells the story of Paul Atreides, a brilliant and gifted young man born into a great destiny beyond his understanding, must travel to the most dangerous planet in the universe to ensure the future of his family and his people. As malevolent forces explode into conflict over the planet's exclusive supply of the most precious resource in existence-a commodity capable of unlocking humanity's greatest potential-only those who can conquer their fear will survive.",
                "https://m.media-amazon.com/images/M/MV5BN2FjNmEyNWMtYzM0ZS00NjIyLTg5YzYtYThlMGVjNzE1OGViXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_FMjpg_UX1000_.jpg",
                new Person()
                {
                    FirstName = "Denis",
                    LastName = "Villeneuve",
                    BirthDate = new DateTime(1967, 10, 3),
                    Picture =
                        "https://m.media-amazon.com/images/M/MV5BMzU2MDk5MDI2MF5BMl5BanBnXkFtZTcwNDkwMjMzNA@@._V1_.jpg",
                },
                new Person()
                {
                    FirstName = "Frank",
                    LastName = "Herbert",
                    BirthDate = new DateTime(1920, 10, 8),
                    Picture =
                        "https://m.media-amazon.com/images/M/MV5BM2IwYTM0MWEtYzMxYi00YTI1LTlkYWQtZmE5ZGM0NGI2NmYyXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_.jpg",
                },
                new List<string>() { "Sci-Fi", "Drama", "Adventure" },
                dbContext);

            await this.CreateMovie(
                "The Tomorrow War",
                2021,
                "PG-13",
                "The world is stunned when a group of time travelers arrive from the year 2051 to deliver an urgent message: Thirty years in the future, mankind is losing a global war against a deadly alien species. The only hope for survival is for soldiers and civilians from the present to be transported to the future and join the fight. Among those recruited is high school teacher and family man Dan Forester (Chris Pratt). Determined to save the world for his young daughter, Dan teams up with a brilliant scientist (Yvonne Strahovski) and his estranged father (J.K. Simmons) in a desperate quest to rewrite the fate of the planet.",
                "https://m.media-amazon.com/images/M/MV5BNTI2YTI0MWEtNGQ4OS00ODIzLWE1MWEtZGJiN2E3ZmM1OWI1XkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_FMjpg_UX1000_.jpg",
                new Person()
                {
                    FirstName = "Chris",
                    LastName = "McKay",
                    BirthDate = new DateTime(1973, 11, 11),
                    Picture =
                        "https://m.media-amazon.com/images/M/MV5BY2M3YjVlNzQtYTkyNi00OTkwLWE0OTAtMTFkNzg1MjAzM2U0XkEyXkFqcGdeQXVyMjQwMDg0Ng@@._V1_.jpg",
                },
                new Person()
                {
                    FirstName = "Zach",
                    LastName = "Dean",
                    Picture =
                        "https://m.media-amazon.com/images/M/MV5BMmViNmY4OGEtY2QzYi00YTg3LTgyOWUtMDE5MDM2NGNiZTI5XkEyXkFqcGdeQXVyNTYyNjQ4Mw@@._V1_.jpg",
                },
                new List<string>() { "Sci-Fi", "Drama", "Adventure", "Action" },
                dbContext);

            var sisters = dbContext.Persons
                .First(p => p.FirstName == "Wachowski" && p.LastName == "Sisters");

            await this.CreateMovie(
                "The Matrix",
                1999,
                "R",
                "Thomas A. Anderson is a man living two lives. By day he is an average computer programmer and by night a hacker known as Neo. Neo has always questioned his reality, but the truth is far beyond his imagination. Neo finds himself targeted by the police when he is contacted by Morpheus, a legendary computer hacker branded a terrorist by the government. As a rebel against the machines, Neo must confront the agents: super-powerful computer programs devoted to stopping Neo and the entire human rebellion.",
                "https://m.media-amazon.com/images/M/MV5BNzQzOTk3OTAtNDQ0Zi00ZTVkLWI0MTEtMDllZjNkYzNjNTc4L2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg",
                sisters,
                sisters,
                new List<string>() { "Sci-Fi", "Action" },
                dbContext);

            await this.CreateMovie(
                "The Matrix Reloaded",
                2003,
                "R",
                "In this second adventure, Neo and the rebel leaders estimate that they have 72 hours until Zion falls under siege to the Machine Army. Only a matter of hours separates the last human enclave on Earth from 250,000 Sentinels programmed to destroy mankind. But the citizens of Zion, emboldened by Morpheus conviction that the One will fulfill the Oracles Prophecy and end the war with the Machines, rest all manner of hope and expectation on Neo, who finds himself stalled by disturbing visions as he searches for a course of action. ",
                "https://m.media-amazon.com/images/M/MV5BODE0MzZhZTgtYzkwYi00YmI5LThlZWYtOWRmNWE5ODk0NzMxXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_.jpg",
                sisters,
                sisters,
                new List<string>() { "Sci-Fi", "Action" },
                dbContext);

            await this.CreateMovie(
                "The Matrix Revolutions",
                2003,
                "R",
                "Neo finds himself trapped between the Matrix and the Real World. Meanwhile, Zion is preparing for the oncoming war with the machines with very little chances of survival. Neo's associates set out to free him from The Merovingian since it's believed that he is the One who will end the war between humans and the machines. What they do not know is that there is a threat from a third party, someone who has plans to destroy both worlds.",
                "https://m.media-amazon.com/images/M/MV5BNzNlZTZjMDctZjYwNi00NzljLWIwN2QtZWZmYmJiYzQ0MTk2XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_.jpg",
                sisters,
                sisters,
                new List<string>() { "Sci-Fi", "Action" },
                dbContext);
        }

        private async Task CreateMovie(
            string name, 
            int year,
            string mpaa,
            string storyline,
            string poster,
            Person director,
            Person writer,
            IList<string> genres,
            MovieDatabaseDbContext dbContext)
        {
            var movie = new Movie()
            {
                Name = name,
                Year = year,
                MPAA = mpaa,
                Storyline = storyline,
                Poster = poster,
                Director = director,
                Writer = writer,
            };

            movie.Genres = dbContext.Genres
                .Where(g =>  genres.Contains(g.Name))
                .Select(g => new MovieGenre()
                {
                    MovieId = movie.Id,
                    GenreId = g.Id,
                })
                .ToList();

            await dbContext.AddAsync(movie);
            await dbContext.SaveChangesAsync();
        }
    }
}
