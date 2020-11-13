using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Service;

namespace MyToDoApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMoviesService moviesService;
        public MoviesController(IMoviesService moviesService)
        {
            this.moviesService = moviesService;
        }

        [HttpGet("toWatch")]
        public async Task<IActionResult> GetMoviesToWatch()
        {
            return Ok(moviesService.getMoviesToWatch());
        }

        [HttpPost("bulkUpdate")]
        public async Task<IActionResult> UpdateAll([FromBody] List<Movie> movies)
        {
            moviesService.bulkUpdate(movies);
            return Ok(movies);
        }

        [HttpPost("watch")]
        public async Task<IActionResult> WatchMovie([FromBody] Movie movie)
        {
            moviesService.watchMovie(movie);
            return Ok(movie);
        }


        [HttpPost("reWatch")]
        public async Task<IActionResult> ReWatchMovie([FromBody] Movie movie)
        {
            moviesService.reWatchMovie(movie);
            return Ok(movie);
        }


        [HttpPost("add")]
        public async Task<IActionResult> AddMovie([FromBody] Movie movie)
        {
            moviesService.addMovie(movie);
            return Ok(movie);
        }
    }
}
