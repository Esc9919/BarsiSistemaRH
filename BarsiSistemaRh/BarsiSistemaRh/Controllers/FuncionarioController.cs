using AutoMapper;
using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Barsi.Api.Services.FuncionarioService;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace BarsiSistemaRh.Controllers;

[ApiController]
[Route("/funcionario")]
public class FuncionarioController : Controller
{

    private readonly IFuncionarioService _funcionarioService;

    public FuncionarioController(IFuncionarioService funcionarioService)
    {
        _funcionarioService = funcionarioService;
    }


    [HttpPost]
    public async Task<Funcionario?> AdicionarFuncionario([FromBody] AdicionarFuncionarioDto funcionarioDto)
    {
        return await _funcionarioService.AdicionarFuncionario(funcionarioDto);
    }

    [HttpGet]
    public async Task<IEnumerable<ListarFuncionarioDto>> ListarFuncionarios([FromQuery] int skip = 0, [FromQuery] int take = 20)
    {
        return await _funcionarioService.ListarFuncionarios(skip, take);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ListarFuncionarioPorId(int id)
    {
        return await _funcionarioService.ListarFuncionarioPorId((int)id);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AlterarFuncionario(int id, [FromBody] AlterarFuncionarioDto alterarFuncionarioDto)
    {
        return await _funcionarioService.AlterarFuncionario(id, alterarFuncionarioDto);
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarFuncionario(int id)
    {
        return await _funcionarioService.DeletarFuncionario((int)id);   
    }


}
