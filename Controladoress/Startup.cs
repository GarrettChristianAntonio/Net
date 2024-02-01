using Microsoft.AspNetCore.Builder;

namespace Controladoress
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection servicios)
        {
            servicios.AddMvc();
            servicios.AddMvc(options => options.EnableEndpointRouting = false);

        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
