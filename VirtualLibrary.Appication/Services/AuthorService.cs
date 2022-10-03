using VirtualLibrary.Appication.Interfaces;
using VirtualLibrary.Domain.Models;
using VirtualLibrary.Repository.Services.Interfaces;

namespace VirtualLibrary.Appication.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public Task<Author> AddAuthor(Author author)
        {
            var result = _authorRepository.Add(author);
            return Task.FromResult(result);
        }
        public Task<Author> UpdateAuthor(Author author)
        {
            var result = _authorRepository.Update(author);
            return Task.FromResult(result);
        }
        public Task<Author> DeleteAuthor(Author author)
        {
            var result = _authorRepository.Delete(author);
            return Task.FromResult(result);
        }

        public Task<List<Author>> GetAllAuthors()
        {
            var result = _authorRepository.GetAllAuthors();
            return result;
        }

        public Task<Author> GetAuthorByID(Guid id)
        {
            var result = _authorRepository.GetAuthorById(id);
            return result;
        }

        public Task<List<Author>> GetAuthorsByBirthDate(DateTime birthDate)
        {
            var result = _authorRepository.GetAllAuthors();
            return result;
        }

        public Task<List<Author>> GetAuthorsByBook(Book book)
        {
            var result = _authorRepository.GetAllAuthors();
            return result;
        }

        public Task<List<Author>> GetAuthorsByGender(string gender)
        {
            var result = _authorRepository.GetAllAuthors();
            return result;
        }


    }
}
