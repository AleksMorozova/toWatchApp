using AutoMapper;
using MyToDoApp.DAL.Model;
using System.Linq;

namespace MyToDoApp.Config
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Model.Book, DAL.Model.Book>();

            CreateMap<DAL.Model.Book, Model.Book>()
                .ForMember(dest => dest.Authors, opt => opt.MapFrom(src => string.Join(", ", src.Authors.Select(_ => _.Name))));

            CreateMap<Movie, Model.Movie>();
            CreateMap<Model.Movie, Movie>();

            CreateMap<TVSeries, Model.TVSeries>();
            CreateMap<Model.TVSeries, TVSeries>();

            CreateMap<TEDTalk, Model.TEDTalk>();
            CreateMap<Model.TEDTalk, TEDTalk>();
        }
    }
}
