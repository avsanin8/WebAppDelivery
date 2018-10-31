using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebAppDelivery.Models;

namespace WebAppDelivery
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<OrderContext>();
                    SampleData.Initialize(context);
                }
                catch (Exception ex)
                {
                    //В данном случае получаем контекст из сервисов и вызываем инициализатор. 
                    //В случае ошибки осуществляем логгирования через соответствующий сервис.
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Зараза блин: Error occurred while seeding the database.");
                    
                }
            }

            host.Run();

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
