using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Model
{
    public class Book: BaseEntity
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public Boolean IsReaded { get; set; }
    }
}
