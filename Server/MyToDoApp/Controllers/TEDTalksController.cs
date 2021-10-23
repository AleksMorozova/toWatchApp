using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Services.Contracts;

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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTalkById(Guid id)
        {
            return Ok(await _tedTalksService.GetById(id));
        }

        [HttpGet("all")]
        public IActionResult getTalksToWatch()
        {
            return Ok(_tedTalksService.GetAll());
        }

        [HttpPost("")]
        public async Task<IActionResult> Add(TEDTalk talk)
        {
            await _tedTalksService.Add(talk);
            return Ok(talk);
        }

        [HttpPost("watch/{id}")]
        public async Task<IActionResult> WatchTEDTalk(Guid id)
        {
            return Ok(await _tedTalksService.WatchTEDTalk(id));
        }
    }
}
