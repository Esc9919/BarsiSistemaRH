using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/login", async context =>
    {
        context.Response.ContentType = "text/html";
        await context.Response.SendFileAsync("C:\\Users\\Public\\Barsi-Sistema-RH\\BarsiSistemaRH\\BarsiSistemaRh\\Barsi.Web\\HTML\\sua-pagina-login.html");
    });

});

app.Run();
