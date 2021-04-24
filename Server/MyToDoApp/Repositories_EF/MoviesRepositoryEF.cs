using EF;
using MyToDoApp.Model;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace MyToDoApp.Repositories
{
    public class MoviesRepositoryEF: IMoviesRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public MoviesRepositoryEF(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Movie> getMoviesToWatch()
        {
            List<Movie> movies = new List<Movie>();
            foreach (EF.Model.Movie movie in _context.Movies.Where(m => m.IsWatched == false))
            {
                movies.Add(_mapper.Map<Movie>(movie));
            }

            return movies;
        }
        public void update(Movie movie)
        {
            var m = _context.Movies.Where(m => movie.ID == m.ID).First();
            m.IsWatched = movie.IsWatched;
            m.Link = movie.Link;
            m.Title = movie.Title;
            m.Description = movie.Description;
            _context.SaveChanges();
        }
        public void add(Movie movie)
        {
            using (var c = _context)
            {
                c.Movies.Add(_mapper.Map<EF.Model.Movie>(movie));
                c.SaveChanges();
            }
        }

        public void bulkUpdate(List<Movie> movies)
        {
            foreach (Movie movie in movies) {
                var m = _context.Movies.Where(m => movie.ID == m.ID).First();
                m.IsWatched = movie.IsWatched;
                m.Link = movie.Link;
                m.Title = movie.Title;
                m.Description = movie.Description;
            }
            _context.SaveChanges();
        }
    }
}
