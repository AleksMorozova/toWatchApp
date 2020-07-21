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
        public List<Movie> getToMoviesWatch()
        {
            return moviesService.getMoviesToWatch();
        }

        [HttpPost("bulkUpdate")]
        public void bulkUpdate([FromBody] List<Movie> movies)
        {
            moviesService.bulkUpdate(movies);
        }

        [HttpPost("update")]
        public IActionResult update([FromBody] Movie movie)
        {
            moviesService.watchMovie(movie);
            return Ok(movie);
        }

        [HttpPost("add")]
        public void add([FromBody] Movie movie)
        {
            moviesService.addMovie(movie);
        }
    }
}
