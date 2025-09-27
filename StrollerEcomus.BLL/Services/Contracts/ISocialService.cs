

using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.Services.Contracts
{
    public interface ISocialService : ICrudService<Social, SocialViewModel, CreateSocialViewModel, UpdateSocialViewModel>
    {

    }



}
