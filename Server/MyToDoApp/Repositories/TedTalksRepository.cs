using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyToDoApp.Model;

namespace MyToDoApp.Repositories
{
    public interface ITedTalksRepository
    {
        public List<TEDTalk> getAll();
        void add(TEDTalk tvSeries);
        void update(TEDTalk tvSeries);
        void bulkUpdate(List<TEDTalk> tvSeries);
    }
}
