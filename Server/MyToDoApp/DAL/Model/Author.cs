using System.Collections.Generic;

namespace MyToDoApp.DAL.Model
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
