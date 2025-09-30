

using Microsoft.AspNetCore.Identity;

namespace StrollerEcomus.DAL.DataContext.Entities;

public class WishList:Entity
{
    public string UserId { get; set; } = null!;
    public int ProductId { get; set; }
    public DateTime CreatedDate { get; set; }= DateTime.UtcNow;  
    
    public Product Product { get; set; } = null!;
    public AppUser User { get; set; } = null!;
}
