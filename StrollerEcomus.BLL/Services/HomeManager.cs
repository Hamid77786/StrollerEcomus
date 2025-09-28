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
        _categoryService = categoryService;
        _siteBannerService = siteBannerService;
        _brandLogoService = brandLogoService;
        _productService = productService;
        _productImageService = productImageService;
        _recommendBannerService = recommendBannerService;
        _frequentlyQuestionService = frequentlyQuestionService;
        _reviewService = reviewService;
    }

    public Task<HomeViewModel> GetHomeViewModel()
    {
        throw new NotImplementedException();
    }
}
