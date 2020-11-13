using MyToDoApp.Model;
using System.Collections.Generic;

namespace MyToDoApp.Repositories
{
    public interface ITVSeriesRepository
    {
        public List<TVSeries> getAll();
        void add(TVSeries tvSeries);
        void update(TVSeries tvSeries);
        void bulkUpdate(List<TVSeries> tvSeries);
    }
}
