using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Model
{
    public class TEDTalk: BaseEntity
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public Boolean IsWatched { get; set; }
    }
}
