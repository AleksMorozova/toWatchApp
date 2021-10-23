using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Services.Contracts;

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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieById(Guid id)
        {
            return Ok(await _moviesService.GetById(id));
        }

        [HttpGet("all")]
        public IActionResult GetMoviesToWatch()
        {
            return Ok(_moviesService.GetAll());
        }

        [HttpPost("")]
        public async Task<IActionResult> AddMovie(Movie movie)
        {
            await _moviesService.Add(movie);
            return Ok(movie);
        }

        [HttpPost("watch/{id}")]
        public async Task<IActionResult> WatchMovie(Guid id)
        {
            return Ok(await _moviesService.WatchMovie(id));
        }

        [HttpPost("reWatch/{id}")]
        public async Task<IActionResult> ReWatchMovie(Guid id)
        {
            return Ok(await _moviesService.ReWatchMovie(id));
        }
    }
}
