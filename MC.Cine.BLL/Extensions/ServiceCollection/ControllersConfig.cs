using MC.Cine.BLL.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace MC.Cine.BLL.Extensions.ServiceCollection
{
    public static class ControllersConfig 
    {
        public static IServiceCollection AddControllersExtend(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add<GlobalValidationFilterAttribute>();
            }).ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            })
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                options.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Local;
                options.UseCamelCasing(false);
            });
            return services;
        }
    }
}
