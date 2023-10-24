using Barsi.Api.Models;
using Barsi.Api.Models.Dtos.PontoDtos;
using Microsoft.AspNetCore.Mvc;

namespace Barsi.Api.Services.PontoService
{
    public interface IPontoService
    {
        Task<IActionResult> BaterPonto(string cpf);
    }
}
