using Microsoft.EntityFrameworkCore;
using mvc.Data.Context;


namespace mvc
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MvcContext>(
                opt => opt.UseSqlServer(configuration.GetConnectionString("PVConnection"))
            );
            return services;
        }
    }
}
