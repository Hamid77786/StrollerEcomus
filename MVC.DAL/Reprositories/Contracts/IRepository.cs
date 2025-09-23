using Microsoft.EntityFrameworkCore.Query;
using StrollerEcomus.DAL.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.DAL.Reprositories.Contracts
{
    public interface IRepository<T> where T :Entity
    {
        Task<T?> GetByIdAsync(int id);

        Task<T?> GetAsync(Expression<Func<T,bool>> predicate,
            Func<IQueryable<T>,IIncludableQueryable<T,object>>? include=null,
            bool AsNoTracking = false);

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool AsNoTracking = false);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

    }
}
