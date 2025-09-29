using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class WebInfoManager : CrudManager<WebInfo, WebInfoViewModel, CreateWebInfoViewModel, UpdateWebInfoViewModel>, IWebInfoService
{
    public WebInfoManager(IRepository<WebInfo> repository, IMapper mapper) : base(repository, mapper)
    {

    }
}
