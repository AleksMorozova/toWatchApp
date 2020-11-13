using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Service;

namespace MyToDoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TVSeriesController : ControllerBase
    {
        private ITVSeriesService tvSeriesService;
        public TVSeriesController(ITVSeriesService tvSeriesService)
        {
            this.tvSeriesService = tvSeriesService;
        }

        [HttpGet("toWatch")]
        public async Task<IActionResult> GetSeriesToWatch()
        {
            return Ok(tvSeriesService.getAllSeries());
        }


        [HttpPost("bulkUpdate")]
        public async Task<IActionResult> UpdateAll([FromBody] List<TVSeries> serials)
        {
            tvSeriesService.bulkUpdate(serials);
            return Ok(serials);
        }

        [HttpPost("watch")]
        public async Task<IActionResult> WatchTvSeries([FromBody] TVSeries tvSeries)
        {
            tvSeriesService.watchTVSeries(tvSeries);
            return Ok(tvSeries);
        }

        [HttpPost("reWatch")]
        public async Task<IActionResult> ReWatchTvSeries([FromBody] TVSeries tvSeries)
        {
            tvSeriesService.reWatchTVSeries(tvSeries);
            return Ok(tvSeries);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddTVSeries([FromBody] TVSeries tvSeries)
        {
            tvSeriesService.addSeries(tvSeries);
            return Ok(tvSeries);
        }
    }
}
