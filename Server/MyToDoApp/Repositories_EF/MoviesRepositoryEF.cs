using EF;
using System.Collections.Generic;
using System;

namespace MyToDoApp.Repositories
{
    public class MoviesRepositoryEF : RepositoryEF<EF.Model.Movie>, IMoviesRepository
    {
        public MoviesRepositoryEF(ApplicationContext context) : base(context)
        {
        }
        public void BulkUpdate(List<EF.Model.Movie> movies)
        {
            throw new NotImplementedException();
        }
    }
}
