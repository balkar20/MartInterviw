using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Routing1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            // определяем обработчик маршрута
            var myRouteHandler = new RouteHandler(Handle);
            // создаем маршрут, используя обработчик
            var routeBuilder = new RouteBuilder(app, myRouteHandler);
            // само определение маршрута - он должен соответствовать запросу {controller}/{action}
            routeBuilder.MapRoute("default", "{controller}/{action}");
            // строим маршрут
            app.UseRouter(routeBuilder.Build());

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }

        // собственно обработчик маршрута
        private async Task Handle(HttpContext context)
        {
            await context.Response.WriteAsync("Hello ASP.NET Core!");
        }
    }
}
