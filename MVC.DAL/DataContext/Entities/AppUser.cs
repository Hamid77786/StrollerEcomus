

using Microsoft.AspNetCore.Identity;

namespace StrollerEcomus.DAL.DataContext.Entities;

public class AppUser:IdentityUser
{
    public string? FullName { get; set; }

    public string? Address { get; set; }
   
    public string? ProfileImageUrl { get; set; }
    public ICollection<WishList> WishLists { get; set; } = [];

}
