namespace Barsi.Api.Models.Dtos.PontoDtos;

public class AlterarPontoDto
{
    public DateTime? pontoEntrada { get; set; } = DateTime.Now;
    public DateTime? pontoAlmocoSaida { get; set; } = DateTime.Now;
    public DateTime? pontoAlmocoVolta { get; set; } = DateTime.Now;
    public DateTime? pontoSaida { get; set; } = DateTime.Now;
    public DateTime? pontoExtra1 { get; set; } = DateTime.Now;
    public DateTime? pontoExtra2 { get; set; } = DateTime.Now;
}
