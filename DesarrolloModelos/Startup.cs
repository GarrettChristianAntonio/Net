using DesarrolloModelos.Services;
using Microsoft.AspNetCore.Builder;

namespace DesarrolloModelos
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app)
		{
			
			
			app.UseStaticFiles();
			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Butterfly}/{action=Index}/{id?}");
			});

		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddSingleton<IDataService, DataService>();
			services.AddSingleton<IButterfliesQuantityService, ButterfliesQuantityService>();
			
		}
	}
}
