﻿using Microsoft.AspNetCore.Builder;
using VistasParciales.Services;

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
                await context.Response.WriteAsync("Emplementando VistasParciales...");
            });

        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddSingleton<IPersonaProvider, PersonaProvider>();
        }
    }
}
