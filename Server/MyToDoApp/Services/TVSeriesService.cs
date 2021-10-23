using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MyToDoApp.DAL.Contracts;
using MyToDoApp.Model;
using MyToDoApp.Services.Contracts;

namespace MyToDoApp.Service
{
    public class TVSeriesService: ITVSeriesService
    {
        private readonly ITVSeriesRepository _tvSeriesRepository;
        private readonly IMapper _mapper;
        public TVSeriesService(ITVSeriesRepository tvSeriesRepository, IMapper mapper)
        {
            _tvSeriesRepository = tvSeriesRepository;
            _mapper = mapper;
        }
        public async Task<TVSeries> GetById(Guid id)
        {
            var series = await _tvSeriesRepository.GetById(id);
            return _mapper.Map<TVSeries>(series);
        }
        public List<TVSeries> GetAll()
        {
            var listOfSeries = new List<TVSeries>();
            foreach (DAL.Model.TVSeries series in _tvSeriesRepository.GetAll())
            {
                listOfSeries.Add(_mapper.Map<TVSeries>(series));
            }

            return listOfSeries;
        }
        public async Task<TVSeries> Add(TVSeries tvSeries)
        {
            var newTVSeries = await _tvSeriesRepository.AddAsync(_mapper.Map<DAL.Model.TVSeries>(tvSeries));
            return _mapper.Map<TVSeries>(newTVSeries);
        }
        public async Task<TVSeries> ReWatchTVSeries(Guid id)
        {
            var tvSeries = await _tvSeriesRepository.GetById(id);
            if (tvSeries.IsWatched)
            {
                tvSeries.IsWatched = false;
            }
            return _mapper.Map<TVSeries>(_tvSeriesRepository.Update(tvSeries));
        }
        public async Task<TVSeries> WatchTVSeries(Guid id)
        {
            var tvSeries = await _tvSeriesRepository.GetById(id);
            if (!tvSeries.IsWatched)
            {
                tvSeries.IsWatched = true;
            }
            return _mapper.Map<TVSeries>(_tvSeriesRepository.Update(tvSeries));
        }
    }
}
