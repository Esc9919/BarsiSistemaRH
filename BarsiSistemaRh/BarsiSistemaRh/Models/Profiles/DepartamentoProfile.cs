using AutoMapper;
using Barsi.Api.Models.Dtos.DepartamentoDtos;

namespace Barsi.Api.Models.Profiles
{
    public class DepartamentoProfile : Profile
    {
        public DepartamentoProfile()
        {
            CreateMap<AdicionarDepartamentoDto, Departamento>();
            CreateMap<Departamento, ApresentarDepartamentoDto>();
            CreateMap<AlterarDepartamentoDto, Departamento>();

        }
    }
}
