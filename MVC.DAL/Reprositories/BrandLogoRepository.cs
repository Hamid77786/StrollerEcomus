

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class BrandLogoRepository : EfCoreRepository<BrandLogo>, IBrandLogoRepository
{
    public BrandLogoRepository(AppDbContext context) : base(context)
    {

    }
}






