using MyToDoApp.Model;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Service
{
    public interface IBooksService {
        public List<Book> getAllBooks();
        public void readBook(Book book);
        public void bulkUpdate(List<Book> book);
        public void addBook(Book book);

    }
    public class BooksService: IBooksService
    {
        IBooksRepository booksRepository;
        public BooksService(IBooksRepository booksRepository)
        {
            this.booksRepository = booksRepository;
        }

        public void addBook(Book book)
        {
            booksRepository.addBook(book);
        }

        public void bulkUpdate(List<Book> book)
        {
            throw new NotImplementedException();
        }

        public List<Book> getAllBooks() {
            return this.booksRepository.getAllBooks();
        }

        public void readBook(Book book)
        {
            book.IsReaded = true;
            booksRepository.updateBook(book);
        }
    }
}
