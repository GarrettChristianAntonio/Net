using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Filtros
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc(options => options.EnableEndpointRouting = false);
		}
		public void Configure(IApplicationBuilder app)
		{
			app.UseStaticFiles();
			app.UseMvcWithDefaultRoute();
		}
		
	}
}
