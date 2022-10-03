using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualLibrary.Domain.Models;
using VirtualLibrary.Domain.Models.DTOS;

namespace VirtualLibrary.Repository.Services.Interfaces
{
    public interface IAuthorRepository : IRepositoryBase
    {
        Task<List<Author>> GetAllAuthors();
        Task<Author> GetAuthorById(Guid id);
        Task<List<Author>> GetAuthorsByGender(string gender);
        Task<List<Author>> GetAuthorsByBirthDate(DateTime birthDate);
        Task<List<Author>> GetAuthorsByBook(Book book);
    }
}
