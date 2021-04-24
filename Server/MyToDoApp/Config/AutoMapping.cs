using AutoMapper;
using EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Config
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Book, MyToDoApp.Model.Book>();
            CreateMap<MyToDoApp.Model.Book, Book>();

            CreateMap<Movie, MyToDoApp.Model.Movie>();
            CreateMap<MyToDoApp.Model.Movie, Movie>();

            CreateMap<TVSeries, MyToDoApp.Model.TVSeries>();
            CreateMap<MyToDoApp.Model.TVSeries, TVSeries>();

            CreateMap<TEDTalk, MyToDoApp.Model.TEDTalk>();
            CreateMap<MyToDoApp.Model.TEDTalk, TEDTalk>();
        }
    }
}
