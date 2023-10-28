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
        .BuildServiceProvider();

        ApplicationConfiguration.Initialize();
        var loginService = serviceProviderLogin.GetRequiredService<ILoginService>();
        Application.Run(new pg_login(loginService));



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