using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Service;

namespace MyToDoApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TEDTalksController : ControllerBase
    {
        private ITedTalksService _tedTalksService;
        public TEDTalksController(ITedTalksService tedTalksService)
        {
            _tedTalksService = tedTalksService;
        }

        [HttpGet("all")]
        public IActionResult getTalksToWatch()
        {
            return Ok(_tedTalksService.GetTEDTalksToWatch());
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(TEDTalk talk)
        {
            await _tedTalksService.AddTEDTalk(talk);
            return Ok(talk);
        }

        [HttpPost("watch")]
        public IActionResult Update(TEDTalk talk)
        {
            _tedTalksService.WatchTEDTalk(talk);
            return Ok();
        }

        [HttpPost("bulkUpdate")]
        public IActionResult BulkUpdate(List<TEDTalk> talks)
        {
            return Ok();
        }
    }
}
