using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyToDoApp.Model;
using MyToDoApp.Service;


namespace MyToDoApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private IBooksService booksService;
        public BooksController(IBooksService booksService)
        {
            this.booksService = booksService;
        }

        [HttpGet("all")]
        public IEnumerable<Book> Get()
        {
            return booksService.getAllBooks();
        }

        [HttpPost("bulkUpdate")]
        public void Post([FromBody] List<Book> books)
        {
            this.booksService.bulkUpdate(books);
        }

        [HttpPost("update")]
        public void Post([FromBody] Book book)
        {
            this.booksService.readBook(book);
        }

        [HttpPost("add")]
        public void add([FromBody] Book book)
        {
            this.booksService.addBook(book);
        }
    }
}
