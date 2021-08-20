using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Config;
using MyToDoApp.Model;
using MyToDoApp.Service;

namespace MyToDoApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBooksService _booksService;
        private TestOptions testOptions;

        public BooksController(IBooksService booksService, TestOptions testOptions)
        {
            this.testOptions = testOptions;
            _booksService = booksService;
        }

        [HttpGet("all")]
        public IActionResult GetBooksToRead()
        {
            return Ok(_booksService.GetBooksToRead());
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddBook(Book book)
        {
            await _booksService.AddBookAsync(book);
            return Ok(book);
        }

        [HttpPost("read")]
        public void ReadBook(Book book)
        {
            _booksService.ReadBook(book);
        }

        [HttpPost("bulkUpdate")]
        public void UpdateAll(List<Book> books)
        {
            _booksService.BulkUpdate(books);
        }
    }
}
