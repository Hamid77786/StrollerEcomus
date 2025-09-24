

namespace StrollerEcomus.DAL.DataContext.Entities;

public class ProductColor:Entity
{
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;

    public int ColorId { get; set; }
    public Color Color { get; set; } = null!;
}
