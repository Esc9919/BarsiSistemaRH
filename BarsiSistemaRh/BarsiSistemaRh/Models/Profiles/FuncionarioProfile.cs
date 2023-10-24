using AutoMapper;
using Barsi.Api.Models.Dtos.FuncionarioDtos;

namespace BarsiSistemaRh.Models.Profiles;

public class FuncionarioProfile : Profile
{
    public FuncionarioProfile()
    {
        CreateMap<AdicionarFuncionarioDto, Funcionario>();
        CreateMap<AlterarFuncionarioDto, Funcionario>();
        CreateMap<Funcionario, AlterarFuncionarioDto>();
        CreateMap<Funcionario, ListarFuncionarioDto>();
        CreateMap<Funcionario, LoginDto>();
        CreateMap<FeriasDTO, Funcionario>();
    }
}
