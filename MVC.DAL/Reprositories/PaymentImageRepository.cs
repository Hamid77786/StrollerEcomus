

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class PaymentImageRepository : EfCoreRepository<PaymentImage>, IPaymentImageRepository
{
    public PaymentImageRepository(AppDbContext context) : base(context)
    {

    }
}






