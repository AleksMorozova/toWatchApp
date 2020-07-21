using EF;
using MyToDoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyToDoApp.Converters;
namespace MyToDoApp.Repositories
{
    public interface IMoviesRepository
    {
        public List<Movie> getMoviesToWatch();
        public void update(Movie movie);
        public void add(Movie movie);
        public void bulkUpdate(List<Movie> movies);
    }
}
