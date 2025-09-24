

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class LogInContentRepository : EfCoreRepository<LogInContent>, ILogInContentRepository
{
    public LogInContentRepository(AppDbContext context) : base(context)
    {

    }
}






