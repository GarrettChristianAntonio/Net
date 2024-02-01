using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using PruebasUnitarias.Repositorios;
using PruebasUnitarias.Data;

namespace PruebasUnitarias
{
	public class Startup
	{
		private IConfiguration _configuration;
		public Startup(IConfiguration configuration)
		{
			_configuration = configuration;
		}		
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ProductContext>(options => options.UseSqlServer(_configuration.GetConnectionString("ConexionSQL")));
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddMvc();
			services.AddMvc(options => options.EnableEndpointRouting = false);
		}
		public void Configure(IApplicationBuilder app, ProductContext productContext)
		{
			productContext.Database.EnsureDeleted();
			productContext.Database.EnsureCreated();
			app.UseStaticFiles();
			app.UseMvc(routes => {
				routes.MapRoute(
				name: "defaultRoute",
				template: "{controller=Product}/{action=Index}/{id?}");
			});
		}
	}
}
