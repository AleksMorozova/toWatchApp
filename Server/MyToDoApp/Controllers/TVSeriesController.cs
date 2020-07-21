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
        }

        [HttpPost("update")]
        public void Post([FromBody] TVSeries tvSeries)
        {
        }
    }
}
