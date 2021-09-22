namespace MovieDatabase.Data.Seed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class SeriesSeeder : ISeeder
    {
        public async Task SeedAsync(MovieDatabaseDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (await dbContext.Series.AnyAsync())
            {
                return;
            }

            await this.CreateSeries(
                "Stargate SG-1",
                1997,
                2007,
                "TV-14",
                "https://pics.filmaffinity.com/Stargate_SG_1_TV_Series-145480884-large.jpg",
                "General Hammond summons Colonel Jack O'Neill out of retirement to embark on a secret rescue mission. O'Neill confesses that he disobeyed orders to destroy the Stargate on Planet Abydos, and that scientist Daniel Jackson may still be alive. Arriving on Abydos with his team, O'Neill meets up once again with the scientist, who has discovered a giant elaborate cartouche in hieroglyphics. All signs point to the fact that this is a map of many Stargates that exist throughout the galaxy - a development that makes the dream of the SG-1 team to travel throughout the universe in time a reality.",
                new List<string>() { "Action", "Adventure", "Sci-Fi" },
                dbContext);

            await this.CreateSeries(
                "Stargate: Atlantis",
                2004,
                2009,
                "TV-PG",
                "https://m.media-amazon.com/images/M/MV5BMjI0MTI4MTY3N15BMl5BanBnXkFtZTcwMjg1NjQ4NA@@._V1_.jpg",
                "With the Ancients' city of Atlantis discovered in the Pegasus Galaxy by Stargate Command, Dr. Elizabeth Weir and Major Sheppard lead a scientific expedition to the ancient abandoned city. Once there, the team not only find themselves unable to contact Earth, but their explorations unexpectedly reawaken the Ancients' deadly enemies, The Wraith, who hunger for this new prey. Now with the help of newfound local allies like Teyla Emmagan, the Atlantis Team sets about to uncover their new home's secrets even as their war of survival against the Wraith begins.",
                new List<string>() { "Action", "Adventure", "Sci-Fi" },
                dbContext);

            await this.CreateSeries(
                "Stargate Universe",
                2009,
                2011,
                "Not Rated",
                "https://m.media-amazon.com/images/M/MV5BOTEzNTY5NDY5M15BMl5BanBnXkFtZTcwMTY4MDQ3Mg@@._V1_.jpg",
                "The previously unknown purpose of the \"Ninth Chevron\" is revealed, and ends up taking a team to an Ancient ship \"Destiny\", a ship built millions of years ago by the Ancients, used to investigate a mystery as old as time itself. This team, led by Dr. Nicolas Rush and Colonel Everett Young, is trapped on the ship, unable to change its programmed mission. The team encounters new races, new technology and new enemies as the runaway ship travels to the far ends of the Universe.",
                new List<string>() { "Drama", "Sci-Fi" },
                dbContext);

            await this.CreateSeries(
                "The Expanse",
                2015,
                null,
                "TV-14",
                "https://m.media-amazon.com/images/M/MV5BMjM4ZTVkODctNGZhNC00NWY5LWJkMjEtYmI1ZDg2Yjg2NDQzXkEyXkFqcGdeQXVyNjcyNjcyMzQ@._V1_FMjpg_UX1000_.jpg",
                "Two hundred years from now, the solar system's been colonized, and police detective, Josephus Miller's given the assignment of finding a missing woman. Meanwhile, an officer of an ice freighter sees what appears to be an unprovoked attack upon the ship, by a craft from Mars. As news of the attack spreads, the incident's repercussions threaten to destabilize an already tenuous relations between Earth, Mars and the asteroid belt. ",
                new List<string>() { "Drama", "Mystery", "Sci-Fi" },
                dbContext);

            await this.CreateSeries(
                "The Mandalorian",
                2019,
                null,
                "TV-14",
                "https://m.media-amazon.com/images/M/MV5BZDhlMzY0ZGItZTcyNS00ZTAxLWIyMmYtZGQ2ODg5OWZiYmJkXkEyXkFqcGdeQXVyODkzNTgxMDg@._V1_FMjpg_UX1000_.jpg",
                "After the stories of Jango and Boba Fett, another warrior emerges in the Star Wars universe. The Mandalorian is set after the fall of the Empire and before the emergence of the First Order. We follow the travails of a lone gunfighter in the outer reaches of the galaxy far from the authority of the New Republic.",
                new List<string>() { "Action", "Adventure", "Sci-Fi" },
                dbContext);

            await this.CreateSeries(
                "Loki",
                2021,
                null,
                "TV-14",
                "https://m.media-amazon.com/images/M/MV5BNTkwOTE1ZDYtODQ3Yy00YTYwLTg0YWQtYmVkNmFjNGZlYmRiXkEyXkFqcGdeQXVyNTc4MjczMTM@._V1_.jpg",
                "The mercurial villain Loki resumes his role as the God of Mischief in a new series that takes place after the events of “Avengers: Endgame.”",
                new List<string>() { "Action", "Adventure", "Fantasy" },
                dbContext);

            await this.CreateSeries(
                "See",
                2019,
                null,
                "TV-MA",
                "https://m.media-amazon.com/images/M/MV5BM2JkM2Y5NTEtZWIwZS00ZTliLTk3MDMtNzY4MDNkNjg0NTkwXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg",
                "Far in a dystopian future, the human race has lost the sense of sight, and society has had to find new ways to interact, build, hunt, and to survive. All of that is challenged when a set of twins are born with sight.",
                new List<string>() { "Action", "Drama", "Sci-Fi" },
                dbContext);

            await this.CreateSeries(
                "Game of Thrones",
                2011,
                2019,
                "TV-MA",
                "https://m.media-amazon.com/images/M/MV5BYTRiNDQwYzAtMzVlZS00NTI5LWJjYjUtMzkwNTUzMWMxZTllXkEyXkFqcGdeQXVyNDIzMzcwNjc@._V1_FMjpg_UX1000_.jpg",
                "In the mythical continent of Westeros, several powerful families fight for control of the Seven Kingdoms. As conflict erupts in the kingdoms of men, an ancient enemy rises once again to threaten them all. Meanwhile, the last heirs of a recently usurped dynasty plot to take back their homeland from across the Narrow Sea.",
                new List<string>() { "Action", "Adventure", "Drama" },
                dbContext);

            await this.CreateSeries(
                "Breaking Bad",
                2008,
                2013,
                "TV-MA",
                "https://m.media-amazon.com/images/M/MV5BMjhiMzgxZTctNDc1Ni00OTIxLTlhMTYtZTA3ZWFkODRkNmE2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UX1000_.jpg",
                "When chemistry teacher Walter White is diagnosed with Stage III cancer and given only two years to live, he decides he has nothing to lose. He lives with his teenage son, who has cerebral palsy, and his wife, in New Mexico. Determined to ensure that his family will have a secure future, Walt embarks on a career of drugs and crime. He proves to be remarkably proficient in this new world as he begins manufacturing and selling methamphetamine with one of his former students. The series tracks the impacts of a fatal diagnosis on a regular, hard working man, and explores how a fatal diagnosis affects his morality and transforms him into a major player of the drug trade.",
                new List<string>() { "Crime", "Thriller", "Drama" },
                dbContext);

            await this.CreateSeries(
                "For All Mankind",
                2019,
                null,
                "TV-MA",
                "https://m.media-amazon.com/images/M/MV5BMDQyMjYzMzktZjZlMC00MmE5LWEzZDEtZGRhYTgwN2NkOTRiXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg",
                "In an alternative 1969, the world, and especially the United States, watch in shock as the Soviet Union successfully manages to land men on the Moon before the USA does. With that defeat, NASA is presented with a renewed challenge in the space race that they never expected to face. Now, the cold war rivalry takes on a new intensity and grander ambition to reach far further than ever dreamed and with more diverse resources than ever before.",
                new List<string>() { "Sci-Fi", "Drama" },
                dbContext);

            await this.CreateSeries(
                "The Loudest Voice",
                2019,
                2019,
                "TV-MA",
                "https://m.media-amazon.com/images/M/MV5BZTRmYWFlYmQtMGJjZS00ZTkwLThhMTEtZjM2ODNiN2M3ZmUxXkEyXkFqcGdeQXVyOTA3MTMyOTk@._V1_FMjpg_UX1000_.jpg",
                "This seven-part limited series from the bestselling book is about Roger Ailes, the founder of Fox News. To understand the events that led to the rise of the modern Republican party, one must understand Ailes. Focusing primarily on the past decade in which Ailes arguably became the party's de facto leader, the series also touches on defining events in Ailes' life, including his experiences with world leaders that gave birth to his political career and the sexual harassment accusations and settlements that brought his Fox News reign to an end. ",
                new List<string>() { "Biography", "Drama" },
                dbContext);
        }

        private async Task CreateSeries(
            string name,
            int startYear,
            int? endYear,
            string mpaa,
            string poster,
            string storyline,
            IList<string> genres,
            MovieDatabaseDbContext dbContext)
        {
            var series = new Series()
            {
                Name = name,
                StartYear = startYear,
                EndYear = endYear,
                MPAA = mpaa,
                Poster = poster,
                Storyline = storyline,
            };

            series.Genres = await dbContext.Genres
                .Where(g => genres.Contains(g.Name))
                .Select(g => new SeriesGenre()
                {
                    GenreId = g.Id,
                    SeriesId = series.Id,
                })
                .ToListAsync();

            await dbContext.Series.AddAsync(series);
            await dbContext.SaveChangesAsync();
        }
    }
}
