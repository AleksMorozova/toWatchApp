using Microsoft.Extensions.DependencyInjection;
using MyToDoApp.DAL.Contracts;
using MyToDoApp.DAL.Dapper.Repositories;
using MyToDoApp.DAL.EF.Repositories;
using MyToDoApp.Service;
using MyToDoApp.Services.Contracts;

namespace MyToDoApp.Config
{
    public static class ServiceConfiguration
    {
        public static void AddServiceConfiguration(this IServiceCollection services)
        {
            // Services
            services.AddScoped<IMoviesService, MoviesService>();
            services.AddScoped<ITVSeriesService, TVSeriesService>();
            services.AddTransient<IBooksService, BooksService>();
            services.AddScoped<ITedTalksService, TedTalksService>();

            // Repositories
            services.AddScoped<IMoviesRepository, MoviesRepositoryDapper>();
            services.AddScoped<ITVSeriesRepository, TVSeriesRepositoryEF>();
            services.AddScoped<IBooksRepository, BooksRepositoryEF>();
            services.AddTransient<ITedTalksRepository, TedTalksRepositoryEF>();
        }
    }
}
