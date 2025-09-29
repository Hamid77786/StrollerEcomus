using AutoMapper;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.BLL.Services;

public class ProductImageManager : CrudManager<ProductImage, ProductImageViewModel, CreateProductImageViewModel, UpdateProductImageViewModel>, IProductImageService
{
    public ProductImageManager(IRepository<ProductImage> repository, IMapper mapper) : base(repository, mapper)
    {



    }
}
