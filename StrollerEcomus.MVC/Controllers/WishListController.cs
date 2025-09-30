using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StrollerEcomus.BLL.Services.Contracts;

namespace StrollerEcomus.MVC.Controllers
{
    //[Authorize] 
    public class WishlistController : Controller
    {
        private readonly IWishListService _wishlistService;
        private readonly UserManager<IdentityUser> _userManager;

        public WishlistController(IWishListService wishlistService, UserManager<IdentityUser> userManager)
        {
            _wishlistService = wishlistService;
            _userManager = userManager;
        }

        private async Task<string> GetUserIdAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            return user!.Id;
        }
       
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User)!;
            var wishList = await _wishlistService.GetUserWishlistAsync(userId);
            return View(wishList);
        }




        [HttpPost]
        public async Task<IActionResult> Add(int productId)
        {
            var userId = await GetUserIdAsync();
            await _wishlistService.AddToWishlistAsync(userId, productId);
            return RedirectToAction("Index");
        }

        
        [HttpPost]
        public async Task<IActionResult> Remove(int productId)
        {
            var userId = _userManager.GetUserId(User)!;
            await _wishlistService.RemoveFromWishlistAsync(userId, productId);
            return RedirectToAction("Index");
        }
    }

}
