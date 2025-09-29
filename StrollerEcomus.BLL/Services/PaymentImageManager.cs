using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class PaymentImageManager : CrudManager<PaymentImage, PaymentImageViewModel, CreatePaymentImageViewModel, UpdatePaymentImageViewModel>, IPaymentImageService
{
    public PaymentImageManager(IRepository<PaymentImage> repository, IMapper mapper) : base(repository, mapper)
    {



    }
}
