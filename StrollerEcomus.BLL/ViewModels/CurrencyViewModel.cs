

namespace StrollerEcomus.BLL.ViewModels;

public class CurrencyViewModel
{
    public int Id { get; set; }
    public string? CurrencyImageUrl { get; set; }
    public string? CurrencyName { get; set; }
}

public class CreateCurrencyViewModel
{
    public string CurrencyImageUrl { get; set; } = null!;
    public string CurrencyName { get; set; } = null!;
}

public class UpdateCurrencyViewModel
{
    public int Id { get; set; }
    public string? CurrencyImageUrl { get; set; }
    public string? CurrencyName { get; set; }
}
