using AutoMapper;
using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Barsi.Api.Services.LoginService;
using BarsiSistemaRh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Barsi.Api.Controllers;

[ApiController]
[Route("/login")]
public class LoginController : Controller
{

    private readonly ILoginService _loginService;

    public LoginController(ILoginService loginService)
    {
        _loginService = loginService;
    }


    [HttpPost]
    public async Task<IActionResult> Acessar(LoginDto loginDto)
    {
        return await _loginService.Acessar(loginDto);
    }



}
