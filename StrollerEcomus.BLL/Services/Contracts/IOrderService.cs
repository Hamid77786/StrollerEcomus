

using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.Services.Contracts
{
    public interface IOrderService : ICrudService<Order, OrderViewModel, CreateOrderViewModel, UpdateOrderViewModel>
    {

    }



}
