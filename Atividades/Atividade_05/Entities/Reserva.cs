using NSCliente.Entities;
using NSVeiculo.Entities;

namespace NSReserva.Entities;

public class Reserva
{
    public Cliente Cliente { get; private set; }
    public Veiculo Veiculo { get; private set; }
    public DateTime DataInicio { get; private set; }
    public DateTime DataFim { get; private set; }
    public bool CondutorAdicional { get; private set; }
    public int QuilometragemInicial { get; private set; }
    public int? QuilometragemFinal { get; private set; }
    public string Status { get; private set; }

    public Reserva(Cliente cliente, Veiculo veiculo, DateTime dataInicio, DateTime dataFim, bool condutorAdicional, int quilometragemInicial)
    {
        Cliente = cliente;
        Veiculo = veiculo;
        DataInicio = dataInicio;
        DataFim = dataFim;
        CondutorAdicional = condutorAdicional;
        QuilometragemInicial = quilometragemInicial;
        Status = "Pendente";
    }

    public int Dias()
    {
        return (int)Math.Ceiling((DataFim - DataInicio).TotalDays);
    }

    public List<string> Validar()
    {
        var erros = new List<string>();

        if (DataFim <= DataInicio)
        {
            erros.Add("A data final da reserva deve ser posterior à data de início.");
        }

        if (Dias() < 1 || Dias() > 30)
        {
            erros.Add("O período de aluguel deve ser entre 1 e 30 dias.");
        }

        if (Cliente.Idade < 25)
        {
            erros.Add("O cliente deve ter 25 anos ou mais para fazer a locação.");
        }

        return erros;
    }

    public void Confirmar()
    {
        if (Validar().Count == 0 && Status == "Pendente")
        {
            Status = "Confirmada";
        }
        else
        {
            throw new InvalidOperationException("Não é possível confirmar a reserva. Verifique a validação.");
        }
    }

    public void Cancelar(DateTime agora)
    {
        if (Status == "Confirmada" && agora < DataInicio.AddDays(-1))
        {
            Status = "Cancelada";
        }
        else
        {
            throw new InvalidOperationException("Não é possível cancelar a reserva neste momento.");
        }
    }

    public void Finalizar(int quilometragemFinal)
    {
        if (Status == "Confirmada")
        {
            QuilometragemFinal = quilometragemFinal;
            Status = "Finalizada";
        }
        else
        {
            throw new InvalidOperationException("Não é possível finalizar uma reserva que não está confirmada.");
        }
    }

    public decimal CalcularValor(bool incluirSeguroOpcional)
{
    decimal valorBase = Veiculo.CalcularDiaria(Dias().ToString(), Veiculo.DiariaBase.ToString());
    
    if (incluirSeguroOpcional)
        valorBase *= 1.1m;

    if (CondutorAdicional)
        valorBase *= 1.05m; 

    return valorBase;
}
}