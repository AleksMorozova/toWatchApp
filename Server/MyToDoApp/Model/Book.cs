using System;
using System.ComponentModel.DataAnnotations;

namespace MyToDoApp.Model
{
    public class Book
    {

        [Required]
        public Guid? ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public Boolean IsReaded { get; set; }
    }
}
