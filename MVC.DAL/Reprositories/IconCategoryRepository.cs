

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class IconCategoryRepository : EfCoreRepository<IconCategory>, IIconCategoryRepository
{
    public IconCategoryRepository(AppDbContext context) : base(context)
    {

    }
}






