using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.ViewModels;

public class OrderViewModel
{
        public int Id { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal SubTotal { get; set; }   // до скидки
        public decimal DisСount { get; set; }   // сумма скидки
        public decimal Total { get; set; }      // после скидки
        public string? CustomerFirstName { get; set; }
        public string? CustomerLastName { get; set; }
        public string? CustomerCountry { get; set; }
        public string? CustomerCity { get; set; }
        public string? CustomerShipAddress { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }
        public string? OrderNote { get; set; }
        public string? AppUserId { get; set; }
        public string? AppUserName { get; set; }
        public ICollection<OrderItemViewModel> OrderItems { get; set; } = [];
    
}
public class CreateOrderViewModel
{
    
    public string CustomerFirstName { get; set; } = null!;
    public string CustomerLastName { get; set; } = null!;
    public string CustomerCountry { get; set; } = null!;
    public string CustomerCity { get; set; } = null!;
    public string? CustomerShipAddress { get; set; }
    public string CustomerEmail { get; set; } = null!;
    public string CustomerPhone { get; set; } = null!;
    public string? OrderNote { get; set; }
    public ICollection<CreateOrderItemViewModel> OrderItems { get; set; } = [];

    
}
public class UpdateOrderViewModel
{
    public int Id { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public string? CustomerFirstName { get; set; }
    public string? CustomerLastName { get; set; }
    public string? CustomerCountry { get; set; }
    public string? CustomerCity { get; set; }
    public string? CustomerShipAddress { get; set; }
    public string? CustomerEmail { get; set; }
    public string? CustomerPhone { get; set; }
    public string? OrderNote { get; set; }
    public ICollection<UpdateOrderItemViewModel> OrderItems { get; set; } = [];

}
   
        
       
    












