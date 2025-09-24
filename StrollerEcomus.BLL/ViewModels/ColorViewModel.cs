

using StrollerEcomus.DAL.DataContext.Entities;
using System.Web.Mvc;

namespace StrollerEcomus.BLL.ViewModels;

public class ColorViewModel
{
    
    public string? ColorName { get; set; }
    public string? ColorImageUrl { get; set; }
    public string? ColorCode { get; set; }
    public ICollection<int> ProductId { get; set; } = [];
    public ICollection<string> ProductNames { get; set; } = [];
    
}

public class CreateColorViewModel
{
    public int Id { get; set; }
    public string? ColorName { get; set; }
    public string? ColorImageUrl { get; set; }
    public string? ColorCode { get; set; }
    public IEnumerable<int> ProductId { get; set; } = [];
    public IEnumerable<SelectListItem>? Products { get; set; }
}

public class UpdateColorViewModel
{
    public int Id { get; set; }
    public string? ColorName { get; set; }
    public string? ColorImageUrl { get; set; }
    public string? ColorCode { get; set; }
    public IEnumerable<int> ProductId { get; set; } = [];
    public IEnumerable<SelectListItem>? Products { get; set; }

}
