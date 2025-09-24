

namespace StrollerEcomus.DAL.DataContext.Entities;

public class IconCategory:Entity
{
    public string? CategoryName { get; set; }
    public ICollection<Icon> Icons { get; set; } = [];
}
