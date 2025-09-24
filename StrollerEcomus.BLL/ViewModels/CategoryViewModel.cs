using StrollerEcomus.DAL.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public ICollection<Product> Products { get; set; } = [];


    }

    public class CreateCategoryViewModel
    {
        public string CategoryName { get; set; } = null!;
    }

    public class UpdateCategoryViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        public IEnumerable<Product> Products { get; set; } = [];

    }
}



