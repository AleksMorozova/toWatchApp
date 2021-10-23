using MyToDoApp.Model;
using System;
using System.Threading.Tasks;

namespace MyToDoApp.Services.Contracts
{
    public interface IMoviesService : IService<Movie>
    {
        Task<Movie> WatchMovie(Guid id);
        Task<Movie> ReWatchMovie(Guid id);
    }
}
