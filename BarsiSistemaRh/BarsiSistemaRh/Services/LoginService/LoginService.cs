using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barsi.Api.Services.LoginService;

public class LoginService : ILoginService
{
    private readonly FuncionarioContext _context;

    public LoginService(FuncionarioContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Acessar(LoginDto loginDto)
    {
        var funcionarioUsuario = await _context.Funcionarios.FirstOrDefaultAsync(funcionario => funcionario.usuario == loginDto.usuario);
        var funcionarioSenha = await _context.Funcionarios.FirstOrDefaultAsync(funcionario => funcionario.senha == loginDto.senha);

        if (funcionarioSenha is null && funcionarioUsuario is null)
        {
            return new UnauthorizedObjectResult("Acesso negado!");
        }
        else if (funcionarioUsuario is null)
        {
            return new UnauthorizedObjectResult("Usuario incorreto!");
        }
        else if (funcionarioSenha is null)
        {
            return new UnauthorizedObjectResult("Senha incorreta!");
        }

        return new OkObjectResult("Acesso permitido!");
    }
}
