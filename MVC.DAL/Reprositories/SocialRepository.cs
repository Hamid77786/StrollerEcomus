

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class SocialRepository : EfCoreRepository<Social>, ISocialRepository
{
    public SocialRepository(AppDbContext context) : base(context)
    {

    }
}






