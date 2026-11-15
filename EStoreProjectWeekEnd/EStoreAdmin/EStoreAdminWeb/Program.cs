using EStoreAdminWeb.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<LogtoFileMiddleware>();


var app = builder.Build();

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Welcome To ITask Technologies - Started\n");

    await next(context);

    await context.Response.WriteAsync("Welcome To ITask Technologies - ended\n");
});

app.UseMiddleware<LogtoFileMiddleware>();

app.UseLogToDBMiddleware();

app.UseLogToFlatFileMiddleware();

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Welcome To Dotnet WeekEnd Batch\n");
});

app.Run();
