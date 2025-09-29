using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class IconManager : CrudManager<Icon, IconViewModel, CreateIconViewModel, UpdateIconViewModel>, IIconService
{
    public IconManager(IRepository<Icon> repository, IMapper mapper) : base(repository, mapper)
    {



    }
}
