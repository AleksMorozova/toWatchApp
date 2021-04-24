using AutoMapper;
using EF;
using MyToDoApp.Model;
using MyToDoApp.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MyToDoApp.Repositories_EF
{
    public class BooksRepositoryEF : IBooksRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        public BooksRepositoryEF(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void addBook(Book book)
        {
            using (var c = _context)
            {
                var newBook = _mapper.Map<EF.Model.Book>(book);
                c.Books.Add(newBook);
                c.SaveChanges();
            }
        }

        public List<Book> getAllBooks()
        {
            List<Book> books = new List<Book>();
            foreach (EF.Model.Book book in _context.Books)
            {
                var newBook = _mapper.Map<Book>(book);
                books.Add(newBook);
            }

            return books;
        }

        public void updateBook(Book book)
        {
            foreach (EF.Model.Book b in _context.Books.Where(m => book.ID == m.ID)) {
                b.IsReaded = book.IsReaded;
                b.Author = book.Author;
                b.Title = book.Title;
                b.Description = book.Description;
            }
            _context.SaveChanges();
        }
    }
}
