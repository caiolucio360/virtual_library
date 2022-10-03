using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualLibrary.Repository.Data;
using System;
using VirtualLibrary.Domain.Models;
using VirtualLibrary.Repository.Services.Interfaces;
using System.Linq;

namespace VirtualLibrary.Repository.Services
{
    public class AuthorRepository : RepositoryBase, IAuthorRepository
    {
        private readonly DataContext _context;
        public AuthorRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Author>> GetAllAuthors()
        {
            var result = await _context.Authors.ToListAsync();
            return result;
        }

        public async Task<Author> GetAuthorById(Guid id)
        {
            try
            {
                var result = await _context.Authors.Where(c => c.AuthorId == id).FirstOrDefaultAsync();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Author>> GetAuthorsByBirthDate(DateTime birthDate)
        {
            var result = await _context.Authors.Where(c => c.BirthDate == birthDate).ToListAsync();
            return result;
        }

        public async Task<List<Author>> GetAuthorsByBook(Book book)
        {
            var result = await _context.Authors.Where(c => c.Books == book).ToListAsync();
            return result;
        }

        public async Task<List<Author>> GetAuthorsByGender(string gender)
        {
            var result = await _context.Authors.Where(c => c.Gender == gender).ToListAsync();
            return result;
        }
    }
}
