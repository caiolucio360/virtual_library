using System;
using System.Collections.Generic;

namespace VirtualLibrary.Domain.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public Guid PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public DateTime ReleaseDate { get; set; } 
        public string Category { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
