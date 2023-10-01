using AutoMapper;
using Barsi.Api.Models.Dtos.FuncionarioDtos;
using Barsi.Api.Services.BusinessLogic;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barsi.Api.Services.FuncionarioService
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly FuncionarioContext _context;
        private readonly IMapper _mapper;
        private readonly IValidarFuncionario _validarFuncionario;

        public FuncionarioService(FuncionarioContext context, IMapper mapper, IValidarFuncionario validarFuncionario)
        {
            _context = context;
            _mapper = mapper;
            _validarFuncionario = validarFuncionario;
        }

        public async Task<Funcionario?> AdicionarFuncionario([FromBody] AdicionarFuncionarioDto funcionarioDto)
        {
            Funcionario funcionario = _mapper.Map<Funcionario>(funcionarioDto);
            _validarFuncionario.ValidarFuncionario(funcionarioDto);
            _context.Funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();

            return funcionario;
        }



        public async Task<IEnumerable<ListarFuncionarioDto>> ListarFuncionarios([FromQuery] int skip = 0, [FromQuery] int take = 20)
        {
            return _mapper.Map<List<ListarFuncionarioDto>>(_context.Funcionarios.Skip(skip).Take(take));
        }

        public async Task<IActionResult> ListarFuncionarioPorId(int id)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(funcionario => funcionario.idFuncionario == id);
            if (funcionario is null)
            {
                return new NotFoundObjectResult("Esse funcionário não existe");
            }

            var funcionarioDto = _mapper.Map<ListarFuncionarioDto>(funcionario);

            return new OkObjectResult(funcionarioDto);
        }

        public async Task<IActionResult> AlterarFuncionario(int id, [FromBody] AlterarFuncionarioDto alterarFuncionarioDto)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(funcionario => funcionario.idFuncionario == id);

            if (funcionario == null)
            {
                return new NotFoundObjectResult("Funcionario não existe");
            }
            _mapper.Map(alterarFuncionarioDto, funcionario);
            _context.SaveChanges();
            return new NoContentResult();
        }

        

        public async Task<IActionResult> DeletarFuncionario(int id)
        {
            var funcionario = _context.Funcionarios.FirstOrDefault(funcionario => funcionario.idFuncionario == id);

            if (funcionario == null)
            {
                return new NotFoundObjectResult("Funcionario não existe");
            }

            _context.Remove(funcionario);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
