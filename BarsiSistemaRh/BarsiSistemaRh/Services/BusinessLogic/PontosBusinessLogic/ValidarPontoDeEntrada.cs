using Barsi.Api.Models.Dtos.PontoDtos;
using Microsoft.EntityFrameworkCore;

namespace Barsi.Api.Services.BusinessLogic.PontosBusinessLogic;

public class ValidarPontoDeEntrada : IValidarPonto
{

    private readonly FuncionarioContext _context;

    public ValidarPontoDeEntrada(FuncionarioContext context)
    {
        _context = context;
    }
    public void ValidarPonto(BaterPrimeiroPontoDto pontoDto)
    {

        if (!_context.Pontos.Any(ponto => ponto.pontoExtra1 == pontoDto.pontoEntrada))
        {
            
        }
    }
}
