

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class ProductImageRepository : EfCoreRepository<ProductImage>, IProductImageRepository
{
    public ProductImageRepository(AppDbContext context) : base(context)
    {

    }
}






