using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Barsi.Api.Services.FuncionarioService
{
    public interface IFuncionarioService
    {
        Task<Funcionario?> AdicionarFuncionario([FromBody] AdicionarFuncionarioDto funcionarioDto);
        Task<IEnumerable<ListarFuncionarioDto>> ListarFuncionarios([FromQuery] int skip = 0, [FromQuery] int take = 20);
        Task<IActionResult> ListarFuncionarioPorId(int id);
        Task<IActionResult> AlterarFuncionario(int id, [FromBody] AlterarFuncionarioDto alterarFuncionarioDto);
        Task<IActionResult> DeletarFuncionario(int id);
    }
}
