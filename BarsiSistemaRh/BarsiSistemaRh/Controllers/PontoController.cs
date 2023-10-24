using AutoMapper;
using Barsi.Api.Models;
using Barsi.Api.Models.Dtos.PontoDtos;
using Barsi.Api.Services.PontoService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

namespace Barsi.Api.Controllers;

[ApiController]
[Route("/ponto")]
public class PontoController : Controller
{
    private readonly PontoService _pontoService;

    public PontoController(PontoService pontoService)
    {
        _pontoService = pontoService;
    }

    //[HttpPost]
    //public async Task<IActionResult> BaterPonto(int id)
    //{
    //    return await _pontoService.BaterPonto();
    //}

}
