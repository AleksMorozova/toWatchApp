using MyToDoApp.Model;
using System;
using System.Threading.Tasks;

namespace MyToDoApp.Services.Contracts
{
    public interface ITedTalksService : IService<TEDTalk>
    {
        public Task<TEDTalk> WatchTEDTalk(Guid id);
    }
}
