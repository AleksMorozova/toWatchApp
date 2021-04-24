using AutoMapper;
using EF;
using MyToDoApp.Model;
using MyToDoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyToDoApp.Repositories_EF
{
    public class TedTalksRepositoryEF : ITedTalksRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public TedTalksRepositoryEF(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void add(TEDTalk tedTalk)
        {
            using (var c = _context)
            {
                c.TEDTalks.Add(_mapper.Map<EF.Model.TEDTalk>(tedTalk));
                c.SaveChanges();
            }
        }

        public void bulkUpdate(List<TEDTalk> talks)
        {
            foreach (TEDTalk talk in talks)
            {
                var t = _context.TEDTalks.Where(m => talk.ID == m.ID).First();
                t.IsWatched = talk.IsWatched;
                t.Link = talk.Link;
                t.Title = talk.Title;
            }
            _context.SaveChanges();
        }

        public List<TEDTalk> getAll()
        {
            List<TEDTalk> talks = new List<TEDTalk>();
            foreach (EF.Model.TEDTalk talk in _context.TEDTalks)
            {
                talks.Add(_mapper.Map<TEDTalk>(talk));
            }

            return talks;
        }

        public void update(TEDTalk talk)
        {
            var t = _context.TEDTalks.Where(m => talk.ID == m.ID).First();
            t.IsWatched = talk.IsWatched;
            t.Link = talk.Link;
            t.Title = talk.Title;
            _context.SaveChanges();
        }
    }
}
