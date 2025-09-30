using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories;
using StrollerEcomus.DAL.Reprositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.Services;


public class WishListManager : IWishListService
{
    private readonly IWishListRepository _wishListRepository;

    public WishListManager(IWishListRepository wishListRepository)
    {
        _wishListRepository = wishListRepository;
    }

    public async Task AddToWishlistAsync(string userId, int productId)
    {
        var existing = await _wishListRepository.GetByUserAndProductAsync(userId, productId);

        if (existing == null)
        {
            var entity = new WishList
            {
                UserId = userId,
                ProductId = productId
            };

            await _wishListRepository.CreateAsync(entity);
        }
    }

    public async Task<IEnumerable<WishListViewModel>> GetUserWishlistAsync(string userId)
    {
        var wishlist = await _wishListRepository
         .GetAllAsync(w => w.UserId == userId, includeProperties: "Product");

        return wishlist.Select(w => new WishListViewModel
        {
            ProductId = w.Product.Id,
            Name = w.Product.Name,
            CoverImageUrl = w.Product.CoverImageUrl!,
            Price = w.Product.Price,
            CreatedDate = w.CreatedDate
        });
            
    }

    public async Task RemoveFromWishlistAsync(string userId, int productId)
    {
        var existing = await _wishListRepository.GetByUserAndProductAsync(userId, productId);

        if (existing != null)
        {
            await _wishListRepository.DeleteAsync(existing);
        }
    }

   
}
