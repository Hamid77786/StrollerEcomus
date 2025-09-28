

using Microsoft.AspNetCore.Http;
using StrollerEcomus.DAL.DataContext.Entities;
using System.Web.Mvc;

namespace StrollerEcomus.BLL.ViewModels;

public class ProductViewModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
    public string? ProdDescription { get; set; }
    public decimal Price { get; set; }
    public string? CoverImageUrl { get; set; }
    public int StockCount { get; set; }
    public bool IsActive { get; set; }
    public ProductOption ProductOption { get; set; }

    public string? CategoryName { get; set; }

    public ICollection<string> Colors { get; set; } = [];
    public ICollection<string> Images { get; set; } = [];
}

public class CreateProductViewModel
{
    public string Name { get; set; } = null!;
    public string? ProdDescription { get; set; }
    public decimal Price { get; set; }
    public string CoverImageUrl { get; set; } = null!;
    public int StockCount { get; set; }
    public bool IsActive { get; set; } = true;
    public ProductOption ProductOption { get; set; }
    public int CategoryId { get; set; }
    public IEnumerable<SelectListItem>? Categories { get; set; }
    public IEnumerable<int> SelectedColorIds { get; set; } = [];
    public IEnumerable<SelectListItem>? Colors { get; set; }
    public List<IFormFile>? Images { get; set; }

}
public class UpdateProductViewModel
{
   
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string? ProdDescription { get; set; }
        public decimal Price { get; set; }
        public string? CoverImageUrl { get; set; }
        public int StockCount { get; set; }
        public bool IsActive { get; set; }
        public ProductOption ProductOption { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem>? Categories { get; set; }
        public IEnumerable<int> SelectedColorIds { get; set; } = new List<int>();
        public IEnumerable<SelectListItem>? Colors { get; set; }
        public List<IFormFile>? NewImages { get; set; }
        public List<string>? ExistingImages { get; set; } 
    
}




















