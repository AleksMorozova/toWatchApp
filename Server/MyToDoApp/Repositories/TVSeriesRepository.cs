using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories
{
    public interface ITVSeriesRepository
    {
        public List<EF.Model.TVSeries> GetAll();
        Task<EF.Model.TVSeries> AddAsync(EF.Model.TVSeries tvSeries);
        EF.Model.TVSeries Update(EF.Model.TVSeries tvSeries);
        void BulkUpdate(List<EF.Model.TVSeries> tvSeries);
    }
}
