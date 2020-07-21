using MyToDoApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories
{
    public interface IBooksRepository
    {
        public List<Book> getAllBooks();
        public void addBook(Book book);
        public void updateBook(Book book);
    }
}
