

namespace StrollerEcomus.DAL.DataContext.Entities;

public class PromoCode:Entity
{
    public string Code { get; set; } = null!;
    public int Percentage { get; set; }
    public DateTime? ExpiresAt { get; set; }
    public int? MaxUses { get; set; }
    public int Uses { get; set; } = 0;
    public bool Active { get; set; } = true;
    public bool OneTimePerUser { get; set; } = false;
    public List<PromoUsage>? PromoUsages { get; set; }


}
