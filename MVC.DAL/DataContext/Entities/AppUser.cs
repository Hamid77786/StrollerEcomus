using Microsoft.AspNet.Identity.EntityFramework;

namespace StrollerEcomus.DAL.DataContext.Entities;

public class AppUser:IdentityUser
{
    public string? FullName { get; set; }

    public string? Address { get; set; }
   
    public string? ProfileImageUrl { get; set; }

}
