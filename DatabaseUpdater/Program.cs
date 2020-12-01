using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseUpdater.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DatabaseUpdater
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var optionsBuilder = new DbContextOptionsBuilder<DataAccessContext>();
                    optionsBuilder.UseSqlServer("Server=LAPTOP-PUNMAMAF; Database=MicrocontrollerDataDB; Trusted_Connection=True; MultipleActiveResultSets=True;");//,
                    services.AddScoped<DataAccessContext>(s => new DataAccessContext(optionsBuilder.Options));

                    services.AddHostedService<Worker>();
                });

            return host;
        }
    }
}
