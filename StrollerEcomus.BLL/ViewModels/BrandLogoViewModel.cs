using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.ViewModels
{
    public class BrandLogoViewModel
    {
        public int Id { get; set; }
        public string? BrandName { get; set; }
        public string? BrandImageUrl { get; set; }
    }

    public class CreateBrandLogoViewModel
    {
        public string BrandName { get; set; } = null!;
        public string BrandImageUrl { get; set; } = null!;
    }

    public class UpdateBrandLogoViewModel
    {
        public int Id { get; set; }
        public string? BrandName { get; set; }
        public string? BrandImageUrl { get; set; }
    }
}
