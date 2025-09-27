

using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.Services.Contracts
{
    public interface IBrandLogoService:ICrudService<BrandLogo,BrandLogoViewModel,CreateBrandLogoViewModel,UpdateBrandLogoViewModel>
    {
    }

}


