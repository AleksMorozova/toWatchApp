using System.Collections.Generic;
using MyToDoApp.Model;
using MyToDoApp.Repositories;

namespace MyToDoApp.Service
{
    public interface ITVSeriesService {
        List<TVSeries> getAllSeries();
        void addSeries(TVSeries tvSeries);
        void updateTVSeries(TVSeries tvSeries);
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
            throw new System.NotImplementedException();
        }

        public List<TVSeries> getAllSeries() {
            return this.tvSeriesRepository.getAllSeries();
        }

        public void updateTVSeries(TVSeries tvSeries)
        {
            throw new System.NotImplementedException();
        }
    }
}
