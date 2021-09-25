using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieMania.Models;


namespace MovieMania.Data
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<MovieManiaContext>
    {
        protected override void Seed(MovieManiaContext context)
        {
            context.Users.Add(new User
            {
                FirstName = "Marcelo",
                LastName = "Ferreira Cavaliere",
                DOB = DateTime.Parse("04/02/1988"),
                email = "marcelocavaliere@gmail.com",
                Password = "123456",
                UnitNum = 5,
                StreetNum = 100,
                StreetName = "O'Brien st",
                Complement = "",
                Suburb = "Bondi Beach",
                City = "Sydney",
                State = "NSW",
                Country = "Australia",
                Cover = "http:www.teste.com.au/cover",
                PreferredName = "Marcelo Cavaliere"

            });
            context.Users.Add(new User
            {
                FirstName = "Elaine Cristina",
                LastName = "Ferreira De Lima",
                DOB = DateTime.Parse("04/01/1986"),
                email = "elainelima_18@gmail.com",
                Password = "123456",
                UnitNum = 5,
                StreetNum = 100,
                StreetName = "O'Brien st",
                Complement = "",
                Suburb = "Bondi Beach",
                City = "Sydney",
                State = "NSW",
                Country = "Australia",
                Cover = "http:www.teste.com.au/cover",
                PreferredName = "Elaine Lima"

            });
            context.Users.Add(new User
            {
                FirstName = "Giuseppe",
                LastName = "Cavaliere",
                DOB = DateTime.Parse("28/04/1958"),
                email = "giuseppecavaliere@gmail.com",
                Password = "123456",
                UnitNum = 5,
                StreetNum = 100,
                StreetName = "O'Brien st",
                Complement = "",
                Suburb = "Bondi Beach",
                City = "Sydney",
                State = "NSW",
                Country = "Australia",
                Cover = "http:www.teste.com.au/cover",
                PreferredName = "Giuseppe Cavaliere"

            });

            context.Plans.Add(new Plan
            {
                Name = "Plan_Movies",
                Price = 5.00m

            });

            context.Plans.Add(new Plan
            {
                Name = "Plan_Series",
                Price = 7.00m

            });

            context.Plans.Add(new Plan
            {
                Name = "Plan_Series&Movies",
                Price = 10.00m

            });

            context.Series.Add(new Serie
            {
                SerieTitle = "The Walking Dead",
                SerieDescription = "In the wake of a zombie apocalypse, various survivors struggle to stay alive." +
                " As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.",
                Cover = "http://www.teste.com.au/cover",
                SeasonsNumber = 10

            });

            context.Series.Add(new Serie
            {
                SerieTitle = "Gogglebox AU",
                SerieDescription = "Australian families are televised as they gather in their houses to" +
                " give their opinions on stories making news all over the world.",
                Cover = "http://www.teste.com.au/cover",
                SeasonsNumber = 12

            });

            context.Series.Add(new Serie
            {
                SerieTitle = "The Walking Dead",
                SerieDescription = "Contestants compete in a singing competition that focuses on the quality of their voice.",
                Cover = "http://www.teste.com.au/cover",
                SeasonsNumber = 10

            });

            context.Movies.Add(new Movie
            {
                MovieTitle = "Avatar",
                DurationHours = 1,
                DurationMin = 30,
                ReleaseDate = DateTime.Parse("17/12/2009"),
                Description = "Jake, who is paraplegic, replaces his twin on the Na'vi inhabited Pandora" +
                " for a corporate mission. After the natives accept him as one of their own, " +
                "he must decide where his loyalties lie.",
                Cover = "http://www.teste.com.au/cover",

            });

            context.Movies.Add(new Movie
            {
                MovieTitle = "Titanic",
                DurationHours = 1,
                DurationMin = 30,
                ReleaseDate = DateTime.Parse("17/12/1997"),
                Description = "RMS Titanic was a British passenger liner operated by the White Star Line " +
                "that sank in the North Atlantic Ocean on 15 April 1912, after striking an iceberg during " +
                "her maiden voyage from Southampton to New York City.",
                Cover = "http://www.teste.com.au/cover",

            });

            context.Movies.Add(new Movie
            {
                MovieTitle = "Indiana Jones - Raiders of the Lost Ark",
                DurationHours = 1,
                DurationMin = 30,
                ReleaseDate = DateTime.Parse("14/08/1981"),
                Description = "Archaeology professor Indiana Jones ventures to seize a biblical " +
                "artefact known as the Ark of the Covenant. While doing so, he puts up a fight " +
                "against Renee and a troop of Nazis.",
                Cover = "http://www.teste.com.au/cover",

            });

            context.Genres.Add(new Genre
            {
                Name = "Genre1",
                Description = "Description1"

            });

            context.Genres.Add(new Genre
            {
                Name = "Genre2",
                Description = "Description2"

            });
            context.Genres.Add(new Genre
            {
                Name = "Genre3",
                Description = "Description3"

            });

            context.Episodes.Add(new Episode
            {
                Title = "Episode 1",
                SeasonNumber = 1,
                EpisodeNumber = 2,
                DurationHours = 0,
                DurationMin = 50,
                ReleaseDate = DateTime.Parse("10/08/2020"),
                Description = "Description 1"

            });

            context.Episodes.Add(new Episode
            {
                Title = "Episode 2",
                SeasonNumber = 1,
                EpisodeNumber = 2,
                DurationHours = 0,
                DurationMin = 50,
                ReleaseDate = DateTime.Parse("10/08/2020"),
                Description = "Description 2"
            });

            context.Episodes.Add(new Episode
            {
                Title = "Episode 3",
                SeasonNumber = 1,
                EpisodeNumber = 2,
                DurationHours = 0,
                DurationMin = 50,
                ReleaseDate = DateTime.Parse("10/08/2020"),
                Description = "Description 3"
            });




            base.Seed(context);
        }
    }
}