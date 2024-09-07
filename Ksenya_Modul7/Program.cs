using Ksenya_Modul7.Models;
using Microsoft.EntityFrameworkCore;
using MusicCatalog.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
var connectionString = builder.Configuration.GetConnectionString("MyRazorPagesDb");

// builder.Services.AddDbContext<DataBaseContext>(options =>
 //   options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


builder.Services.AddDbContext<DataBaseContext>();
builder.Services.AddDbContext<MyDbContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
