using AutoMapper;
using MyToDoApp.DAL.Contracts;
using MyToDoApp.Model;
using MyToDoApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyToDoApp.Service
{
    public class MoviesService: IMoviesService
    {
        private readonly IMoviesRepository _moviesRepository;
        private readonly IMapper _mapper;

        public MoviesService(IMoviesRepository moviesRepository, IMapper mapper)
        {
            _moviesRepository = moviesRepository;
            _mapper = mapper;
        }
        public async Task<Movie> GetById(Guid id)
        {
            var movie = await _moviesRepository.GetById(id);
            return _mapper.Map<Movie>(movie);
        }
        public List<Movie> GetAll()
        {
            var movies = new List<Movie>();
            foreach (DAL.Model.Movie movie in _moviesRepository.GetAll())
            {
                movies.Add(_mapper.Map<Movie>(movie));
            }

            return movies;
        }
        public async Task<Movie> Add(Movie movie)
        {
            var newMovie = await _moviesRepository.AddAsync(_mapper.Map<DAL.Model.Movie>(movie));
            return _mapper.Map<Movie>(newMovie);
        }
        public async Task<Movie> ReWatchMovie(Guid id)
        {
            var movie = await _moviesRepository.GetById(id);
            if (movie.IsWatched)
            {
                movie.IsWatched = false;
            }
            return _mapper.Map<Movie>(_moviesRepository.Update(movie));
        }
        public async Task<Movie> WatchMovie(Guid id)
        {
            var movie = await _moviesRepository.GetById(id);
            if (!movie.IsWatched)
            {
                movie.IsWatched = true;
            }
            return _mapper.Map<Movie>(_moviesRepository.Update(movie));
        }
    }
}
