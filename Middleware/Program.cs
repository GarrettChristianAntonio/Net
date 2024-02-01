using Middleware;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();


//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("asdf<br/>");
//    await next.Invoke();
//});

//app.Run( async context =>{
//    await context.Response.WriteAsync("Concepto de Middleware");   
//});

//app.Map("/ruta1", ManejadorRutaUno);
//app.Map("/ruta2", ManejadorRutaDos);
app.UseMiddleware<MiddlewareRespuesta>();

app.Run(async context =>
{
    await context.Response.WriteAsync("adsfasdf");
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


static void ManejadorRutaUno(IApplicationBuilder app)
{
    app.Run(async context =>
    {
        await context.Response.WriteAsync("manejador 1");
    });
}