using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class OrderManager : CrudManager<Order, OrderViewModel, CreateOrderViewModel, UpdateOrderViewModel>, IOrderService
{
    public OrderManager(IRepository<Order> repository, IMapper mapper) : base(repository, mapper)
    {



    }
}
