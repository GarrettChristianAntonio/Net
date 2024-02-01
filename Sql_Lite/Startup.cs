using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Sql_Lite.Data;

namespace Sql_Lite
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app, PersonContext personContext)
		{
			personContext.Database.EnsureDeleted();
			personContext.Database.EnsureCreated();
			app.UseStaticFiles();
			app.UseMvc(routes => {
					routes.MapRoute(
					name: "defaultRoute",
					template: "{Controller=Person}/{action=Index}/{id?}",
					defaults: new { controller = "Person", action = "Index" });
				});
	
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc(options => options.EnableEndpointRouting = false);
			services.AddDbContext<PersonContext>(options => options.UseSqlite("Data Source = person.db"));
			services.AddMvc();		
			
		}
	}
}
