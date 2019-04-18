using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SeviceTrain3.Services;

namespace SeviceTrain3
{
    public class TimerMiddleware
    {
        private readonly RequestDelegate _next;
        TimeService _timeService;
        public TimerMiddleware(RequestDelegate next, TimeService timeService)
        {
            _next = next;
            _timeService = timeService;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.ContentType = "text/html; charset=utf-8";
            await context.Response.WriteAsync($"Текущее время: {_timeService?.GetTime()}");
        }
    }
}