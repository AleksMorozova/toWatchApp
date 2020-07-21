using Dapper;
using Microsoft.Data.SqlClient;
using MyToDoApp.Model;
using MyToDoApp.Repositories;
using MyToDoApp.Repositories_Dapper.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories_Dapper
{
    public class MoviesRepositoryDapper : IMoviesRepository
    {
        public void add(Movie movie)
        {
            movie.ID = Guid.NewGuid();
            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=ToDoDB1;Trusted_Connection=True;"))
            {
                connection.Execute(MovieQueries.insertQuery, new
                {
                    movie.Title,
                    movie.Description,
                    movie.Link,
                    movie.IsWatched,
                    movie.ID
                });
            }
    }

        public void bulkUpdate(List<Movie> movies)
        {
            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=ToDoDB1;Trusted_Connection=True;"))
            {
                foreach (Movie movie in movies)
                {
                    connection.Execute(MovieQueries.updateQuery, new
                    {
                        movie.Title,
                        movie.Description,
                        movie.Link,
                        movie.IsWatched,
                        movie.ID
                    });
                }
            }
        }

        public List<Movie> getMoviesToWatch()
        {
            using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=ToDoDB1;Trusted_Connection=True;"))
            {
                return connection.Query<Movie>(MovieQueries.getAll).ToList();
            }
        }

        public void update(Movie movie)
        {
            using (var connection = new SqlConnection(@"Server =.\SQLEXPRESS;Database=ToDoDB1;Trusted_Connection=True;"))
            {
                connection.Execute(MovieQueries.updateQuery, new
                {
                    movie.Title,
                    movie.Description,
                    movie.Link,
                    movie.IsWatched,
                    movie.ID
                });
            }
        }
    }
}
