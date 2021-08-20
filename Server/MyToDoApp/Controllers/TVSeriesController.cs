using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Service;

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

        [HttpGet("all")]
        public IActionResult GetSeriesToWatch()
        {
            return Ok(_tvSeriesService.GetSeriesToWatch());
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddTVSeries(TVSeries tvSeries)
        {
            await _tvSeriesService.AddSeries(tvSeries);
            return Ok(tvSeries);
        }

        [HttpPost("watch")]
        public IActionResult WatchTvSeries(TVSeries tvSeries)
        {
            _tvSeriesService.WatchTVSeries(tvSeries);
            return Ok(tvSeries);
        }

        [HttpPost("reWatch")]
        public IActionResult ReWatchTvSeries(TVSeries tvSeries)
        {
            _tvSeriesService.ReWatchTVSeries(tvSeries);
            return Ok(tvSeries);
        }

        [HttpPost("bulkUpdate")]
        public IActionResult UpdateAll(List<TVSeries> serials)
        {
            _tvSeriesService.BulkUpdate(serials);
            return Ok(serials);
        }
    }
}
