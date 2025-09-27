

using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.Services.Contracts
{
    public interface ICurrencyService : ICrudService<Currency, CurrencyViewModel, CreateCurrencyViewModel, UpdateCurrencyViewModel>
    {

    }



}
