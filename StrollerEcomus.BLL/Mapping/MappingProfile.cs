

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

        CreateMap<IconCategory, IconCategoryViewModel>();
        CreateMap<CreateIconCategoryViewModel, IconCategory>();
        CreateMap<UpdateIconCategoryViewModel, IconCategory>()
            .ForMember(dest => dest.Icons, opt => opt.Ignore());

        CreateMap<Language, LanguageViewModel>();
        CreateMap<CreateLanguageViewModel, Language>();
        CreateMap<UpdateLanguageViewModel, Language>();

        CreateMap<LogInContent, LogInContentViewModel>();
        CreateMap<LogInContent, CreateLogInContentViewModel>();
        CreateMap<LogInContent, UpdateLogInContentViewModel>();

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
            .ForMember(dest => dest.UnitPrice, opt => opt.Ignore()) // UnitPrice присвоим в сервисе
            .ForMember(dest => dest.OrderId, opt => opt.Ignore())
            .ForMember(dest => dest.Order, opt => opt.Ignore())
            .ForMember(dest => dest.Product, opt => opt.Ignore());
        CreateMap<UpdateOrderItemViewModel, OrderItem>()
           .ForMember(dest => dest.UnitPrice, opt => opt.Ignore()) // UnitPrice присвоим в сервисе
           .ForMember(dest => dest.OrderId, opt => opt.Ignore())
           .ForMember(dest => dest.Order, opt => opt.Ignore())
           .ForMember(dest => dest.Product, opt => opt.Ignore());








    }

}

