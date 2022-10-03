using System;
using System.Threading.Tasks;
using VirtualLibrary.Repository.Data;

namespace VirtualLibrary.Repository.Services
{
    public class RepositoryBase
    {
        private readonly DataContext _context;
        public RepositoryBase(DataContext context)
        {
            _context = context;
        }

        public T Add<T>(T entity) where T : class
        {
            try
            {
                var result = _context.Add(entity);
                return result.Entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T Update<T>(T entity) where T : class
        {
            var result = _context.Update(entity);
            return result.Entity;
        }

        public T Delete<T>(T entity) where T : class
        {
            var result = _context.Remove(entity);
            return result.Entity;
        }

        public async Task<int> SaveChangesAsync()
        {
            var result = await _context.SaveChangesAsync();
            return result;
        }
    }
}
