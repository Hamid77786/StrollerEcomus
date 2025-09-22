

namespace StrollerEcomus.DAL.DataContext.Entities;

public class Currency:Entity
{
    public string CurrencyImageUrl { get; set; } = null!;
    public string CurrencyName { get; set; }= null!;
}
