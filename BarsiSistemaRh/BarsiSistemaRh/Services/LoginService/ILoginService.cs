using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Microsoft.AspNetCore.Mvc;

namespace Barsi.Api.Services.LoginService
{
    public interface ILoginService
    {
        Task<IActionResult> Acessar(LoginDto loginDto);
    }
}
