namespace WebApplicationMVC_Core_6
{
    public class Startup
    {
        private IConfigurationRoot Configuration;

        public Startup(IConfigurationRoot configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(x=>x.MapControllers());
        }
    }
}
