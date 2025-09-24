

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class SiteBannerRepository : EfCoreRepository<SiteBanner>, ISiteBannerRepository
{
    public SiteBannerRepository(AppDbContext context) : base(context)
    {

    }
}






