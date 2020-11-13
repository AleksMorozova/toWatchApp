using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Model
{
    public class TEDTalk
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public Boolean IsWatched { get; set; }
    }
}
