using EF;
using MyToDoApp.Converters;
using MyToDoApp.Model;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Repositories_EF
{
    public class TedTalksRepositoryEF : ITedTalksRepository
    {
        ApplicationContext context;

        public TedTalksRepositoryEF(ApplicationContext context)
        {
            this.context = context;
        }

        public void add(TEDTalk tvSeries)
        {
            throw new NotImplementedException();
        }

        public void bulkUpdate(List<TEDTalk> tvSeries)
        {
            throw new NotImplementedException();
        }

        public List<TEDTalk> getAll()
        {
            List<TEDTalk> talks = new List<TEDTalk>();
            foreach (EF.Model.TEDTalk talk in context.TEDTalks)
            {
                talks.Add(TedTalkConverter.convertFromDTO(talk));
            }

            return talks;
        }

        public void update(TEDTalk tvSeries)
        {
            throw new NotImplementedException();
        }
    }
}
