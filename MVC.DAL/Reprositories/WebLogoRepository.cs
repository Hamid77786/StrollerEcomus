

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class WebLogoRepository : EfCoreRepository<WebLogo>, IWebLogoRepository
{
    public WebLogoRepository(AppDbContext context) : base(context)
    {

    }
}






