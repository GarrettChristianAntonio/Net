using Microsoft.AspNetCore;

namespace Sql_Lite
{
	public class Program
	{
		public static void Main(string[] args)
		{
			webHostBuilder(args).Build().Run();
		}
		public static IWebHostBuilder webHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
	}
}
