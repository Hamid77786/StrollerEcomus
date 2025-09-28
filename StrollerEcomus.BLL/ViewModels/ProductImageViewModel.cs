

using Microsoft.AspNetCore.Http;
using StrollerEcomus.DAL.DataContext.Entities;
using System.Web.Mvc;

namespace StrollerEcomus.BLL.ViewModels;

public class ProductImageViewModel
{
    public int Id { get; set; }
    public string? ImageUrl { get; set; }
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
}

public class CreateProductImageViewModel
{
    public IFormFile ImageFile { get; set; } = null!;
    public int ProductId { get; set; }
    public IEnumerable<SelectListItem>? Products { get; set; }

}
    

public class UpdateProductImageViewModel
{
   
    public int Id { get; set; }
    public string? ExistingImageUrl { get; set; }
    public IFormFile? NewImageFile { get; set; }
    public int ProductId { get; set; }
    public IEnumerable<SelectListItem>? Products { get; set; }

}






