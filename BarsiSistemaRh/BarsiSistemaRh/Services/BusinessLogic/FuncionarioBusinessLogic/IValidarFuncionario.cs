using Barsi.Api.Models.Dtos.FuncionarioDtos;

namespace Barsi.Api.Services.BusinessLogic.FuncionarioBusinessLogic;

public interface IValidarFuncionario
{
    void ValidarFuncionario(AdicionarFuncionarioDto funcionarioDto);
}
