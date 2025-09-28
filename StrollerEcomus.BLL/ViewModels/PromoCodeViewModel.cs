


using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.ViewModels;
public class PromoCodeViewModel
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public int Percentage { get; set; }
    public DateTime? ExpiresAt { get; set; }
    public int? MaxUses { get; set; }
    public int Uses { get; set; }
    public bool Active { get; set; }
    public bool OneTimePerUser { get; set; }
    public int CurrentUses => Uses;

}

public class CreatePromoCodeViewModel
{
    public string Code { get; set; } = null!;
    public int Percentage { get; set; }
    public DateTime? ExpiresAt { get; set; }
    public int? MaxUses { get; set; }
    public bool Active { get; set; } = true;
    public bool OneTimePerUser { get; set; } = false;
}

public class UpdatePromoCodeViewModel
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public int Percentage { get; set; }
    public DateTime? ExpiresAt { get; set; }
    public int? MaxUses { get; set; }
    public bool Active { get; set; }
    public bool OneTimePerUser { get; set; }
}








