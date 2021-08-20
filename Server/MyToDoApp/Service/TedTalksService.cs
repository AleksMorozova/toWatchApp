using AutoMapper;
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
        public List<TEDTalk> GetTEDTalksToWatch();
        public Task<TEDTalk> AddTEDTalk(TEDTalk talk);
        public TEDTalk WatchTEDTalk(TEDTalk talk);
        public void BulkUpdate(List<TEDTalk> talk);
    }

    public class TedTalksService : ITedTalksService
    {
        private readonly ITedTalksRepository _tedTalksRepository;
        private readonly IMapper _mapper;

        public TedTalksService(ITedTalksRepository tedTalksRepository, IMapper mapper)
        {
            _tedTalksRepository = tedTalksRepository;
            _mapper = mapper;
        }
        public List<TEDTalk> GetTEDTalksToWatch()
        {
            List<TEDTalk> talks = new List<TEDTalk>();
            foreach (EF.Model.TEDTalk talk in _tedTalksRepository.GetAll())
            {
                talks.Add(_mapper.Map<TEDTalk>(talk));
            }

            return talks;
        }
        public async Task<TEDTalk> AddTEDTalk(TEDTalk talk)
        {
            EF.Model.TEDTalk newTalk = await _tedTalksRepository.AddAsync(_mapper.Map<EF.Model.TEDTalk>(talk));
            return _mapper.Map<TEDTalk>(newTalk);
        }
        public TEDTalk WatchTEDTalk(TEDTalk talk)
        {
            talk.IsWatched = false;
            EF.Model.TEDTalk newTalk= _mapper.Map<EF.Model.TEDTalk>(talk);
            return _mapper.Map<TEDTalk>(_tedTalksRepository.Update(newTalk));
        }
        public void BulkUpdate(List<TEDTalk> talk)
        {
            throw new NotImplementedException();
        }
    }
}
