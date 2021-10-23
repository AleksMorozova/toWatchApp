using MyToDoApp.DAL.Contracts;
using MyToDoApp.DAL.EF.Model;
using MyToDoApp.DAL.Model;
using System;
using System.Collections.Generic;

namespace MyToDoApp.DAL.EF.Repositories
{
    public class MoviesRepositoryEF : RepositoryEF<Movie>, IMoviesRepository
    {
        public MoviesRepositoryEF(ApplicationContext context) : base(context)
        {
        }
        public void BulkUpdate(List<Movie> movies)
        {
            throw new NotImplementedException();
        }
    }
}
