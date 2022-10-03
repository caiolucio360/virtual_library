using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VirtualLibrary.Domain.Models
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
