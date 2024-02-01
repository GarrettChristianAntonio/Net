using Microsoft.AspNetCore.Builder;

namespace VistasRazor1
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
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Producto",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Producto", action = "Index" }
                    );
            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Implementando VISTAS...");
            });

        }
    }
}
