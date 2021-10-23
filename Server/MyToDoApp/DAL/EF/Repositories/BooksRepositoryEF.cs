using MyToDoApp.DAL.Contracts;
using MyToDoApp.DAL.EF.Model;
using MyToDoApp.DAL.Model;

namespace MyToDoApp.DAL.EF.Repositories
{
    public class BooksRepositoryEF : RepositoryEF<Book>, IBooksRepository
    {
        public BooksRepositoryEF(ApplicationContext context) : base(context)
        {
        }
    }
}
