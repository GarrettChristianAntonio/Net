using Microsoft.AspNetCore.Builder;
using VistasParciales.Services;
using Microsoft.AspNetCore.Hosting;

namespace VistasParciales
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Emplementando Componentes de Vistas...");
            });

        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddSingleton<IPersonaProvider, PersonaProvider>();
            services.AddMvc().AddRazorOptions(options =>
            {
                options.ViewLocationFormats.Add("/Views/Shared/Components/{0}/{1}.cshtml");
            });
        }
        

    }
}
