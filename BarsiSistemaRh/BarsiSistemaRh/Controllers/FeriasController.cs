using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Barsi.Api.Services.FeriasService;
using Microsoft.AspNetCore.Mvc;

namespace Barsi.Api.Controllers;

[ApiController]
[Route("/ferias")]
public class FeriasController : Controller
{
    private readonly IFeriasService _feriasService;

    public FeriasController(IFeriasService feriasService)
    {
        _feriasService = feriasService;
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> TirarFerias(int id, [FromBody] FeriasDTO feriasDTO)
    {
        return await _feriasService.TirarFerias(id, feriasDTO);
    }

}
