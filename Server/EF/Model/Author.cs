using System;
using System.Collections.Generic;
using System.Text;

namespace EF.Model
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
