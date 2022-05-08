using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> GetBySlugAsync(string slug);
        Task<int> CreateAsync(T entity);
        Task<int> UpdateAsync(T entity);
        void DeleteAsync(string id);
    }
}
