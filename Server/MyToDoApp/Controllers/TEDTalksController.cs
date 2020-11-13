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
    public class TEDTalksController : ControllerBase
    {
        private ITedTalksService tedTalksService;
        public TEDTalksController(ITedTalksService tedTalksService)
        {
            this.tedTalksService = tedTalksService;
        }

        [HttpGet("toWatch")]
        public IActionResult getToWatch()
        {
            return Ok(tedTalksService.getAllTEDTalks());
        }

        [HttpPost("bulkUpdate")]
        public async Task<IActionResult> BulkUpdate([FromBody] List<TEDTalk> talks)
        {
            return Ok();
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] TEDTalk talk)
        {
            return Ok();
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] TEDTalk talk)
        {
            return Ok();
        }
    }
}
