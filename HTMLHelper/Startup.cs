using Microsoft.AspNetCore.Builder;

namespace HTMLHelper
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Emplementando Helpers...");
            });
           
        }
        public void ConfigureServices(IServiceCollection service)
        {
            service.AddMvc();
            service.AddMvc(options => options.EnableEndpointRouting = false);
        }
    }
}
