using Microsoft.EntityFrameworkCore;
using MyToDoApp.DAL.Contracts;
using MyToDoApp.DAL.EF.Model;
using MyToDoApp.DAL.Model;
using System.Linq;

namespace MyToDoApp.DAL.EF.Repositories
{
    public class BooksRepositoryEF : RepositoryEF<Book>, IBooksRepository
    {
        public BooksRepositoryEF(ApplicationContext context) : base(context)
        {
            var blogs = context.Books.Include(blog => blog.Authors).ToList();
        }
    }
}
