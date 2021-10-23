using MyToDoApp.Model;
using System;
using System.Threading.Tasks;

namespace MyToDoApp.Services.Contracts
{
    public interface ITVSeriesService : IService<TVSeries>
    {
        Task<TVSeries> WatchTVSeries(Guid id);
        Task<TVSeries> ReWatchTVSeries(Guid id);
    }
}
