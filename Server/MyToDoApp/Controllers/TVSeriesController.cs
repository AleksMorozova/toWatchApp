using System;
using System.Collections.Generic;
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

        [HttpGet("all")]
        public List<TVSeries> GetToWatch()
        {
            
            return tvSeriesService.getAllSeries();
        }

        [HttpPost("bulkUpdate")]
        public void Post([FromBody] List<TVSeries> serials)
        {
            tvSeriesService.bulkUpdate(serials);
        }

        [HttpPost("watch")]
        public void watch([FromBody] TVSeries tvSeries)
        {
            tvSeriesService.watchTVSeries(tvSeries);
        }

        [HttpPost("reWatch")]
        public void reWatch([FromBody] TVSeries tvSeries)
        {
            tvSeriesService.reWatchTVSeries(tvSeries);
        }

        [HttpPost("add")]
        public void add([FromBody] TVSeries tvSeries)
        {
            tvSeriesService.addSeries(tvSeries);
        }
    }
}
