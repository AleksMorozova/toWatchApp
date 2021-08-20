using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MyToDoApp.Model;
using MyToDoApp.Repositories;

namespace MyToDoApp.Service
{
    public interface ITVSeriesService {
        List<TVSeries> GetSeriesToWatch();
        Task<TVSeries> AddSeries(TVSeries tvSeries);
        TVSeries WatchTVSeries(TVSeries tvSeries);
        TVSeries ReWatchTVSeries(TVSeries tvSeries);
        void BulkUpdate(List<TVSeries> tvSeries);
    }
    public class TVSeriesService: ITVSeriesService
    {
        private readonly ITVSeriesRepository _tvSeriesRepository;
        private readonly IMapper _mapper;
        public TVSeriesService(ITVSeriesRepository tvSeriesRepository, IMapper mapper)
        {
            _tvSeriesRepository = tvSeriesRepository;
            _mapper = mapper;

        }
        public List<TVSeries> GetSeriesToWatch()
        {
            List<TVSeries> listOfSeries = new List<TVSeries>();
            foreach (EF.Model.TVSeries series in _tvSeriesRepository.GetAll())
            {
                listOfSeries.Add(_mapper.Map<TVSeries>(series));
            }

            return listOfSeries;
        }
        public async Task<TVSeries> AddSeries(TVSeries tvSeries)
        {
            EF.Model.TVSeries newTVSeries = await _tvSeriesRepository.AddAsync(_mapper.Map<EF.Model.TVSeries>(tvSeries));
            return _mapper.Map<TVSeries>(newTVSeries);
        }
        public TVSeries ReWatchTVSeries(TVSeries tvSeries)
        {
            tvSeries.IsWatched = false;
            EF.Model.TVSeries newTVSeries = _mapper.Map<EF.Model.TVSeries>(tvSeries);
            return _mapper.Map<TVSeries>(_tvSeriesRepository.Update(newTVSeries));
        }
        public TVSeries WatchTVSeries(TVSeries tvSeries)
        {
            tvSeries.IsWatched = true;
            EF.Model.TVSeries newTVSeries = _mapper.Map<EF.Model.TVSeries>(tvSeries);
            return _mapper.Map<TVSeries>(_tvSeriesRepository.Update(newTVSeries));
        }
        public void BulkUpdate(List<TVSeries> tvSerials)
        {
            // tvSeriesRepository.BulkUpdate(tvSerials);
        }
    }
}
