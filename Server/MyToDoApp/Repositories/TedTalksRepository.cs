using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories
{
    public interface ITedTalksRepository
    {
        public List<EF.Model.TEDTalk> GetAll();
        Task<EF.Model.TEDTalk> AddAsync(EF.Model.TEDTalk tvSeries);
        EF.Model.TEDTalk Update(EF.Model.TEDTalk tvSeries);
        void BulkUpdate(List<EF.Model.TEDTalk> tvSeries);
    }
}
