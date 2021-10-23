using AutoMapper;
using MyToDoApp.DAL.Model;

namespace MyToDoApp.Config
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Model.Book, DAL.Model.Book>();
            CreateMap<DAL.Model.Book, Model.Book>();

            CreateMap<Movie, Model.Movie>();
            CreateMap<Model.Movie, Movie>();

            CreateMap<TVSeries, Model.TVSeries>();
            CreateMap<Model.TVSeries, TVSeries>();

            CreateMap<TEDTalk, Model.TEDTalk>();
            CreateMap<Model.TEDTalk, TEDTalk>();
        }
    }
}
