

using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL.Reprositories;

public class ReviewRepository : EfCoreRepository<Review>, IReviewRepository
{
    public ReviewRepository(AppDbContext context) : base(context)
    {

    }
}






