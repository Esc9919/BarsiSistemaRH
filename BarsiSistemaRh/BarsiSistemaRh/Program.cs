global using BarsiSistemaRh.Models;
global using BarsiSistemaRh.Data;
using Microsoft.EntityFrameworkCore;
using Barsi.Api.Services.LoginService;
using Barsi.Api.Services.FuncionarioService;
using Barsi.Api.Services.BusinessLogic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ILoginService, LoginService>();

builder.Services.AddScoped<IFuncionarioService, FuncionarioService>();

builder.Services.AddDbContext<FuncionarioContext>();

builder.Services.AddScoped<IValidarFuncionario, ValidarCpf>();

builder.Services.AddScoped<IValidarFuncionario, ValidarRg>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
