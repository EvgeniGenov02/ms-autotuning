using Microsoft.EntityFrameworkCore;
using ms_autotuning.Core.Contracts;
using ms_autotuning.Core.Services;
using ms_autotuning.Infrastructior.Data;
using ms_autotuning.Infrastructior.Data.Models;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAdministratorService, AdministratorService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<IOrderService, OrderService>();
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services
             .AddDefaultIdentity<ApplicationUser>(options =>
             {
                 options.SignIn.RequireConfirmedAccount = false;
                 options.Password.RequireDigit = false;
                 options.Password.RequireLowercase = false;
                 options.Password.RequireUppercase = false;
                 options.Password.RequireNonAlphanumeric = false;
             })
             .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
