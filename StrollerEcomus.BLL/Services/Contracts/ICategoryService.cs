

using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.Services.Contracts
{
    public interface ICategoryService : ICrudService<Category, CategoryViewModel, CreateCategoryViewModel, UpdateCategoryViewModel>
    {
    }



}
