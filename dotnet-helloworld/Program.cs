using System;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace dotnet_helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting web server");
            var webHost = new WebHostBuilder()
            .UseKestrel()
            .UseStartup<Program>()
            .UseUrls("http://0.0.0.0:8080")
            .Build();
            webHost.Run();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Information);
            app.UseMvc();
        }
    }
}
