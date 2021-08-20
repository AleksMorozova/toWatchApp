using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories
{
    public interface IBooksRepository
    {
        public List<EF.Model.Book> GetAll();
        public Task<EF.Model.Book> AddAsync(EF.Model.Book book);
        public EF.Model.Book Update(EF.Model.Book book);
    }
}
