using ASPNET_Assignment_1.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<Database>();

var connectionString = "Server=(localdb)\\mssqllocaldb;" +
                       "Database=EventiaDB";
builder.Services.AddDbContext<EventDbContext>(
    options =>
    {
        options.UseSqlServer(connectionString);
    });

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern:"{controller=Event}/{action=Home}");

using(var scope = app.Services.CreateScope())
{
    var database = scope.ServiceProvider
        .GetRequiredService<Database>();

    await database.RecreateDb();
    await database.Seed();
}

app.Run();
