using Barsi.Api.Models.Dtos.FuncionarioDtos;
using DocumentValidator;

namespace Barsi.Api.Services.BusinessLogic.FuncionarioBusinessLogic
{
    public class ValidarRg : IValidarFuncionario
    {
        private readonly FuncionarioContext _context;

        public ValidarRg(FuncionarioContext context)
        {
            _context = context;
        }

        public void ValidarFuncionario(AdicionarFuncionarioDto funcionarioDto)
        {
            if (!RGValidation.Validate(funcionarioDto.rg))
            {
                throw new Exception("RG inválido.");
            }

            if (_context.Funcionarios.Any(funcionario => funcionario.rg == funcionarioDto.rg))
            {
                throw new Exception("RG já cadastrado.");
            }
        }
    }
}
