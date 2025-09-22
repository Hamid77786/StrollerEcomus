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
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public List<ProductImage> ProductImages { get; set; } = [];


}

public enum ProductOption
{
    None,
    Color,
    Size

}
