using Microsoft.AspNetCore.Builder;
using TourProject.Filtros;
using TourProject.Models;

namespace TourProject
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app)
		{
			app.UseStaticFiles();
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "TuristaRoute",
					template: "{controller}/{action}/{name}",
					constraints: new { name = "[A-Za-z]+" },
					defaults: new { controller = "Turista", action = "Index", name = "" }
					);
                routes.MapRoute(
                    name: "defaultRoute",
                    template: "{controller}/{action}/{id?}",
                    constraints: new { id = "[0-9]+" },
                    defaults: new { controller = "Home", action = "Index" }
                    );
            });
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddSingleton<IData, Data>();
			services.AddScoped<LogActionFilterAttribute>();
           
        }		
	}
}
