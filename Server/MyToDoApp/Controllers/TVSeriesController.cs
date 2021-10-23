using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Services.Contracts;

namespace MyToDoApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TVSeriesController : ControllerBase
    {
        private ITVSeriesService _tvSeriesService;
        public TVSeriesController(ITVSeriesService tvSeriesService)
        {
            _tvSeriesService = tvSeriesService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSeriesById(Guid id)
        {
            return Ok(await _tvSeriesService.GetById(id));
        }

        [HttpGet("all")]
        public IActionResult GetSeriesToWatch()
        {
            return Ok(_tvSeriesService.GetAll());
        }

        [HttpPost("")]
        public async Task<IActionResult> AddTVSeries(TVSeries tvSeries)
        {
            await _tvSeriesService.Add(tvSeries);
            return Ok(tvSeries);
        }

        [HttpPost("watch/{id}")]
        public async Task<IActionResult> WatchTvSeries(Guid id)
        {
            return Ok(await _tvSeriesService.WatchTVSeries(id));
        }

        [HttpPost("reWatch/{id}")]
        public async Task<IActionResult> ReWatchTvSeries(Guid id)
        {
            return Ok(await _tvSeriesService.ReWatchTVSeries(id));
        }
    }
}
