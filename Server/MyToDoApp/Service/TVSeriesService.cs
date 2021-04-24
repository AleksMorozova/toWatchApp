using System.Collections.Generic;
using MyToDoApp.Model;
using MyToDoApp.Repositories;

namespace MyToDoApp.Service
{
    public interface ITVSeriesService {
        List<TVSeries> getAllSeries();
        void addSeries(TVSeries tvSeries);
        void watchTVSeries(TVSeries tvSeries);
        void reWatchTVSeries(TVSeries tvSeries);

        void bulkUpdate(List<TVSeries> tvSeries);
    }
    public class TVSeriesService: ITVSeriesService
    {
        private ITVSeriesRepository tvSeriesRepository;

        public TVSeriesService(ITVSeriesRepository tvSeriesRepository)
        {
            this.tvSeriesRepository = tvSeriesRepository;
        }

        public void addSeries(TVSeries tvSeries)
        {
            tvSeriesRepository.addSeries(tvSeries);
        }

        public void bulkUpdate(List<TVSeries> tvSerials)
        {
            tvSeriesRepository.bulkUpdate(tvSerials);
        }

        public List<TVSeries> getAllSeries() {
            return tvSeriesRepository.getAllSeries();
        }

        public void reWatchTVSeries(TVSeries tvSeries)
        {
            tvSeries.IsWatched = false;
            tvSeriesRepository.updateTVSeries(tvSeries);
        }

        public void watchTVSeries(TVSeries tvSeries)
        {
            tvSeries.IsWatched = true;
            tvSeriesRepository.updateTVSeries(tvSeries);
        }
    }
}
