using Microsoft.EntityFrameworkCore;
using MyNote.Domain.Entities;
using MyNote.Domain.Interfaces.Repositories;
using System.Linq.Expressions;

namespace MyNote.Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DbContext _context;
        public BaseRepository(DbContext context)
        {
            _context = context;
        }
        public async Task<T> CreateAsync(T entity, bool completeSingle = false)
        {
            var result = await _context.Set<T>().AddAsync(entity);
            if (completeSingle)
            {
                await _context.SaveChangesAsync();
            }
            return result.Entity;
        }
        public async Task<T[]?> CreateRangeAsync(T[] entities, bool completeSingle = false)
        {
            if(entities!= null && entities.Length>0)
            {
                await _context.AddRangeAsync(entities);
                if (completeSingle)
                {
                    await _context.SaveChangesAsync();
                }
            }
            return entities;
        }
        public async Task<T> UpdateAsync(T entity, bool completeSingle = false)
        {
            var result = await _context.Set<T>().AddAsync(entity);
            if (completeSingle)
            {
                await _context.SaveChangesAsync();
            }
            return result.Entity;
        }
        public async Task<T[]?> UpdateRangeAsync(T[] entities, bool completeSingle = false)
        {
            if(entities!= null && entities.Length>0)
            {
                await _context.AddRangeAsync(entities);
                if (completeSingle)
                {
                    await _context.SaveChangesAsync();
                }
            }
            return entities;
        }
        public async Task DeleteAsync(T entity, bool completeSingle = false)
        {
            _context.Set<T>().Remove(entity);
            if (completeSingle)
            {
                await _context.SaveChangesAsync();
            }
        }
        public async Task DeleteRangeAsync(T[] entities, bool completeSingle = false)
        {
            if(entities!= null && entities.Length>0)
            {
                _context.Set<T>().RemoveRange(entities);

                if (completeSingle)
                {
                    await _context.SaveChangesAsync();
                }
            }
        }
        public async Task<T?> FindByIdAsync(string entityId, bool trackChange = false)
        {
            var result = await _context.Set<T>().FindAsync(entityId, trackChange);
            return result;
        }
        public async Task<IEnumerable<T>> FindAllAsync(bool trackChange = false)
        {
            var result = trackChange ? await _context.Set<T>().ToListAsync()
                                     : await _context.Set<T>().AsNoTracking().ToListAsync();
            return result;
        }
        public async Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression, bool trackChange = false)
        {
            var result = trackChange ? await _context.Set<T>().Where(expression).ToListAsync() 
                                     : await _context.Set<T>().AsNoTracking().Where(expression).ToListAsync();
            return result;
        }
        public async Task<T?> FindFirstByConditionAsync(Expression<Func<T, bool>> expression, bool trackChange = false)
        {
            var result = trackChange ? await _context.Set<T>().Where(expression).FirstOrDefaultAsync()
                                     : await _context.Set<T>().AsNoTracking().Where(expression).FirstOrDefaultAsync();
            return result;
        }
    }
}
