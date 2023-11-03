using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Microsoft.AspNetCore.Mvc;

namespace Barsi.Api.Services.FeriasService;

public interface IFeriasService
{
    Task<IActionResult> TirarFerias(int id, DateTime inicioFerias, DateTime fimFerias);
}
