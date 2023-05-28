using BlogPersonal.Models;
using DTOs.DTO;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Servicios.Servicices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



builder.Services.AddTransient<IServicioProyectos, ServicioProyectos>();

builder.Services.AddTransient<IServicioCertificaciones, ServicioCeritificaciones>();

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
    pattern: "{controller=Portafolio}/{action=Index}/{id?}");

app.Run();
