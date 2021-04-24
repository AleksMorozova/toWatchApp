using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet("read")]
        public Book Index(int id)
        {
            return this.booksService.getAllBooks().ElementAt(0);
        }

        [HttpGet("toRead")]
        public IEnumerable<Book> GetToRead()
        {
            return booksService.getAllBooks();
        }

        [HttpPost("bulkUpdate")]
        public void UpdateAll([FromBody] List<Book> books)
        {
            this.booksService.bulkUpdate(books);
        }

        [HttpPost("update")]
        public void ReadBook([FromBody] Book book)
        {
            this.booksService.readBook(book);
        }

        [HttpPost("add")]
        public void AddBook([FromBody] Book book)
        {
            this.booksService.addBook(book);
        }
    }
}
