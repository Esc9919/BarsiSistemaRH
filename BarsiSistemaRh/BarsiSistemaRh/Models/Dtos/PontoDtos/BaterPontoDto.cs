namespace Barsi.Api.Models.Dtos.PontoDtos;

public class BaterPontoDto
{
    public string cpf { get; set; }
    public DateTime? pontoEntrada { get; set; }
    public DateTime? pontoAlmocoSaida { get; set; }
    public DateTime? pontoAlmocoVolta { get; set; }
    public DateTime? pontoSaida { get; set; }
    public DateTime? pontoExtra1 { get; set; }
    public DateTime? pontoExtra2 { get; set; }
}
