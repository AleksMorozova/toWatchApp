using MyToDoApp.Model;
using System;
using System.Threading.Tasks;

namespace MyToDoApp.Services.Contracts
{
    public interface IBooksService : IService<Book>
    {
        public Task<Book> ReadBook(Guid id);
    }
}
