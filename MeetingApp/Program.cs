var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();

// {Controller = "Home"}/{Action = "Index"}/{id?}
//app.MapDefaultControllerRoute();

app.MapControllerRoute
(
    name: "Default",
    pattern: "{controller=Meeting}/{action=Index}/{id?}"
);

app.Run();
