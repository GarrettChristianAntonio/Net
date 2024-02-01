using Microsoft.AspNetCore.Builder;


namespace Rutas
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection servicios)
		{
			servicios.AddMvcCore();
			servicios.AddMvc(options => options.EnableEndpointRouting = false);

		}
		public void Configure(IApplicationBuilder app)
		{
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "rutaUno",
					template: "{controller}/{action}/num:int"
					);

				routes.MapRoute(
					name: "rutaDos",
					template: "{controller}/{action}/{id?}",
					defaults: new { controller = "Home", action = "Index" },
					constraints: new { id = "[0-9]+" }
					);
			});
		}
	}
}
