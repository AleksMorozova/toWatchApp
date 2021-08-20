using EF;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;

namespace MyToDoApp.Repositories_EF
{
    public class TVSeriesRepositoryEF : RepositoryEF<EF.Model.TVSeries>, ITVSeriesRepository
    {
        public TVSeriesRepositoryEF(ApplicationContext context): base(context)
        {
        }
        public void BulkUpdate(List<EF.Model.TVSeries> tvSeries)
        {
            throw new NotImplementedException();
        }
    }
}
