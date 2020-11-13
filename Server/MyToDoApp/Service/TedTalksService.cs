using MyToDoApp.Model;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Service
{
    public interface ITedTalksService
    {
        public List<TEDTalk> getAllTEDTalks();
        public void watchTEDTalk(TEDTalk talk);
        public void bulkUpdate(List<TEDTalk> talk);
        public void addTEDTalk(TEDTalk talk);

    }
    public class TedTalksService : ITedTalksService
    {
        ITedTalksRepository tedTalksRepository;
        public TedTalksService(ITedTalksRepository tedTalksRepository)
        {
            this.tedTalksRepository = tedTalksRepository;
        }

        public void addTEDTalk(TEDTalk talk)
        {
            throw new NotImplementedException();
        }

        public void bulkUpdate(List<TEDTalk> talk)
        {
            throw new NotImplementedException();
        }

        public List<TEDTalk> getAllTEDTalks()
        {
            return this.tedTalksRepository.getAll();
        }

        public void watchTEDTalk(TEDTalk talk)
        {
            throw new NotImplementedException();
        }
    }
}
