

using Microsoft.AspNetCore.Http;
using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.ViewModels;

public class WebLogoViewModel
{
    public int Id { get; set; }
    public string? WebLogoName { get; set; }
    public string? WebLogoImgUrl { get; set; }
}

public class CreateWebLogoViewModel
{
    public string? WebLogoName { get; set; }
    public IFormFile? WebLogoFile { get; set; }
}

public class UpdateWebLogoViewModel
{
    public int Id { get; set; }
    public string? WebLogoName { get; set; }
    public string? ExistingWebLogoImgUrl { get; set; }
    public IFormFile? NewWebLogoImgUrl { get; set; }
}

