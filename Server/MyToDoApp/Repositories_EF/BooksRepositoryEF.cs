using EF;
using MyToDoApp.Repositories;

namespace MyToDoApp.Repositories_EF
{
    public class BooksRepositoryEF : RepositoryEF<EF.Model.Book>, IBooksRepository
    {
        public BooksRepositoryEF(ApplicationContext context) : base(context)
        {
        }
    }
}
