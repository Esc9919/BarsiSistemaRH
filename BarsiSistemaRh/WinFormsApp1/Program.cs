using Barsi.Api.Services.LoginService;
using BarsiSistemaRh.Data;
using Login;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var serviceProviderLogin = new ServiceCollection()
            .AddDbContext<FuncionarioContext>()
            .AddScoped<ILoginService, LoginService>() // Registre o serviço aqui
            .BuildServiceProvider();

            var serviceProvider = new ServiceCollection()
            .AddDbContext<FuncionarioContext>()
            .BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var loginService = serviceProviderLogin.GetRequiredService<ILoginService>(); // Obtenha o ILoginService do provedor de serviços de login
            Application.Run(new pg_login(loginService)); // Passe o ILoginService para o construtor de pg_login



        }

    }
}