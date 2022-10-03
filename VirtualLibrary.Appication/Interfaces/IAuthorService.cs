using VirtualLibrary.Domain.Models;

namespace VirtualLibrary.Appication.Interfaces
{
    public interface IAuthorService
    {
        Task<Author> AddAuthor(Author author);
        Task<Author> UpdateAuthor(Author author);
        Task<Author> DeleteAuthor(Author authorID);

        Task<List<Author>> GetAllAuthors();
        Task<Author> GetAuthorByID(Guid id); 
        Task<List<Author>> GetAuthorsByGender(string gender);
        Task<List<Author>> GetAuthorsByBirthDate(DateTime birthDate);
        Task<List<Author>> GetAuthorsByBook(Book book);
    }
}
