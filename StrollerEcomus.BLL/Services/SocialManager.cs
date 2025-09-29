using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class SocialManager : CrudManager<Social, SocialViewModel, CreateSocialViewModel, UpdateSocialViewModel>, ISocialService
{
    public SocialManager(IRepository<Social> repository, IMapper mapper) : base(repository, mapper)
    {

    }
}
