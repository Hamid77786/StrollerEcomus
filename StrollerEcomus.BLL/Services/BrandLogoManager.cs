using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class BrandLogoManager : CrudManager<BrandLogo, BrandLogoViewModel, CreateBrandLogoViewModel, UpdateBrandLogoViewModel>, IBrandLogoService
{
    public BrandLogoManager(IRepository<BrandLogo> repository, IMapper mapper) : base(repository, mapper)
    {

    }
}
