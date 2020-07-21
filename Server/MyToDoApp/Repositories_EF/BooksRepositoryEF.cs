using EF;
using MyToDoApp.Converters;
using MyToDoApp.Model;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories_EF
{
    public class BooksRepositoryEF : IBooksRepository
    {
        ApplicationContext context;

        public BooksRepositoryEF(ApplicationContext context)
        {
            this.context = context;
        }
        public void addBook(Book book)
        {
            using (var c = context)
            {
                c.Books.Add(Converters.BookConverter.convertToDTO(book));
                c.SaveChanges();
            }
        }

        public List<Book> getAllBooks()
        {
            List<Book> books = new List<Book>();
            foreach (EF.Model.Book book in context.Books)
            {
                books.Add(BookConverter.convertFromDTO(book));
            }

            return books;
        }

        public void updateBook(Book book)
        {
            foreach (EF.Model.Book b in context.Books.Where(m => book.ID == m.ID)) {
                b.IsReaded = book.IsReaded;
                b.Author = book.Author;
                b.Title = book.Title;
                b.Description = book.Description;
            }
            context.SaveChanges();
        }
    }
}
