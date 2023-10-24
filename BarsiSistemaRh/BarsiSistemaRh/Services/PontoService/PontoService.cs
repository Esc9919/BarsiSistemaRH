using AutoMapper;
using Barsi.Api.Models;
using Barsi.Api.Models.Dtos.PontoDtos;
using BarsiSistemaRh.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;



namespace Barsi.Api.Services.PontoService;

public class PontoService : IPontoService
{
    private readonly FuncionarioContext _context;
    private readonly IMapper _mapper;

    public PontoService(FuncionarioContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> BaterPonto(string cpf)
    {
        try
        {
            // Verificar se os horários já foram registrados para este CPF
            var pontosExistentes = _context.Pontos
                .Where(p => p.cpf == cpf)
                .ToList();

            if (pontosExistentes.Any())
            {
                return new BadRequestObjectResult("Os pontos já foram registrados para este CPF.");
            }

            // Obter a hora atual
            DateTime horaAtual = DateTime.Now;

            // Aqui você pode mapear os horários para a entidade Ponto
            var pontos = new List<Ponto>
        {
            new Ponto
            {
                cpf = cpf,
                pontoEntrada = horaAtual
            },
            new Ponto
            {
                cpf = cpf,
                pontoAlmocoSaida = horaAtual
            },
            new Ponto
            {
                cpf = cpf,
                pontoAlmocoVolta = horaAtual
            },
            new Ponto
            {
                cpf = cpf,
                pontoSaida = horaAtual
            }
        };

            // Adicione os pontos ao contexto do banco de dados e salve as mudanças
            _context.Pontos.AddRange(pontos);
            await _context.SaveChangesAsync();

            return new ObjectResult("Quatro pontos registrados com sucesso!")
            {
                StatusCode = 200 // OK
            };
        }
        catch (Exception ex)
        {
            return new ObjectResult($"Ocorreu um erro: {ex.Message}")
            {
                StatusCode = 500 // Internal Server Error
            };
        }
    }


}
