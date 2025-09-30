using Microsoft.AspNetCore.Mvc;
using StrollerEcomus.BLL.Services.Contracts;

namespace StrollerEcomus.MVC.Controllers
{
    public class ShopController : Controller
    {
        private readonly IShopService _shopService;

        public ShopController(IShopService shopService)
        {
            _shopService = shopService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _shopService.GetShopViewModel();
            
            return View(model);
        }
    }
}
