using MyToDoApp.DAL.Contracts;
using MyToDoApp.DAL.EF.Model;
using MyToDoApp.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.DAL.EF.Repositories
{
    public class TVSeriesRepositoryEF : RepositoryEF<TVSeries>, ITVSeriesRepository
    {
        public TVSeriesRepositoryEF(ApplicationContext context) : base(context)
        {
        }
        public void BulkUpdate(List<TVSeries> tvSeries)
        {
            throw new NotImplementedException();
        }
    }
}
