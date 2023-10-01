using Barsi.Api.Models.Dtos.FuncionarioDtos;

namespace Barsi.Api.Services.BusinessLogic;

public interface IValidarFuncionario
{
    void ValidarFuncionario(AdicionarFuncionarioDto funcionarioDto);
}
