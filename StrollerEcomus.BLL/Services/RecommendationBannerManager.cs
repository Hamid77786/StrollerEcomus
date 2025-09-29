using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class RecommendationBannerManager : CrudManager<RecommendationBanner, RecommendationBannerViewModel, CreateRecommendationBannerViewModel, UpdateRecommendationBannerViewModel>, IRecommendationBannerService
{
    public RecommendationBannerManager(IRepository<RecommendationBanner> repository, IMapper mapper) : base(repository, mapper)
    {

    }
}
