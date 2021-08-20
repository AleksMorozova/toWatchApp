using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Service;

namespace MyToDoApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMoviesService _moviesService;
        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet("all")]
        public IActionResult GetMoviesToWatch()
        {
            return Ok(_moviesService.GetMoviesToWatch());
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddMovie(Movie movie)
        {
            await _moviesService.AddMovieAsync(movie);
            return Ok(movie);
        }

        [HttpPost("watch")]
        public IActionResult WatchMovie(Movie movie)
        {
            _moviesService.WatchMovie(movie);
            return Ok(movie);
        }

        [HttpPost("reWatch")]
        public IActionResult ReWatchMovie(Movie movie)
        {
            _moviesService.ReWatchMovie(movie);
            return Ok(movie);
        }

        [HttpPost("bulkUpdate")]
        public IActionResult UpdateAll(List<Movie> movies)
        {
            _moviesService.BulkUpdate(movies);
            return Ok(movies);
        }
    }
}
