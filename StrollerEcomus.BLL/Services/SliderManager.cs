using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class SliderManager : CrudManager<Slider, SliderViewModel, CreateSliderViewModel, UpdateSliderViewModel>, ISliderService
{
    public SliderManager(IRepository<Slider> repository, IMapper mapper) : base(repository, mapper)
    {

    }
}
