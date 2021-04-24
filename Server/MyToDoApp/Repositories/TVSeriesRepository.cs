using MyToDoApp.Model;
using System.Collections.Generic;

namespace MyToDoApp.Repositories
{
    public interface ITVSeriesRepository
    {
        public List<TVSeries> getAllSeries();
        void addSeries(TVSeries tvSeries);
        void updateTVSeries(TVSeries tvSeries);
        void bulkUpdate(List<TVSeries> tvSeries);
    }
}
