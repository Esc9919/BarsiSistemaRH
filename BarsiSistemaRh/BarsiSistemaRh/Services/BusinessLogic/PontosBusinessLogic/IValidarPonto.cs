using Barsi.Api.Models.Dtos.PontoDtos;

namespace Barsi.Api.Services.BusinessLogic.PontosBusinessLogic
{
    public interface IValidarPonto
    {
        void ValidarPonto(BaterPrimeiroPontoDto pontoDto);
    }
}
