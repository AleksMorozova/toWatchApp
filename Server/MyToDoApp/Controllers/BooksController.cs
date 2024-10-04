using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Services.Contracts;

namespace MyToDoApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBooksService _booksService;
        private IRateService _rateService;
        public BooksController(IBooksService booksService, IRateService rateService)
        {
            _booksService = booksService;
            _rateService = rateService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(Guid id)
        {
            var rate = await _rateService.GetRate();
            return Ok(await _booksService.GetById(id));
        }

        [HttpGet("all")]
        public IActionResult GetBookToRead()
        {
            return Ok(_booksService.GetAll());
        }

        [HttpPost("")]
        public async Task<IActionResult> AddBook(CreateBook book)
        {//await _booksService.Add(book)
            return Ok();
        }

        [HttpPost("read/{id}")]
        public async Task<IActionResult> ReadBook(Guid id)
        {
            return Ok(await _booksService.ReadBook(id));
        }
    }
}
