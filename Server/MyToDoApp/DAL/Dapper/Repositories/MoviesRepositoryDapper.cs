using MyToDoApp.DAL.Contracts;
using MyToDoApp.DAL.Dapper.Queries;
using MyToDoApp.DAL.Model;
using System;
using System.Collections.Generic;

namespace MyToDoApp.DAL.Dapper.Repositories
{
    public class MoviesRepositoryDapper : RepositoryDapper<Movie>, IMoviesRepository
    {
        public MoviesRepositoryDapper(IServiceProvider provider) : base(provider)
        {
        }
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

        public void BulkUpdate(List<Movie> movies)
        {
            throw new NotImplementedException();
        }
    }
}
