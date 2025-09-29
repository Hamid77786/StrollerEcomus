using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerEcomus.BLL.Services;

public class HomeManager : IHomeService
{
    private readonly ISliderService _sliderService;
    private readonly IIconService _iconService;
    private readonly IIconCategoryService _iconCategoryService;
    private readonly IColorService _colorService;
    private readonly ICategoryService _categoryService;
    private readonly ISiteBannerService _siteBannerService;
    private readonly IBrandLogoService _brandLogoService;
    private readonly IProductService _productService;
    private readonly IProductImageService _productImageService;
    private readonly IRecommendationBannerService _recommendBannerService;
    private readonly IFrequentlyQuestionService _frequentlyQuestionService;
    private readonly IReviewService _reviewService;

    public HomeManager
                        (ISliderService sliderService, 
                        IIconService iconService, 
                        IIconCategoryService iconCategoryService,
                        IColorService colorService,
                        ICategoryService categoryService, 
                        ISiteBannerService siteBannerService, 
                        IBrandLogoService brandLogoService, 
                        IProductService productService, 
                        IProductImageService productImageService, 
                        IRecommendationBannerService recommendBannerService, 
                        IFrequentlyQuestionService frequentlyQuestionService, 
                        IReviewService reviewService)
    {
        _sliderService = sliderService;
        _iconService = iconService;
        _iconCategoryService = iconCategoryService;
        _colorService = colorService;
        _categoryService = categoryService;
        _siteBannerService = siteBannerService;
        _brandLogoService = brandLogoService;
        _productService = productService;
        _productImageService = productImageService;
        _recommendBannerService = recommendBannerService;
        _frequentlyQuestionService = frequentlyQuestionService;
        _reviewService = reviewService;
    }

    public async Task<HomeViewModel> GetHomeViewModel()
    {
        var sliders = await _sliderService.GetAllAsync();
        var icons = await _iconService.GetAllAsync();
        var iconCategories = await _iconCategoryService.GetAllAsync();
        var colors = await _colorService.GetAllAsync();
        var categories = await _categoryService.GetAllAsync();
        var siteBanners = await _siteBannerService.GetAllAsync();
        var barndLogos = await _brandLogoService.GetAllAsync();
        var products = await _productService.GetAllAsync();
        var productImage = await _productImageService.GetAllAsync();
        var recommendationBanners = await _recommendBannerService.GetAllAsync();
        var frequentlyQuestions = await _frequentlyQuestionService.GetAllAsync();
        var reviews = await _reviewService.GetAllAsync();
        
        
        
        
        var homeViewModel = new HomeViewModel
        {
            Sliders=sliders.ToList(),
            Icons=icons.ToList(),
            IconsCategories=iconCategories.ToList(),
            Colors=colors.ToList(),
            Categories=categories.ToList(),
            SiteBanners=siteBanners.ToList(),
            Products=products.ToList(),
            ProductImages=productImage.ToList(),
            RecommendationBanners=recommendationBanners.ToList(),
            FrequentlyQuestions=frequentlyQuestions.ToList(),
            Reviews=reviews.ToList(),
        };
        return homeViewModel;
    }
}
