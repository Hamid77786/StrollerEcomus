

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
    public string IconImgUrl { get; set; } = null!;
    public IEnumerable<SelectListItem>? IconCategoryId { get; set; }

}
public class UpdateIconViewModel
{
    public int Id { get; set; }
    public string IconName { get; set; } = null!;
    public string IconImgUrl { get; set; } = null!;
    public IEnumerable<SelectListItem>? IconCategoryId { get; set; }


}

    
