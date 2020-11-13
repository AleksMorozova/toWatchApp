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

        public List<Model.TVSeries> getAll()
        {
            List<Model.TVSeries> series = new List<Model.TVSeries>();
            foreach (EF.Model.TVSeries serial in context.TVSerials)
            {
                series.Add(TVSeriesConverter.convertFromDTO(serial));
            }
            return series;
        }

        public void add(Model.TVSeries tvSeries)
        {
            using (var c = context)
            {
                c.TVSerials.Add(TVSeriesConverter.convertToDTO(tvSeries));
                c.SaveChanges();
            }
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
