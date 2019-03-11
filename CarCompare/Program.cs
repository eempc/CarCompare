using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CarCompare.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CarCompare {
    public class Program {
        public static void Main(string[] args) {
            //CreateWebHostBuilder(args).Build().Run();
            // See data
            var host = CreateWebHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope()) {
                var services = scope.ServiceProvider;

                try {
                    var context = services.GetRequiredService<CarCompareContext>();
                    context.Database.Migrate();
                    SeedData.Initialize(services);
                }
                catch (Exception e) {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(e, "Error in seed data");
                }
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
