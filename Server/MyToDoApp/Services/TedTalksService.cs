using AutoMapper;
using MyToDoApp.DAL.Contracts;
using MyToDoApp.Model;
using MyToDoApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyToDoApp.Service
{
    public class TedTalksService : ITedTalksService
    {
        private readonly ITedTalksRepository _tedTalksRepository;
        private readonly IMapper _mapper;

        public TedTalksService(ITedTalksRepository tedTalksRepository, IMapper mapper)
        {
            _tedTalksRepository = tedTalksRepository;
            _mapper = mapper;
        }
        public async Task<TEDTalk> GetById(Guid id)
        {
            var talk = await _tedTalksRepository.GetById(id);
            return _mapper.Map<TEDTalk>(talk);
        }
        public List<TEDTalk> GetAll()
        {
            var talks = new List<TEDTalk>();
            foreach (DAL.Model.TEDTalk talk in _tedTalksRepository.GetAll())
            {
                talks.Add(_mapper.Map<TEDTalk>(talk));
            }

            return talks;
        }
        public async Task<TEDTalk> Add(TEDTalk talk)
        {
            var newTalk = await _tedTalksRepository.AddAsync(_mapper.Map<DAL.Model.TEDTalk>(talk));
            return _mapper.Map<TEDTalk>(newTalk);
        }
        public async Task<TEDTalk> WatchTEDTalk(Guid id)
        {
            var talk = await _tedTalksRepository.GetById(id);
            if (!talk.IsWatched)
            {
                talk.IsWatched = true;
            }
            return _mapper.Map<TEDTalk>(_tedTalksRepository.Update(talk));
        }
    }
}
