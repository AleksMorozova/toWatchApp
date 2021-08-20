using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories
{
    public interface IMoviesRepository
    {
        public List<EF.Model.Movie> GetAll();
        public EF.Model.Movie Update(EF.Model.Movie movie);
        public Task<EF.Model.Movie> AddAsync(EF.Model.Movie movie);
        public void BulkUpdate(List<EF.Model.Movie> movies);
    }
}
