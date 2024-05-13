using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServics(this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<DataContext>(opt =>
        {;
                opt.UseSqlite(config.GetConnectionString("DefaultConfiguration"));
        });
            services.AddCors();
            services.AddScoped<ITokenService, TokenService>();
            return services;
        }
    }
}