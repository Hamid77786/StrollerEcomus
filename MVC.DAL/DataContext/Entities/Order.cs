namespace StrollerEcomus.DAL.DataContext.Entities;

public class Order: TimeStample
{
    
    public OrderStatus OrderStatus { get; set; } = OrderStatus.New;
    public decimal SubTotal { get; set; }// без скидки
    public decimal DisCount { get; set; }// сумма сос скидкой
    public decimal Total { get; set; } // итог со скидкой
    public string? CustomerFirstName { get; set; } = null!;
    public string? CustomerLastName { get; set; } = null!;
    public string? CustomerCountry { get; set; } = null!;
    public string? CustomerCity { get; set; } = null!;
    public string? CustomerShipAddress { get; set; }
    public string? CustomerEmail { get; set; } = null!;
    public string? CustomerPhone { get; set; }=null!;
    public string? OrderNote { get; set; }
    public string? AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; } = [];

}
public enum OrderStatus
{
    Pending,
    Processing,
    Completed,
    Cancelled,
    New
}

