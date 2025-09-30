using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.Services;

public class ShopManager:IShopService
{
    private readonly IProductService _productService;
    private readonly IProductImageService _productImageService;
    private readonly IIconCategoryService _iconCategoryService;
    private readonly IIconService _iconService;
    private readonly IColorService _colorService;

    public ShopManager( IProductService productService, 
                        IProductImageService productImageService, 
                        IIconCategoryService iconCategoryService, 
                        IIconService iconService, 
                        IColorService colorService)
    {
        _productService = productService;
        _productImageService = productImageService;
        _iconCategoryService = iconCategoryService;
        _iconService = iconService;
        _colorService = colorService;
    }

    public async Task<ShopViewModel> GetShopViewModel()
    {
        var products = await _productService.GetAllAsync();
        var productImages = await _productImageService.GetAllAsync();
        var iconCategories = await _iconCategoryService.GetAllAsync();
        var icons = await _iconService.GetAllAsync();
        var colors = await _colorService.GetAllAsync();




        var shopViewModel = new ShopViewModel
        {
            Products = products.ToList(),
            ProductImages= productImages.ToList(),
            IconCategories= iconCategories.ToList(),
            Icons = icons.ToList(),
            Colors = colors.ToList(),
            
            

        };
        return shopViewModel;
    }
}
