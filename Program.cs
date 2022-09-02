using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using apis_app.Data;
using System.Text;
using System.Text.Json;
using apis_app.Helper;
using apis_app.Data.DA.Weather;

var builder = WebApplication.CreateBuilder(args);
 

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddScoped<WaterService, WaterService>();
builder.Services.AddScoped<ClientService, ClientService>();
builder.Services.AddHttpClient();
 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
