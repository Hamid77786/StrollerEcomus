using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class OrderItemManager : CrudManager<OrderItem, OrderItemViewModel, CreateOrderItemViewModel, UpdateOrderItemViewModel>, IOrderItemService
{
    public OrderItemManager(IRepository<OrderItem> repository, IMapper mapper) : base(repository, mapper)
    {



    }
}
