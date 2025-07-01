using Microsoft.EntityFrameworkCore;
using ProyectoComex.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// ruta relativa al .exe (osea bin\Debug\net8.0\)
var dbPath = Path.Combine(AppContext.BaseDirectory, "database\\database.sqlite3");
builder.Services.AddDbContext<ComexContext>(options => options.UseSqlite($"Data Source={dbPath}"));


builder.Services.AddScoped<BaseDeDatos>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
