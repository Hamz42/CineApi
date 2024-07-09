using MC.Cine.BLL.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MC.Cine.BLL.Extensions.ApplicationBuilder
{
    public static class DefaultConfig
    {
        public static void InitconfigurationAPI(this IApplicationBuilder application, IWebHostEnvironment webHostEnvironment)
        {
            application.UseCors("AllowMyOrigin");

            if (webHostEnvironment.IsDevelopment())
            {
                application.UseDeveloperExceptionPage();
            }

            application.UseMiddleware<LogMiddleware>();
            application.UseHttpsRedirection();
            application.UseRouting();
            application.UseAuthentication();
            application.UseAuthorization();
            application.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
