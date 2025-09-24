

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class ProductCategoryRepository : EfCoreRepository<Category>, IProductCategoryRepository
{
    public ProductCategoryRepository(AppDbContext context):base(context)
    {
        
    }
}






