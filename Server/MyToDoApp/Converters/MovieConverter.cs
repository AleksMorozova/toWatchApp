using EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyToDoApp.Model;
namespace MyToDoApp.Converters
{
    public static class MovieConverter
    {
        public static MyToDoApp.Model.Movie convertFromDTO(EF.Model.Movie movie) {
            MyToDoApp.Model.Movie m = new MyToDoApp.Model.Movie();
            m.Title = movie.Title;
            m.Description = movie.Description;
            m.Link = movie.Link;
            m.ID = movie.ID;
            m.IsWatched = movie.IsWatched;
            return m;
        }
        public static EF.Model.Movie convertToDTO(MyToDoApp.Model.Movie movie)
        {
            EF.Model.Movie m = new EF.Model.Movie();
            m.Title = movie.Title;
            m.Description = movie.Description;
            m.Link = movie.Link;
            m.ID = movie.ID;
            m.IsWatched = movie.IsWatched;
            return m;
        }
    }
}
