using EF;
using EF.Model;
using MyToDoApp.Converters;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories_EF
{
    public class TVSeriesRepositoryEF: ITVSeriesRepository
    {
        ApplicationContext context;

        public TVSeriesRepositoryEF(ApplicationContext context)
        {
            this.context = context;
        }
        public void addSeries(Model.TVSeries series)
        {
            using (var c = context)
            {
                c.TVSerials.Add(TVSeriesConverter.convertToDTO(series));
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
            foreach (EF.Model.TVSeries serial in context.TVSerials)
            {
                series.Add(TVSeriesConverter.convertFromDTO(serial));
            }
            return series;
        }

        public List<Model.TVSeries> getAll()
        {
            throw new NotImplementedException();
        }

        public void add(Model.TVSeries tvSeries)
        {
            throw new NotImplementedException();
        }

        public void update(Model.TVSeries tvSeries)
        {
            throw new NotImplementedException();
        }

        public void bulkUpdate(List<Model.TVSeries> tvSeries)
        {
            throw new NotImplementedException();
        }
    }
}
