

using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.Services.Contracts
{
    public interface IProductImageService : ICrudService<ProductImage, ProductImageViewModel, CreateProductImageViewModel, UpdateProductImageViewModel>
    {

    }



}
