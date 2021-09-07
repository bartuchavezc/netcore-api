using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace aam_bonmark_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hostBuilder = CreateHostBuilder(args).Build();
            // using (var scope = hostBuilder.Services.CreateScope())
            // {
            //     var services = scope.ServiceProvider;
            //     var context = services.GetRequiredService<DatabaseContext>();

            //     DatabaseInitializer.seed(context);
            // }
            hostBuilder.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
