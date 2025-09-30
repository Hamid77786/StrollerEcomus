using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.ViewModels
{
    public class ShopViewModel
    {
        public ICollection<ProductViewModel> Products { get; set; } = [];
        public ICollection<ProductImageViewModel> ProductImages { get; set; } = [];
        public ICollection<IconViewModel> Icons { get; set; } = [];
        public ICollection<IconCategoryViewModel> IconCategories { get; set; } = [];
        public ICollection<ColorViewModel> Colors { get; set; } = [];
    }
}
