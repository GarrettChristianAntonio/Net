using ErrorHandling.Servicios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Extensions;

namespace ErrorHandling
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env, ICounter counter)
		{
			if(env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/error.html");
			}
			app.UseStaticFiles();
			app.Use(async (context, next) =>
			{
				counter.IncrementRequestPathCount(context.Request.GetDisplayUrl());
				await next.Invoke();
			});
			app.UseMvcWithDefaultRoute();
		}
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddSingleton<ICounter,  Counter>();
			services.AddSingleton<IDivisionCalculator, DivisionCalculator>();
			services.AddMvc(options => options.EnableEndpointRouting = false);

		}
	}
}
