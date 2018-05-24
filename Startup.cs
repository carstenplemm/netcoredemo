using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace dotnet
{
    class Startup
    {
	public Startup(IHostingEnvironment env)
        {
	   	
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logerFactory)
        {
	   app.Run(async (context) =>
           {
	      await context.Response.WriteAsync("Kuckuck!");
           });
        }
    }
}
