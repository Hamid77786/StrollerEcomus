

namespace StrollerEcomus.DAL.DataContext.Entities;

public  class Color:TimeStample
{
    public string? ColorName { get; set; }
    public string? ColorImageUrl { get; set; }
    public string? ColorCode { get; set; }
    public List<Product> Products { get; set; } = [];
}
