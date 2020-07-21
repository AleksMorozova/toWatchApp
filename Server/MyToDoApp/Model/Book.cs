using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.Model
{
    public class Book
    {
        public Guid ID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }
        public Boolean IsReaded { get; set; }
    }
}
