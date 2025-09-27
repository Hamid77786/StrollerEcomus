

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


        return services;
    }
}
