using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.DAL.Model
{
    public class TEDTalk : BaseEntity
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public Boolean IsWatched { get; set; }
    }
}
