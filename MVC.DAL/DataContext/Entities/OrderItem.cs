

namespace StrollerEcomus.DAL.DataContext.Entities;

public class OrderItem: Entity
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public Product? Product { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice => UnitPrice * Quantity;
    public int TotalItem => Quantity;
    public int OrderId { get; set; }
    public Order? Order { get; set; }
    
}




