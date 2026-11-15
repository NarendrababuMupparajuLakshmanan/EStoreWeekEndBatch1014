using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace EStoreAdminWeb.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class LogToFlatFileMiddleware
    {
        private readonly RequestDelegate _next;

        public LogToFlatFileMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            await httpContext.Response.WriteAsync("Log to Flat File - Started\n");
            await _next(httpContext);
            await httpContext.Response.WriteAsync("Log to Flat File - Ended\n");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LogToFlatFileMiddlewareExtensions
    {
        public static IApplicationBuilder UseLogToFlatFileMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogToFlatFileMiddleware>();
        }
    }
}
