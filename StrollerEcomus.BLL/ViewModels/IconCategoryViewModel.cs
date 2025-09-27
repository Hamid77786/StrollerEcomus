

using StrollerEcomus.DAL.DataContext.Entities;
using System.Web.Mvc;

namespace StrollerEcomus.BLL.ViewModels;

public class IconCategoryViewModel
{
    public int Id { get; set; }
    public string? CategoryName { get; set; }
}

public class CreateIconCategoryViewModel
{
    public string CategoryName { get; set; } = null!;
}

public class UpdateIconCategoryViewModel
{
    public int Id { get; set; }
    public string? CategoryName { get; set; }
    public IEnumerable<SelectListItem>? Icons { get; set; }

}
