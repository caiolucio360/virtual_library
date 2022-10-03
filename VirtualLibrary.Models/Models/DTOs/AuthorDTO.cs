using System;

namespace VirtualLibrary.Domain.Models.DTOS
{
    public class AuthorDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
    }
}
