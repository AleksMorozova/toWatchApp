using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Model
{
    public class TVSeries
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Season { get; set; }
        public string Series { get; set; }
        // public WatchedStatus Status { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
