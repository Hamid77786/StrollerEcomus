

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class ColorRepository : EfCoreRepository<Color>, IColorRepository
{
    public ColorRepository(AppDbContext context) : base(context)
    {

    }
}






