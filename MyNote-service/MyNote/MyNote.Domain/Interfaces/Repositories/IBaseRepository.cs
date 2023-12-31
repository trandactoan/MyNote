using MyNote.Domain.Entities;
using System.Linq.Expressions;

namespace MyNote.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> CreateAsync(T entity, bool completeSingle = false);
        Task<T[]?> CreateRangeAsync(T[] entities, bool completeSingle = false);
        Task<T> UpdateAsync(T entity, bool completeSingle = false);
        Task<T[]?> UpdateRangeAsync(T[] entities, bool completeSingle = false);
        Task DeleteAsync(T entity, bool completeSingle = false);
        Task DeleteRangeAsync(T[] entities, bool completeSingle = false);
        Task<T?> FindByIdAsync(string entityId, bool trackChange = false);
        Task<IEnumerable<T>> FindAllAsync(bool trackChange = false);
        Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression, bool trackChange = false);
        Task<T?> FindFirstByConditionAsync(Expression<Func<T, bool>> expression, bool trackChange = false);
    }
}
