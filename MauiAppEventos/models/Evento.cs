public class Evento
{
    public string Nome { get; set; }
    public string Local { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataTermino { get; set; }
    public int? NumeroParticipantes { get; set; } 
    public double? CustoPorParticipante { get; set; }

    public int GetDuracaoDias()
    {
        return (DataTermino - DataInicio).Days;
    }

    public double CustoTotal =>
        (NumeroParticipantes ?? 0) * (CustoPorParticipante ?? 0);

    public int DuracaoDias
    {
        get
        {
            // Ajustando a DataTermino para o final do dia
            DateTime dataTerminoAjustada = DataTermino.Date.AddDays(1).AddTicks(-1);
            return (dataTerminoAjustada - DataInicio.Date).Days;
        }
    }

}


