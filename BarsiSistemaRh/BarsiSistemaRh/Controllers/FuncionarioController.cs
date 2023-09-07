using AutoMapper;
using BarsiSistemaRh.Data;
using BarsiSistemaRh.Data.Dtos.FuncionarioDtos;
using BarsiSistemaRh.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BarsiSistemaRh.Controllers;

[ApiController]
[Route("[controller]")]
public class FuncionarioController : Controller
{

    private FuncionarioContext _context;
    private IMapper _mapper;

    public FuncionarioController(FuncionarioContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    [HttpPost]
    public IActionResult AdicionarFuncionario([FromBody] AdicionarFuncionarioDto funcionarioDto)
    {
        Funcionario funcionario = _mapper.Map<Funcionario>(funcionarioDto);
        _context.Funcionarios.Add(funcionario);
        _context.SaveChanges();
        return CreatedAtAction(nameof(ListarFuncionarioPorId),
            new { id = funcionario.idFuncionario },
            funcionario);
    }

    [HttpGet]
    public IEnumerable<ListarFuncionarioDto> ListarFuncionarios([FromQuery] int skip = 0, [FromQuery] int take = 20)
    {
        return _mapper.Map<List<ListarFuncionarioDto>>(_context.Funcionarios.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult ListarFuncionarioPorId(int id)
    {
        var funcionario = _context.Funcionarios.FirstOrDefault(funcionario => funcionario.idFuncionario == id);
        if (funcionario is null)
        {
            return NotFound("Esse funcionário não existe");
        }

        var funcionarioDto = _mapper.Map<ListarFuncionarioDto>(funcionario);

        return Ok(funcionarioDto);
    }

    [HttpPut("{id}")]
    public IActionResult AlterarFuncionario(int id, [FromBody] AlterarFuncionarioDto alterarFuncionarioDto)
    {
        var funcionario = _context.Funcionarios.FirstOrDefault(funcionario => funcionario.idFuncionario == id);
        if (funcionario == null) return NotFound("Funcionario não existe");
        _mapper.Map(alterarFuncionarioDto, funcionario);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult AlterarFuncionarioParcial(int id, JsonPatchDocument<AlterarFuncionarioDto> patch)
    {
        var funcionario = _context.Funcionarios.FirstOrDefault(funcionario => funcionario.idFuncionario == id);
        if (funcionario == null) return NotFound("Funcionario não existe");

        var funcionarioParaAlterar = _mapper.Map<AlterarFuncionarioDto>(funcionario);

        patch.ApplyTo(funcionarioParaAlterar, ModelState);

        if(!TryValidateModel(funcionarioParaAlterar))
        {
            return ValidationProblem(ModelState);
        }

        _mapper.Map(funcionarioParaAlterar, funcionario);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarFuncionario(int id)
    {
        var funcionario = _context.Funcionarios.FirstOrDefault(funcionario => funcionario.idFuncionario == id);
        if (funcionario == null) return NotFound("Funcionario não existe");

        _context.Remove(funcionario);
        _context.SaveChanges();
        return NoContent();
    }


}
