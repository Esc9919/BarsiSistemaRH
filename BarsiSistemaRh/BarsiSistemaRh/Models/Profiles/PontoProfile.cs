using AutoMapper;
using Barsi.Api.Models.Dtos.PontoDtos;

namespace Barsi.Api.Models.Profiles;

public class PontoProfile : Profile
{
    public PontoProfile() 
    {
        CreateMap<BaterPontoDto, Ponto>();
        CreateMap<AdicionarUsuarioPontoDto, Ponto>();
        CreateMap<Ponto, ApresentarPontoDto>();
        CreateMap<AlterarPontoDto, Ponto>();

    }
}
