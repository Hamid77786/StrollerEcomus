using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class CurrencyManager : CrudManager<Currency, CurrencyViewModel, CreateCurrencyViewModel, UpdateCurrencyViewModel>, ICurrencyService
{
    public CurrencyManager(IRepository<Currency> repository, IMapper mapper) : base(repository, mapper)
    {



    }
}
