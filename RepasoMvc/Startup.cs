using Microsoft.AspNetCore.Builder;

namespace RepasoMvc
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app)
		{
			app.UseStaticFiles();
			app.UseMvcWithDefaultRoute();
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddMvc(options => options.EnableEndpointRouting = false);
		}
	}
}
