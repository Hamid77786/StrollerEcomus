

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class IconRepository : EfCoreRepository<Icon>, IIconRepository
{
    public IconRepository(AppDbContext context) : base(context)
    {

    }
}






