using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class SiteBannerManager : CrudManager<SiteBanner, SiteBannerViewModel, CreateSiteBannerViewModel, UpdateSiteBannerViewModel>, ISiteBannerService
{
    public SiteBannerManager(IRepository<SiteBanner> repository, IMapper mapper) : base(repository, mapper)
    {

    }
}
