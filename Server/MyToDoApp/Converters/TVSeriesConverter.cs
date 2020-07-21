using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Converters
{
    public static class TVSeriesConverter
    {
        public static MyToDoApp.Model.TVSeries convertFromDTO(EF.Model.TVSeries tvSeries)
        {
            MyToDoApp.Model.TVSeries t = new MyToDoApp.Model.TVSeries();
            t.ID = tvSeries.ID;
            t.Title = tvSeries.Title;
            t.Description = tvSeries.Description;
            t.Season = tvSeries.Season;
            t.Series = tvSeries.Series;
            t.Link = tvSeries.Link;

            return t;
        }
        public static EF.Model.TVSeries convertToDTO(MyToDoApp.Model.TVSeries tvSeries)
        {
            EF.Model.TVSeries t = new EF.Model.TVSeries();
            t.ID = tvSeries.ID;
            t.Title = tvSeries.Title;
            t.Description = tvSeries.Description;
            t.Season = tvSeries.Season;
            t.Series = tvSeries.Series;
            t.Link = tvSeries.Link;
            return t;
        }
    }
}
