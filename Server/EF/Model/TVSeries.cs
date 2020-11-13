using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Model
{
    public class TVSeries: BaseEntity
    {
        public string Title { get; set; }
        public string Season { get; set; }
        public string Series { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public Boolean IsWatched { get; set; }
    }
}
