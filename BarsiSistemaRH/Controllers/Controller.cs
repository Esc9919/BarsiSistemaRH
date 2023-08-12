using BarsiSistemaRH.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarsiSistemaRH.Controllers
{
    [Route("barsi")]
    [ApiController]
    public class Controller : ControllerBase
    {


        private static List<Funcionario> funcionarios = new List<Funcionario>{
            new Funcionario{
                idFuncionario = 1,
                nome = "Emerson",

            },
            new Funcionario{
                idFuncionario = 2,
                nome = "Carlos",

            }
        };

        [HttpGet("/todos-funcionarios")]
        public async Task<ActionResult<List<Funcionario>>> GetAllFuncionarios()
        {

            return Ok(funcionarios);
        }

        [HttpGet("/funcionario-por-id")]
        public async Task<ActionResult<Funcionario>> GetFuncionario(int id)
        {
            var funcionario = funcionarios.Find(x => x.idFuncionario == id);
            if (funcionario == null)
            {
                return NotFound("Desculpa, esse funcionario não existe!");
            }
            return Ok(funcionario);
        }

        [HttpPost("/inserir-funcionario")]
        public async Task<ActionResult<List<Funcionario>>> AddFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);

            return Ok(funcionarios);
        }

        [HttpPut("/atualizar-funcionario-por-id")]
        public async Task<ActionResult<List<Funcionario>>> UpdateFuncionario(int id,Funcionario request)
        {
            var funcionario = funcionarios.Find(x => x.idFuncionario == id);
            if (funcionario == null)
            {
                return NotFound("Desculpa, esse funcionario não existe!");
            }

            funcionario.nome = request.nome;

            return Ok(funcionarios);
        }

        [HttpDelete("/deleta-funcionario-por-id")]
        public async Task<ActionResult<List<Funcionario>>> DeleteFuncionario(int id)
        {
            var funcionario = funcionarios.Find(x => x.idFuncionario == id);
            if (funcionario == null)
            {
                return NotFound("Desculpa, esse funcionario não existe!");
            }

            funcionarios.Remove(funcionario);

            return Ok(funcionarios);
        }

    }
}
