

using StrollerEcomus.DAL.DataContext.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrollerEcomus.BLL.ViewModels;

public class OrderItemViewModel
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }

}
   

    

public class CreateOrderItemViewModel
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

public class UpdateOrderItemViewModel
{
    public int Id { get; set; }       
    public int ProductId { get; set; } 
    public int Quantity { get; set; } 
}


