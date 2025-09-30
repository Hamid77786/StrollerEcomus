using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.Services.Contracts;

public interface IWishListService
{
    Task<IEnumerable<WishListViewModel>> GetUserWishlistAsync(string userId);
    Task AddToWishlistAsync(string userId, int productId);
    Task RemoveFromWishlistAsync(string userId, int productId);
}
