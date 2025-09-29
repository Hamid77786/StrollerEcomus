

using Microsoft.Extensions.DependencyInjection;
using StrollerEcomus.BLL.Mapping;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.BLL.Services;

namespace StrollerEcomus.BLL;

public static class BussinessLogicLayerServiceRegistration
{
    public static IServiceCollection AddBussinessLogicLayerServices(this IServiceCollection services)
    {
        services.AddAutoMapper(confg => confg.AddProfile<MappingProfile>());
        services.AddScoped(typeof(ICrudService<,,,>), typeof(CrudManager<,,,>));
        services.AddScoped<IHeaderService, HeaderManager>();
        services.AddScoped<IFooterService, FooterManager>();
        services.AddScoped<IHomeService, HomeManager>();
        services.AddScoped<IShopService, ShopManager>();
        services.AddScoped<IWebLogoService, WebLogoManager>();
        services.AddScoped<IWebInfoService, WebInfoManager>();
        services.AddScoped<IIconCategoryService, IconCategoryManager>();
        services.AddScoped<IIconService, IconManager>();
        services.AddScoped<ISocialService, SocialManager>();
        services.AddScoped<ISliderService, SliderManager>();
        services.AddScoped<ISiteBannerService, SiteBannerManager>();
        services.AddScoped<IReviewService, ReviewManager>();
        services.AddScoped<IRecommendationBannerService, RecommendationBannerManager>();
        services.AddScoped<IPromoUsageService, PromoUsageManager>();
        services.AddScoped<IPromoCodeService,PromoCodeManager>();
        services.AddScoped<IProductService,ProductManager>();
        services.AddScoped<IProductImageService, ProductImageManager>();
        services.AddScoped<IPaymentImageService,PaymentImageManager>();
        services.AddScoped<IOrderService, OrderManager>();
        services.AddScoped<IOrderItemService, OrderItemManager>();
        services.AddScoped<ILogInContentService, LogInContentManager>();
        services.AddScoped<ILanguageService, LanguageManager>();
        services.AddScoped<IColorService, ColorManager>();
        services.AddScoped<IBrandLogoService, BrandLogoManager>();
        services.AddScoped<ICurrencyService, CurrencyManager>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<IFrequentlyQuestionService, FrequentlyQuestionManager>();

        return services;
    }
}
