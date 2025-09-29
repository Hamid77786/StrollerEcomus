using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class PromoCodeManager : CrudManager<PromoCode, PromoCodeViewModel, CreatePromoCodeViewModel, UpdatePromoCodeViewModel>, IPromoCodeService
{
    public PromoCodeManager(IRepository<PromoCode> repository, IMapper mapper) : base(repository, mapper)
    {

    }
}
