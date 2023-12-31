﻿using AutoMapper;
using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barsi.Api.Services.FeriasService;

public class FeriasService : IFeriasService
{
    private readonly FuncionarioContext _context;

    public FeriasService(FuncionarioContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> TirarFerias(int id, DateTime inicioFerias, DateTime fimFerias)
    {
        var funcionario = _context.Funcionarios.FirstOrDefault(funcionario => funcionario.idFuncionario == id);

        if (funcionario is null)
        {
            return new NotFoundObjectResult("Esse funcionário não existe");
        }

        var dataAdmissao = funcionario.dataAdmissao;
        var hoje = DateTime.Now;

        TimeSpan diferencaAdmissao = inicioFerias - dataAdmissao;
        TimeSpan diferencaFerias = fimFerias - inicioFerias;

        var dataLimiteFerias = hoje.AddMonths(-12);
        if (funcionario.inicioFerias.HasValue && funcionario.inicioFerias >= dataLimiteFerias)
        {
            return new UnauthorizedObjectResult("O funcionário já tirou férias nos últimos 12 meses");
        }

        if (diferencaAdmissao.TotalDays <= 730)
        {
            if (diferencaAdmissao.TotalDays >= 365)
            {
                if (diferencaFerias.TotalDays <= 30)
                {
                    funcionario.inicioFerias = inicioFerias;
                    funcionario.fimFerias = fimFerias;
                    _context.Funcionarios.Update(funcionario);
                    await _context.SaveChangesAsync();
                    return new OkObjectResult("As férias do funcionário foram aceitas");
                }
                else
                {
                    return new UnauthorizedObjectResult("Não é permitido tirar férias com mais de 30 dias");
                }
            }
            else
            {
                return new UnauthorizedObjectResult("O funcionário tem menos de 12 meses na empresa");
            }
        }
        else
        {
            return new UnauthorizedObjectResult("O funcionário não pode tirar ferias após 24 meses");
        }
    }

}
