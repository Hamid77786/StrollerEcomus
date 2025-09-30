using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.ViewModels
{
    public class WishListViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public string CoverImageUrl{ get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class CreateWishListViewModel
    {

    }
    public class UpdateWishListViewModel
    {

    }
}