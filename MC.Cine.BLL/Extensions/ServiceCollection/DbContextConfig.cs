//using MC.Cine.DAL.Unificacion;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MC.Cine.BLL.Extensions.ServiceCollection
{
    public static class DbContextConfig
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DAL.Data.Context.SirecV2.dbContextSirec>(options => {
                options.UseLazyLoadingProxies()
                       .UseSqlServer(configuration.GetConnectionString("ConnectionSirecV2"));
            });
            return services;
        }
    }
}
