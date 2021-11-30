using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace SampleMvcApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

             CreateDbIfNotExists(host);

            host.Run();
        }

         private static void CreateDbIfNotExists(IHost host)
        {
            using(var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<LmcTeamDatabaseContext>();
                    DbInitializer.Initialize(context);

                } 
                catch(Exception ex)
                {

                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
