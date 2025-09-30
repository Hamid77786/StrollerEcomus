

using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.Reprositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace StrollerEcomus.DAL.Reprositories;

public class WishListRepository : GenericReprositoryForWishlist<WishList>, IWishListRepository
{
    private readonly AppDbContext _dbContext;

    public WishListRepository(AppDbContext context) : base(context)
    {
        _dbContext = context;
    }

    public async Task<WishList?> GetByUserAndProductAsync(string userId, int productId)
    {
        return await _dbContext.WishLists
            .Include(w => w.Product)
            .FirstOrDefaultAsync(w => w.UserId == userId && w.ProductId == productId);
    }
}

