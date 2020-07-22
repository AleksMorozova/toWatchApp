using MyToDoApp.Model;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Service
{
    public interface IMoviesService
    {
        List<Movie> getMoviesToWatch();
        void watchMovie(Movie movie);
        void reWatchMovie(Movie movie);
        void addMovie(Movie movie);
        void bulkUpdate(List<Movie> movie);
    }

    public class MoviesService: IMoviesService
    {

        private IMoviesRepository moviesRepository;
        public MoviesService(IMoviesRepository moviesRepository)
        {
            this.moviesRepository = moviesRepository;
        }

        public void addMovie(Movie movie)
        {
            this.moviesRepository.add(movie);
        }

        public void bulkUpdate(List<Movie> movies)
        {
            moviesRepository.bulkUpdate(movies);
        }

        public List<Movie> getMoviesToWatch()
        {
            return this.moviesRepository.getMoviesToWatch();
        }

        public void reWatchMovie(Movie movie)
        {
            movie.IsWatched = false;
            this.moviesRepository.update(movie);
        }

        public void watchMovie(Movie movie) {
            movie.IsWatched = true;
            this.moviesRepository.update(movie);
        }
    }
}
