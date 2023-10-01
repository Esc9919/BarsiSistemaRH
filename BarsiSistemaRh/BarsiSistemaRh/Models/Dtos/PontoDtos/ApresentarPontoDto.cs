namespace Barsi.Api.Models.Dtos.PontoDtos;

public class ApresentarPontoDto
{
    public string nome { get; set; }
    public DateTime? pontoEntrada { get; set; } = DateTime.Now;
    public DateTime? pontoAlmocoSaida { get; set; } = DateTime.Now;
    public DateTime? pontoAlmocoVolta { get; set; } = DateTime.Now;
    public DateTime? pontoSaida { get; set; } = DateTime.Now;
}
