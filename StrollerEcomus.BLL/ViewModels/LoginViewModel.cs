

using System.ComponentModel.DataAnnotations;

namespace StrollerEcomus.BLL.ViewModels;

public class LoginViewModel
{
    public required string UserName { get; set; }
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    public string? ReturnUrl { get; set; }

    public bool RememberMe { get; set; }
}
