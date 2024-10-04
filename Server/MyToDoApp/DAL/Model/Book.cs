﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyToDoApp.DAL.Model
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Boolean IsReaded { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}
