using EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            var movies = new Movie[]
            {
                new Movie {Title = "Царство красоты", Description = "Люк Саваж — молодой архитектор и примерный семьянин, который считает себя самым счастливым человеком, поскольку он женат на любимой женщине и делает огромные успехи в карьере. Он очень доволен своей жизнью, но однажды его налаженному быту приходит конец. ",
                Link = "http://baskino.me/films/dramy/11642-carstvo-krasoty.html", IsWatched = false}
            };

            context.Movies.AddRange(movies);
            context.SaveChanges();

            // Look for any students.
            if (context.TVSerials.Any())
            {
                return;   // DB has been seeded
            }

            var tvSerials = new TVSeries[]
            {
                new TVSeries {Title = "CSI: Miami", Description = "Преступления совершаются круглосуточно, а на их раскрытие требуется время. ",
                Link = "http://seasonvar.ru/serial-473-Mesto_prestupleniya_Majami-00001-sezon.html", IsWatched = false, Season = "1", Series = "4"}
            };

            context.TVSerials.AddRange(tvSerials);
            context.SaveChanges();


            // Look for any students.
            if (context.TEDTalks.Any())
            {
                return;   // DB has been seeded
            }

            var tedTalks = new TEDTalk[]
            {
                new TEDTalk {Title = "Inside the mind of a master procrastinator", IsWatched = false, Link = "https://www.youtube.com/watch?v=arj7oStGLkU&list=PLiAqvMJOAIKtu5ZENVgZ_ewYJX3crpTVU"}
            };

            context.TEDTalks.AddRange(tedTalks);
            context.SaveChanges();


            // Look for any students.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            var books = new Book[]
            {
                new Book {Title = "Тайная комната", Author = "Донна Тартт", Description = "Тайная комната", IsReaded = false}
            };

            context.Books.AddRange(books);
            context.SaveChanges();
        }
    }
}
