using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace VirtualLibrary.Repository.Services.Interfaces
{
    public interface IRepositoryBase
    {
        T Add<T>(T entity) where T: class;
        T Update<T>(T entity) where T : class;
        T Delete<T>(T entity) where T : class;
        Task<int> SaveChangesAsync();
    }
}
