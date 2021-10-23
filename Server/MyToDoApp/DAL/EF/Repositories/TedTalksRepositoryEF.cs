using AutoMapper;
using MyToDoApp.DAL.Contracts;
using MyToDoApp.DAL.EF.Model;
using MyToDoApp.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.DAL.EF.Repositories
{
    public class TedTalksRepositoryEF : RepositoryEF<TEDTalk>, ITedTalksRepository
    {
        private readonly IMapper _mapper;

        public TedTalksRepositoryEF(ApplicationContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public void BulkUpdate(List<TEDTalk> tvSeries)
        {
            throw new NotImplementedException();
        }
    }
}
