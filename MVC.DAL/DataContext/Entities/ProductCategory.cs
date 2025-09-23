namespace StrollerEcomus.DAL.DataContext.Entities;

public class ProductCategory : TimeStample
{
    public string CategoryName { get; set; } = null!;
    public string? CategoryImageUrl { get; set; }
    public List<Product> Products { get; set; } = [];


}
