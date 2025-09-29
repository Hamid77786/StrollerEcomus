using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class PromoUsageManager : CrudManager<PromoUsage, PromoUsageViewModel, CreatePromoUsageViewModel, UpdatePromoUsageViewModel>, IPromoUsageService
{
    public PromoUsageManager(IRepository<PromoUsage> repository, IMapper mapper) : base(repository, mapper)
    {

    }
}
