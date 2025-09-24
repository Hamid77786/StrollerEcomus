

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class SliderRepository : EfCoreRepository<Slider>, ISliderRepository
{
    public SliderRepository(AppDbContext context) : base(context)
    {

    }
}






