

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class CurrencyRepository : EfCoreRepository<Currency>, ICurrencyRepository
{
    public CurrencyRepository(AppDbContext context) : base(context)
    {

    }
}






