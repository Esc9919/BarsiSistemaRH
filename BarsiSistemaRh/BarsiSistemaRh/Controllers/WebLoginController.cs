using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Barsi.Api.Services.LoginService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Barsi.Web.Controllers;

public class WebLoginController : Controller
{
    private readonly ILoginService _loginService;

    public WebLoginController(ILoginService loginService)
    {
        _loginService = loginService;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Acessar(LoginDto loginDto)
    {
        var resultado = _loginService.Acessar(loginDto);

        if (resultado is OkObjectResult)
        {
            return View("PáginaDeSucesso"); 
        }
        else
        {
            return View("PáginaDeErro");
        }
    }
}
