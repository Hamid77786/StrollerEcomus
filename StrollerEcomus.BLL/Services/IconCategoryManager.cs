using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class IconCategoryManager : CrudManager<IconCategory, IconCategoryViewModel, CreateIconCategoryViewModel, UpdateIconCategoryViewModel>, IIconCategoryService
{
    public IconCategoryManager(IRepository<IconCategory> repository, IMapper mapper) : base(repository, mapper)
    {



    }
}
