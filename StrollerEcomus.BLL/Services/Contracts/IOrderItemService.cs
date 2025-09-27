

using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.Services.Contracts
{
    public interface IOrderItemService : ICrudService<OrderItem, OrderItemViewModel, CreateOrderItemViewModel, UpdateOrderItemViewModel>
    {

    }



}
