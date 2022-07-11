using Skclusive.Core.Component;
using Skclusive.Material.Component;
using Skclusive.Material.Core;
using Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<ScheduleService>();
builder.Services.TryAddMaterialServices
(
    new MaterialConfigBuilder()
        .WithIsServer(true)
        .WithIsPreRendering(true)
        .WithTheme(Theme.Light)
        .WithDisableBinding(false)
        .WithDisableConfigurer(false)
        .Build()
);

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
