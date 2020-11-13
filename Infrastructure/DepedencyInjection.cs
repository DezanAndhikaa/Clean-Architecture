using Application.Commons.Interfaces;
using Infrastructure.Persistences;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DepedencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DbConnectionString"))
                , ServiceLifetime.Transient);

            services.AddTransient<IAppDbContext>(options => options.GetService<AppDbContext>());
            
            return services;
        }
    }
}