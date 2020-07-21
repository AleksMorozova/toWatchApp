using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Model
{
    public class Movie: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public Boolean isWatched { get; set; }
    }
}
