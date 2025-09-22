

namespace StrollerEcomus.DAL.DataContext.Entities;

public class ProductImage:Entity
{
    public string? ImageUrl { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
}
