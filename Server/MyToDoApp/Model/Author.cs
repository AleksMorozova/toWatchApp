using System;
using System.ComponentModel.DataAnnotations;

namespace MyToDoApp.Model
{
    public class Author
    {
        [Required]
        public Guid? ID { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
