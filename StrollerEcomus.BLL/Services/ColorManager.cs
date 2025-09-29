using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class ColorManager : CrudManager<Color, ColorViewModel, CreateColorViewModel, UpdateColorViewModel>, IColorService
{
    public ColorManager(IRepository<Color> repository, IMapper mapper) : base(repository, mapper)
    {



    }
}
