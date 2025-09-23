namespace StrollerEcomus.DAL.DataContext.Entities;

public class Product :TimeStample
{
    public string Name { get; set; } = null!;
    public string? ProdDescription { get; set; }
    public decimal Price { get; set; }
    public string? CoverImageUrl { get; set; }
    public int StockCount { get; set; }
    public bool IsActive { get; set; } = true;
    public ProductOption ProductOption { get; set; }
    public int ProductCategoryId { get; set; }
    public ProductCategory? ProductCategory { get; set; }
    public int ColorId { get; set; }
    public Color? Color { get; set; }
    public List<ProductImage> ProductImages { get; set; } = [];


}

public enum ProductOption
{
    Shipped,
    Pending,
    Canceled,
    Payed


}
    
    

