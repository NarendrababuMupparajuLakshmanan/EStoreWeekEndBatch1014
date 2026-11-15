var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//This Middleware is used to download Files frow wwwRoot Folder
app.UseStaticFiles();

app.UseRouting();

app.MapControllers();


app.Run();
