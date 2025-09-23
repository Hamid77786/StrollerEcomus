

namespace StrollerEcomus.DAL.DataContext.Entities;

public class IconCategory:Entity
{
    public string? Name { get; set; }
    public List<Icon> Icons { get; set; } = [];
}
