

using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.Services.Contracts
{
    public interface IReviewService : ICrudService<Review, ReviewViewModel, CreateReviewViewModel, UpdateReviewViewModel>
    {

    }



}
