using mvc;

var builder = WebApplication.CreateBuilder(args);

//services collections (le pasamos el fichero de configuracion appsettings,
//es para pasarle la cadena de configuracion de la base de datos y todo lo demas)
builder.Services.AddServices(builder.Configuration);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
