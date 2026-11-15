namespace EStoreAdminWeb.Middlewares
{
    public class LogtoFileMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Log To File Started\n");

            await next(context);

            await context.Response.WriteAsync("Log to File Ended\n");
        }
    }
}
