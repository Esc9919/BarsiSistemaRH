using AutoMapper;
using Barsi.Api.Models;
using Barsi.Api.Models.Dtos.PontoDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;

namespace Barsi.Api.Controllers;

[ApiController]
[Route("/ponto")]
public class PontoController : Controller
{
    private FuncionarioContext _context;
    private IMapper _mapper;

    public PontoController(FuncionarioContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;

    }

    [HttpPost]
    public IActionResult AdicionarPonto([FromBody] AdicionarUsuarioPontoDto pontoDto)
    {
        Ponto ponto = _mapper.Map<Ponto>(pontoDto);
        _context.Pontos.Add(ponto);
        _context.SaveChanges();
        return CreatedAtAction(nameof(ListarPontoPorId), new { id = ponto.idPonto }, ponto);

    }



    [HttpGet]
    public IEnumerable<ApresentarPontoDto> ListarPonto()
    {
        return _mapper.Map<List<ApresentarPontoDto>>(_context.Pontos.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult ListarPontoPorId(int id)
    {
        Ponto ponto = _context.Pontos.FirstOrDefault(ponto => ponto.idPonto == id);
        if (ponto != null)
        {
            ApresentarPontoDto pontoDto = _mapper.Map<ApresentarPontoDto>(ponto);
            return Ok(pontoDto);
        }

        return NotFound("Ponto não existe");
    }

    [HttpPut("{id}")]
    public IActionResult AlterarPonto(int id, [FromBody] AlterarPontoDto pontoDto)
    {
        Ponto ponto = _context.Pontos.FirstOrDefault(ponto => ponto.idPonto == id);
        if (ponto == null)
        {
            return NotFound("Ponto não existe");
        }

        _mapper.Map(pontoDto, ponto);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarPonto(int id)
    {
        Ponto ponto = _context.Pontos.FirstOrDefault(ponto => ponto.idPonto == id);
        if (ponto == null)
        {
            return NotFound("Ponto não existe");
        }

        _context.Remove(ponto);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPost("{cpf}")]
    public IActionResult RegistrarPonto(string cpf)
    {



        Ponto ponto = _context.Pontos.FirstOrDefault(ponto => ponto.cpf == cpf);

        var registro = new Ponto();
        if (registro.pontoEntrada == null)
        {
            registro.pontoEntrada = DateTime.Now;
        }
        else if (registro.pontoAlmocoSaida == null)
        {
            registro.pontoAlmocoSaida = DateTime.Now;
        }
        else if (registro.pontoAlmocoVolta == null)
        {
            registro.pontoAlmocoVolta = DateTime.Now;
        }
        else if (registro.pontoSaida == null)
        {
            registro.pontoSaida = DateTime.Now;
        }

        // Salve o ponto no banco de dados
        _context.Pontos.Add(registro);
        _context.SaveChanges();

        return Ok("Ponto registrado com sucesso!");
    }

}
