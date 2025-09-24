

using System.ComponentModel.DataAnnotations.Schema;

namespace StrollerEcomus.DAL.DataContext.Entities;

public class OrderItem: Entity
{
    public string ProductName { get; set; } = null!;
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    
    public decimal TotalPrice { get; set; }
    
    public int TotalItem => Quantity;
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int OrderId { get; set; }
    public Order? Order { get; set; }
    
}




