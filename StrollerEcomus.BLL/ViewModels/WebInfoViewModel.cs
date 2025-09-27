

namespace StrollerEcomus.BLL.ViewModels;

public  class WebInfoViewModel
{
    public int Id { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? BurnedInfo { get; set; }
}

public class CreateWebInfoViewModel
{
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? BurnedInfo { get; set; }

}

public class UpdateWebInfoViewModel
{
    public int Id { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? BurnedInfo { get; set; }
}