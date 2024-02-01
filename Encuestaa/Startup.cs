using Encuestaa.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace Encuestaa
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPollResultService, PollResultService>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, Microsoft.Extensions.Hosting.IHostingEnvironment env, IPollResultService pollResultService)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
          
            app.Use(async (context , next) => {
                if (context.Request.Query.ContainsKey("favorite"))
                {
                    string selectedValue = context.Request.Query["favorite"];
                    Deporte selectedGame = (Deporte)Enum.Parse(typeof(Deporte), selectedValue, true);
                    pollResultService.AddVote(selectedGame);
                    SortedDictionary<Deporte, int> gameVotes = pollResultService.GetVoteResult();
                    foreach(KeyValuePair<Deporte, int> item in gameVotes)
                    {
                        await context.Response.WriteAsync($"<div>Nombre deporte: {item.Key}, Votos: {item.Value} </div>");
                    }
                }
                else
                {
                    await next.Invoke();
                }
            });

            app.UseStaticFiles();
            app.UseRouting();

            app.Run(async (context) =>
            {
                //await context.Response.WriteAsync("Este texto fué generado por el método middleware Run de app");
                await context.Response.WriteAsync("Este texto fué generado por el método middleware Run de app. wwwroot folder path:" +
                    env.ContentRootPath);
            });

        }
    }
}
