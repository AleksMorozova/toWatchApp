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

        public BooksController(IBooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(Guid id)
        {
            return Ok(await _booksService.GetById(id));
        }

        [HttpGet("all")]
        public IActionResult GetBookToRead()
        {
            return Ok(_booksService.GetAll());
        }

        [HttpPost("")]
        public async Task<IActionResult> AddBook(Book book)
        {
            return Ok(await _booksService.Add(book));
        }

        [HttpPost("read/{id}")]
        public async Task<IActionResult> ReadBook(Guid id)
        {
            return Ok(await _booksService.ReadBook(id));
        }
    }
}
