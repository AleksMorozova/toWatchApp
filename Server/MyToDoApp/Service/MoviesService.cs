using AutoMapper;
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
        List<Movie> GetMoviesToWatch();
        Task<Movie> AddMovieAsync(Movie movie);
        Movie WatchMovie(Movie movie);
        Movie ReWatchMovie(Movie movie);
        void BulkUpdate(List<Movie> movie);
    }

    public class MoviesService: IMoviesService
    {
        private readonly IMoviesRepository _moviesRepository;
        private readonly IMapper _mapper;

        public MoviesService(IMoviesRepository moviesRepository, IMapper mapper)
        {
            _moviesRepository = moviesRepository;
            _mapper = mapper;
        }
        public List<Movie> GetMoviesToWatch()
        {
            List<Movie> movies = new List<Movie>();
            foreach (EF.Model.Movie movie in _moviesRepository.GetAll())
            {
                movies.Add(_mapper.Map<Movie>(movie));
            }

            return movies;
        }
        public async Task<Movie> AddMovieAsync(Movie movie)
        {
            EF.Model.Movie newMovie = await _moviesRepository.AddAsync(_mapper.Map<EF.Model.Movie>(movie));
            return _mapper.Map<Movie>(newMovie);
        }
        public Movie ReWatchMovie(Movie movie)
        {
            movie.IsWatched = false;
            EF.Model.Movie newMovie = _mapper.Map<EF.Model.Movie>(movie);
            return _mapper.Map<Movie>(_moviesRepository.Update(newMovie));
        }
        public Movie WatchMovie(Movie movie)
        {
            movie.IsWatched = true;
            EF.Model.Movie newMovie = _mapper.Map<EF.Model.Movie>(movie);
            return _mapper.Map<Movie>(_moviesRepository.Update(newMovie));
        }
        public void BulkUpdate(List<Movie> movies)
        {
            // moviesRepository.BulkUpdate(movies);
        }
    }
}
