using AutoMapper;
using Barsi.Api.Models.Dtos.DepartamentoDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;


namespace Barsi.Api.Controllers;

[ApiController]
[Route ("/departamento")]
public class DepartamentoController : Controller
{
    private FuncionarioContext _context;
    private IMapper _mapper;

    public DepartamentoController(FuncionarioContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;

    }

    [HttpPost]
    public IActionResult AdicionarDepartamento([FromBody] AdicionarDepartamentoDto departamentoDto)
    {
        Departamento departamento = _mapper.Map<Departamento>(departamentoDto);
        _context.Departamentos.Add(departamento);
        _context.SaveChanges();
        return CreatedAtAction(nameof(ListarDepartamentoPorId), new { Id = departamento.idDepartamento }, departamentoDto);

    }



    [HttpGet]
    public IEnumerable<ApresentarDepartamentoDto> ListarDepartamento()
    {
        return _mapper.Map<List<ApresentarDepartamentoDto>>(_context.Departamentos.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult ListarDepartamentoPorId(int id)
    {
        Departamento departamento = _context.Departamentos.FirstOrDefault(departamento => departamento.idDepartamento == id);
        if (departamento != null)
        {
            ApresentarDepartamentoDto departamentoDto = _mapper.Map<ApresentarDepartamentoDto>(departamento);
            return Ok(departamentoDto);
        }

        return NotFound("Departamento não existe");
    }

    [HttpPut("{id}")]
    public IActionResult AlterarDepartamento(int id, [FromBody] AlterarDepartamentoDto departamentoDto)
    {
        Departamento departamento = _context.Departamentos.FirstOrDefault(departamento => departamento.idDepartamento == id);
        if (departamento == null)
        {
            return NotFound("Departamento não existe");
        }

        _mapper.Map(departamentoDto, departamento);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarDepartamento(int id) 
    {
        Departamento departamento = _context.Departamentos.FirstOrDefault(departamento => departamento.idDepartamento == id);
        if(departamento == null)
        {
            return NotFound("Departamento não existe");
        }

        _context.Remove(departamento);
        _context.SaveChanges();
        return NoContent();
    }


}
