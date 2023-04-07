using Cobala.Areas.Admin.Services;
using Cobala.Controllers;
using Cobala.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSession();//session

builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<DatabaseContext>(option => option.UseLazyLoadingProxies().UseSqlServer(connectionString));




builder.Services.AddScoped<Cobala.Areas.Admin.Services.CategoryService, Cobala.Areas.Admin.Services.CategoryServiceIplm>();


var app = builder.Build();

app.UseStaticFiles(); //cau hinh cho hinh anh sau khi tao folder wwwroot
app.UseSession();//session
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}");

app.Run();
