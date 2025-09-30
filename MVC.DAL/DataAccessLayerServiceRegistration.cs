

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StrollerEcomus.BLL.Services.Contracts;
using StrollerEcomus.DAL.DataContext;
using StrollerEcomus.DAL.Reprositories;
using StrollerEcomus.DAL.Reprositories.Contracts;

namespace StrollerEcomus.DAL;

public static class DataAccessLayerServiceRegistration
{
    public static IServiceCollection AddDataAccessLayerServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
           options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), options =>
           {
               options.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
           }));

        services.AddScoped<DataInitializer>();

        services.AddScoped(typeof(IRepository<>), typeof(EfCoreRepository<>));
        services.AddScoped<IBrandLogoRepository, BrandLogoRepository>();
        services.AddScoped<IColorRepository, ColorRepository>();
        services.AddScoped<ICurrencyRepository, CurrencyRepository>();
        services.AddScoped<FrequentlyQuestionRepository, FrequentlyQuestionRepository>();
        services.AddScoped<IIconCategoryRepository, IconCategoryRepository>();
        services.AddScoped<IIconRepository, IconRepository>();
        services.AddScoped<ILanguageRepository, LanguageRepository>();
        services.AddScoped<ILogInContentRepository,LogInContentRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();
        services.AddScoped<IOrderItemRepository, OrderItemRepository>();
        services.AddScoped<IPaymentImageRepository,PaymentImageRepository>();
        services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();    
        services.AddScoped<IProductImageRepository, ProductImageRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IPromoCodeRepository, PromoCodeRepository>();
        services.AddScoped<IPromoUsageRepository, PromoUsageRepository>();
        services.AddScoped<IRecommendationBannerRepository, RecommendationBannerRepository>();
        services.AddScoped<IReviewRepository,ReviewRepository>();
        services.AddScoped<ISiteBannerRepository, SiteBannerRepository>();
        services.AddScoped<ISliderRepository, SliderRepository>();
        services.AddScoped<ISocialRepository, SocialRepository>();
        services.AddScoped<IWebInfoRepository, WebInfoRepository>();
        services.AddScoped<IWebLogoRepository, WebLogoRepository>();
        services.AddScoped<IWishListRepository, WishListRepository>();
        services.AddScoped(typeof(IGenericRepositoryForWishlist<>), typeof(GenericReprositoryForWishlist<>));



        return services;
    }

}
