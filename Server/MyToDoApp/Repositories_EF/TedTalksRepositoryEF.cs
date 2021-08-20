using AutoMapper;
using EF;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;

namespace MyToDoApp.Repositories_EF
{
    public class TedTalksRepositoryEF : RepositoryEF<EF.Model.TEDTalk>, ITedTalksRepository
    {
        private readonly IMapper _mapper;

        public TedTalksRepositoryEF(ApplicationContext context, IMapper mapper): base(context)
        {
            _mapper = mapper;
        }

        public void BulkUpdate(List<EF.Model.TEDTalk> tvSeries)
        {
            throw new NotImplementedException();
        }
    }
}
