using AutoMapper;
using Barsi.Api.Models.Dtos.PontoDtos;

namespace Barsi.Api.Models.Profiles;

public class PontoProfile : Profile
{
    public PontoProfile() 
    {
        CreateMap<BaterPrimeiroPontoDto, Ponto>();
        CreateMap<AdicionarUsuarioPontoDto, Ponto>();
        CreateMap<Ponto, ApresentarPontoDto>();
        CreateMap<BaterPontoDto, Ponto>();

    }
}
