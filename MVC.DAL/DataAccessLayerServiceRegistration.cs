

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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


        return services;
    }

}
