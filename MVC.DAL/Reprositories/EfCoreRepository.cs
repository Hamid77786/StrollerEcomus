using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.DAL.Reprositories
{
    public class EfCoreRepository<T>:IRepository<T> where T : Entity
    {
        protected readonly AppDbContext DbContext;

        public EfCoreRepository(AppDbContext context)
        {
            DbContext = context;
        }

        public virtual async Task CreateAsync(T entity)
        {
            await DbContext.Set<T>().AddAsync(entity);
            await DbContext.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            await DbContext.SaveChangesAsync();
        }

        public virtual async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, bool AsNoTracking = false)
        {
            IQueryable<T> query = DbContext.Set<T>();
            if (AsNoTracking)
                query = query.AsNoTracking();

            if (include != null)
                query = include(query);

            if (predicate != null)
                query = query.Where(predicate);

            if (orderBy != null)
                query = orderBy(query);

            return await query.ToListAsync();
        }

        public virtual async Task<T?> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool AsNoTracking = false)
        {
            IQueryable<T> query = DbContext.Set<T>();
            if (AsNoTracking)
                query = query.AsNoTracking();

            if (include != null)
                query = include(query);

            return await query.FirstOrDefaultAsync(predicate);
        }

        public virtual async Task<T?> GetByIdAsync(int id)
        {
            return await DbContext.Set<T>().FindAsync(id);
        }

        public virtual async Task UpdateAsync(T entity)
        {
            DbContext.Set<T>().Update(entity);
            await DbContext.SaveChangesAsync();
        }
    }
}
