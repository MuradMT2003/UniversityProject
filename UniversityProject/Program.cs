var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    "default",
    "{controller=student}/{action=index}/{id?}");
app.UseStaticFiles();
app.Run();
