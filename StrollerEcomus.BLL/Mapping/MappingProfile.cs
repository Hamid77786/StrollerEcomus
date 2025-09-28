

using AutoMapper;
using StrollerEcomus.BLL.ViewModels;
using StrollerEcomus.DAL.DataContext.Entities;


namespace StrollerEcomus.BLL.Mapping;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<BrandLogo, BrandLogoViewModel>().ReverseMap();
        CreateMap<BrandLogo, CreateBrandLogoViewModel>().ReverseMap(); 
        CreateMap<BrandLogo, UpdateBrandLogoViewModel>().ReverseMap(); 

        CreateMap<Category, CategoryViewModel>().ReverseMap();
        CreateMap<CreateCategoryViewModel, Category>()
            .ForMember(dest => dest.CategoryImageUrl, opt => opt.Ignore());
        CreateMap<UpdateCategoryViewModel, Category>()
           .ForMember(dest => dest.CategoryImageUrl, opt => opt.Ignore());

        CreateMap<Color, ColorViewModel>()
            .ForMember(dest => dest.ProductId,
                opt => opt.MapFrom(src => src.ProductColors.Select(pc => pc.ProductId)))
            .ForMember(dest => dest.ProductNames,
                opt => opt.MapFrom(src => src.ProductColors.Select(pc => pc.Product.Name)));
        CreateMap<CreateColorViewModel, Color>()
             .ForMember(dest => dest.ColorImageUrl, opt => opt.Ignore())
             .ForMember(dest => dest.ProductColors,
                opt => opt.MapFrom(src => src.ProductId.Select(pid =>
                    new ProductColor { ProductId = pid })));

        CreateMap<UpdateColorViewModel, Color>()
            .ForMember(dest => dest.ColorImageUrl, opt => opt.Ignore())
            .ForMember(dest => dest.ProductColors,
                opt => opt.MapFrom(src => src.ProductId.Select(pid =>
                    new ProductColor { ProductId = pid })));


        CreateMap<Currency, CurrencyViewModel>().ReverseMap();
        CreateMap<Currency,CreateCurrencyViewModel>().ReverseMap();
        CreateMap<Currency,UpdateCurrencyViewModel>().ReverseMap();

        CreateMap<FrequentlyQuestion, FrequentlyQuestionViewModel>().ReverseMap();
        CreateMap<FrequentlyQuestion, CreateFrequentlyQuestionViewModel>().ReverseMap();
        CreateMap<FrequentlyQuestion, UpdateFrequentlyQuestionViewModel>().ReverseMap();

        CreateMap<Icon, IconViewModel>()
            .ForMember(dest => dest.CategoryName,
                       opt => opt.MapFrom(src => src.IconCategory != null ? src.IconCategory.CategoryName : null));
        CreateMap<CreateIconViewModel, Icon>()
           .ForMember(dest => dest.IconImgUrl, opt => opt.Ignore()) 
           .ForMember(dest => dest.IconCategory, opt => opt.Ignore());
        CreateMap<UpdateIconViewModel, Icon>()
           .ForMember(dest => dest.IconImgUrl, opt => opt.Ignore()) 
           .ForMember(dest => dest.IconCategory, opt => opt.Ignore());

        CreateMap<IconCategory, IconCategoryViewModel>().ReverseMap();
        CreateMap<CreateIconCategoryViewModel, IconCategory>().ReverseMap();
        CreateMap<UpdateIconCategoryViewModel, IconCategory>()
            .ForMember(dest => dest.Icons, opt => opt.Ignore());

        CreateMap<Language, LanguageViewModel>().ReverseMap();
        CreateMap<CreateLanguageViewModel, Language>().ReverseMap();
        CreateMap<UpdateLanguageViewModel, Language>().ReverseMap();

        CreateMap<LogInContent, LogInContentViewModel>().ReverseMap();
        CreateMap<LogInContent, CreateLogInContentViewModel>().ReverseMap();
        CreateMap<LogInContent, UpdateLogInContentViewModel>().ReverseMap();

        CreateMap<Order, OrderViewModel>()
             .ForMember(dest => dest.AppUserName, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.FullName : null));
        CreateMap<CreateOrderViewModel, Order>()
            .ForMember(dest => dest.SubTotal, opt => opt.Ignore())
            .ForMember(dest => dest.DisCount, opt => opt.Ignore())
            .ForMember(dest => dest.Total, opt => opt.Ignore())
            .ForMember(dest => dest.AppUser, opt => opt.Ignore())
            .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));
        CreateMap<UpdateOrderViewModel, Order>()
           .ForMember(dest => dest.SubTotal, opt => opt.Ignore())
           .ForMember(dest => dest.DisCount, opt => opt.Ignore())
           .ForMember(dest => dest.Total, opt => opt.Ignore())
           .ForMember(dest => dest.AppUser, opt => opt.Ignore())
           .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));

        CreateMap<OrderItem, OrderItemViewModel>()
           .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product != null ? src.Product.Name : null))
           .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.UnitPrice * src.Quantity));
        CreateMap<CreateOrderItemViewModel, OrderItem>()
            .ForMember(dest => dest.UnitPrice, opt => opt.Ignore())
            .ForMember(dest => dest.OrderId, opt => opt.Ignore())
            .ForMember(dest => dest.Order, opt => opt.Ignore())
            .ForMember(dest => dest.Product, opt => opt.Ignore());
        CreateMap<UpdateOrderItemViewModel, OrderItem>()
           .ForMember(dest => dest.UnitPrice, opt => opt.Ignore())
           .ForMember(dest => dest.OrderId, opt => opt.Ignore())
           .ForMember(dest => dest.Order, opt => opt.Ignore())
           .ForMember(dest => dest.Product, opt => opt.Ignore());

        CreateMap<PaymentImage, PaymentImageViewModel>().ReverseMap();
        CreateMap<PaymentImage,CreatePaymentImageViewModel>().ReverseMap();
        CreateMap<PaymentImage, UpdatePaymentImageViewModel>().ReverseMap();

        CreateMap<Product, ProductViewModel>()
            .ForMember(dest => dest.CategoryName,
                opt => opt.MapFrom(src => src.Category != null ? src.Category.CategoryName : null))
            .ForMember(dest => dest.Colors,
                opt => opt.MapFrom(src => src.ProductColors.Select(pc => pc.Color != null ? pc.Color.ColorName : "")))
            .ForMember(dest => dest.Images,
                opt => opt.MapFrom(src => src.ProductImages.Select(pi => pi.ImageUrl ?? "")));
        CreateMap<CreateProductViewModel, Product>()
            .ForMember(dest => dest.ProductImages, opt => opt.Ignore())
            .ForMember(dest => dest.ProductColors, opt => opt.Ignore()); 
        CreateMap<UpdateProductViewModel, Product>()
            .ForMember(dest => dest.ProductImages, opt => opt.Ignore())
            .ForMember(dest => dest.ProductColors, opt => opt.Ignore());

        CreateMap<ProductImage, ProductImageViewModel>()
            .ForMember(dest => dest.ProductName,
                opt => opt.MapFrom(src => src.Product != null ? src.Product.Name : null));
        CreateMap<CreateProductImageViewModel, ProductImage>()
            .ForMember(dest => dest.ImageUrl, opt => opt.Ignore()); 
        CreateMap<UpdateProductImageViewModel, ProductImage>()
            .ForMember(dest => dest.ImageUrl, opt => opt.Ignore());

        CreateMap<PromoCode, PromoCodeViewModel>().ReverseMap();
        CreateMap<CreatePromoCodeViewModel, PromoCode>()
            .ForMember(dest => dest.Uses, opt => opt.MapFrom(src => 0)); 
        CreateMap<UpdatePromoCodeViewModel, PromoCode>()
            .ForMember(dest => dest.Uses, opt => opt.Ignore());

        CreateMap<PromoUsage, PromoUsageViewModel>()
         .ForMember(dest => dest.PromoCode, opt => opt.MapFrom(src => src.PromoCode != null ? src.PromoCode.Code : string.Empty))
         .ForMember(dest => dest.AppUserName, opt => opt.MapFrom(src => src.AppUser != null ? src.AppUser.UserName : string.Empty));
        CreateMap<CreatePromoUsageViewModel, PromoUsage>().ReverseMap();
        CreateMap<UpdatePromoUsageViewModel, PromoUsage>().ReverseMap();

        CreateMap<RecommendationBanner, RecommendationBannerViewModel>().ReverseMap();
        CreateMap<CreateRecommendationBannerViewModel, RecommendationBanner>().ReverseMap();
        CreateMap<UpdateRecommendationBannerViewModel, RecommendationBanner>().ReverseMap();

        CreateMap<Review, ReviewViewModel>().ReverseMap();
        CreateMap<Review,CreateReviewViewModel>().ReverseMap();
        CreateMap<Review,UpdateReviewViewModel>().ReverseMap();

        CreateMap<SiteBanner, SiteBannerViewModel>().ReverseMap();
        CreateMap<SiteBanner,CreateSiteBannerViewModel>().ReverseMap();
        CreateMap<SiteBanner,UpdateSiteBannerViewModel>().ReverseMap();

        CreateMap<Slider, SliderViewModel>().ReverseMap();
        CreateMap<CreateSliderViewModel, Slider>()
            .ForMember(dest => dest.SliderImgUrl, opt => opt.Ignore());
        CreateMap<UpdateSliderViewModel, Slider>()
            .ForMember(dest => dest.SliderImgUrl, opt => opt.Ignore());

        CreateMap<Social,SocialViewModel>().ReverseMap();
        CreateMap<Social,CreateSocialViewModel>().ReverseMap();
        CreateMap<Social,UpdateSocialViewModel>().ReverseMap();

        CreateMap<WebInfo, WebInfoViewModel>().ReverseMap();
        CreateMap<WebInfo,CreateWebInfoViewModel>().ReverseMap();
        CreateMap<WebInfo,UpdateWebInfoViewModel>().ReverseMap();

        CreateMap<WebLogo, WebLogoViewModel>().ReverseMap();
        CreateMap<CreateWebLogoViewModel, WebLogo>()
            .ForMember(dest => dest.WebLogoImgUrl, opt => opt.Ignore());
        CreateMap<UpdateWebLogoViewModel, WebLogo>()
            .ForMember(dest => dest.WebLogoImgUrl, opt => opt.Ignore());
        CreateMap<WebLogo, UpdateWebLogoViewModel>()
            .ForMember(dest => dest.NewWebLogoImgUrl, opt => opt.Ignore());


        

       

        

































    }







}



