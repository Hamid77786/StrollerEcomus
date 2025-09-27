

using Microsoft.AspNetCore.Http;
using StrollerEcomus.DAL.DataContext.Entities;
using System.Web.Mvc;

namespace StrollerEcomus.BLL.ViewModels;

public class IconViewModel
{
    public int Id { get; set; }
    public string? IconName { get; set; }
    public string? IconImgUrl { get; set; }
    public string? CategoryName { get; set; }

}
public class CreateIconViewModel
{
    public string IconName { get; set; } = null!;
    public IFormFile? IconImageFile { get; set; }
    public int IconCategoryId { get; set; }
    public IEnumerable<SelectListItem>? IconCategories { get; set; }

}
public class UpdateIconViewModel
{
    public int Id { get; set; }
    public string? IconName { get; set; }
    public string? ExistingIconImageUrl { get; set; }
    public IFormFile? NewIconImageFile { get; set; }
    public int IconCategoryId { get; set; }
    public IEnumerable<SelectListItem>? IconCategories { get; set; }

}





    
