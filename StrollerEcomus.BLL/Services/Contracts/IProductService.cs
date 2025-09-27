

using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;

namespace StrollerEcomus.BLL.Services.Contracts
{
    public interface IProductService : ICrudService<Product, ProductViewModel, CreateProductViewModel, UpdateProductViewModel>
    {

    }



}
