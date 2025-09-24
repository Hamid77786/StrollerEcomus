

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class PromoUsageRepository : EfCoreRepository<PromoUsage>, IPromoUsageRepository
{
    public PromoUsageRepository(AppDbContext context) : base(context)
    {

    }
}






