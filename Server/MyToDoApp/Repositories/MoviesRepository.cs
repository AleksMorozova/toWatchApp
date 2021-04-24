using MyToDoApp.Model;
using System.Collections.Generic;

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
