

namespace StrollerEcomus.DAL.DataContext.Entities;

public class PromoUsage:Entity
{
    public int PromoCodeId { get; set; }
    public PromoCode? PromoCode { get; set; }
    public string? AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public DateTime UsedAt { get; set; }
}
