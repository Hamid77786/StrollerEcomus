

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class RecommendationBannerRepository : EfCoreRepository<RecommendationBanner>, IRecommendationBannerRepository
{
    public RecommendationBannerRepository(AppDbContext context) : base(context)
    {

    }
}






