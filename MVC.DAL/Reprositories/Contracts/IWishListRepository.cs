
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.DAL.Reprositories.Contracts;

public interface IWishListRepository:IGenericRepositoryForWishlist<WishList>

{
    Task<WishList?> GetByUserAndProductAsync(string userId, int productId);

}
