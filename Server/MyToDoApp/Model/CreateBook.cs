using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyToDoApp.Model
{
    public class CreateBook
    {
        [Required]
        public Guid? ID { get; set; }
        [Required]
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public string Description { get; set; }
    }
}
