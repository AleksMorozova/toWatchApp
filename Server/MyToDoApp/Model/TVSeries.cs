using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Model
{
    public class TVSeries
    {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Season { get; set; }
        public string Series { get; set; }
        // public WatchedStatus Status { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public Boolean IsWatched { get; set; }
    }
}
