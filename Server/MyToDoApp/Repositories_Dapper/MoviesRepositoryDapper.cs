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
    public class MoviesRepositoryDapper : RepositoryDapper<EF.Model.Movie>, IMoviesRepository
    {
        //public void BulkUpdate(List<Movie> movies)
        //{
        //    using (var connection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=ToDoDB1;Trusted_Connection=True;"))
        //    {
        //        foreach (Movie movie in movies)
        //        {
        //            connection.Execute(MovieQueries.updateQuery, new
        //            {
        //                movie.Title,
        //                movie.Description,
        //                movie.Link,
        //                movie.IsWatched,
        //                movie.ID
        //            });
        //        }
        //    }
        //}

        //public List<Movie> GetAll()
        //{
        //    return QueryAll();
        //}

        ////public void Update(Movie movie)
        ////{
        ////    using (var connection = new SqlConnection(@"Server =.\SQLEXPRESS;Database=ToDoDB1;Trusted_Connection=True;"))
        ////    {
        ////        connection.Execute(MovieQueries.updateQuery, new
        ////        {
        ////            movie.Title,
        ////            movie.Description,
        ////            movie.Link,
        ////            movie.IsWatched,
        ////            movie.ID
        ////        });
        ////    }
        ////}

        public override string InsertQuery
        {
            get
            {
                return MovieQueries.insertQuery;
            }
        }

        public override string ReadQuery
        {
            get
            {
                return MovieQueries.getAll;
            }
        }

        public void BulkUpdate(List<EF.Model.Movie> movies)
        {
            throw new NotImplementedException();
        }
    }
}
