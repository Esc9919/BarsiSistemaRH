using Barsi.Api.Services.FeriasService;
using Barsi.Api.Services.LoginService;
using BarsiSistemaRh.Data;
using Login;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Barsi.Desktop;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

        ConfigureJsonSerialization();


        var serviceProviderLogin = new ServiceCollection()
        .AddDbContext<FuncionarioContext>()
        .AddScoped<ILoginService, LoginService>()
        .BuildServiceProvider();

        var serviceProvider = new ServiceCollection()
        .AddDbContext<FuncionarioContext>()
        .AddScoped<IFeriasService, FeriasService>()
        .AddScoped<ILoginService, LoginService>()
        .BuildServiceProvider();




        ApplicationConfiguration.Initialize();
        var service = serviceProvider.GetRequiredService<IFeriasService>();
        Application.Run(new pg_agenda_ferias(service));



    }

    private static void ConfigureJsonSerialization()
    {
        JsonConvert.DefaultSettings = () => new JsonSerializerSettings
        {
            // Configurações personalizadas do JSON.NET aqui
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Formatting = Formatting.Indented
            // ... outras configurações ...
        };

    }


}
