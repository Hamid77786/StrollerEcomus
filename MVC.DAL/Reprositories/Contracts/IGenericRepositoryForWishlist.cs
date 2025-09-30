using StrollerEcomus.DAL.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.Services.Contracts
{
    
    public interface IGenericRepositoryForWishlist<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        string? includeProperties = null);

        Task<TEntity?> GetByIdAsync(int id);

        Task CreateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task SaveAsync();
    }
}
