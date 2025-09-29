using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class ReviewManager : CrudManager<Review, ReviewViewModel, CreateReviewViewModel, UpdateReviewViewModel>, IReviewService
{
    public ReviewManager(IRepository<Review> repository, IMapper mapper) : base(repository, mapper)
    {

    }
}
