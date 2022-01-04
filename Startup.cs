using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace HelloWorld
{
    public class Startup
    {
        public Startup(IWebHostEnvironment env)
        {
            
        }
        public void Configure(IApplicationBuilder app,IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello, World!");
            });
        }
    }
}
