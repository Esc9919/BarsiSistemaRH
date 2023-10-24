using System;
using System.Collections.Generic;
using System.Linq;
using Barsi.Api.Models;
using Barsi.Api.Models.Dtos.FuncionarioDtos;
using DocumentValidator;

namespace Barsi.Api.Services.BusinessLogic.FuncionarioBusinessLogic;

public class ValidarCpf : IValidarFuncionario
{
    private readonly FuncionarioContext _context;

    public ValidarCpf(FuncionarioContext context)
    {
        _context = context;
    }

    public void ValidarFuncionario(AdicionarFuncionarioDto funcionarioDto)
    {
        if (!CpfValidation.Validate(funcionarioDto.cpf))
        {
            throw new Exception("CPF inválido.");
        }

        if (_context.Funcionarios.Any(funcionario => funcionario.cpf == funcionarioDto.cpf))
        {
            throw new Exception("CPF já cadastrado.");
        }
    }
}
