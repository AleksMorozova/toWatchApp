using AutoMapper;
using EF;
using MyToDoApp.Model;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;

namespace MyToDoApp.Repositories_EF
{
    public class TVSeriesRepositoryEF: ITVSeriesRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        public TVSeriesRepositoryEF(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void addSeries(Model.TVSeries series)
        {
            using (var c = _context)
            {
                c.TVSerials.Add(_mapper.Map<EF.Model.TVSeries>(series));
                c.SaveChanges();
            }
        }


        public void updateTVSeries(Model.TVSeries tvSeries)
        {
            throw new NotImplementedException();
        }

        public List<Model.TVSeries> getAllSeries()
        {
            List<Model.TVSeries> series = new List<Model.TVSeries>();
            foreach (EF.Model.TVSeries serial in _context.TVSerials)
            {
                series.Add(_mapper.Map<Model.TVSeries>(serial));
            }
            return series;
        }

        public void bulkUpdate(List<TVSeries> tvSeries)
        {
            throw new NotImplementedException();
        }
    }
}
