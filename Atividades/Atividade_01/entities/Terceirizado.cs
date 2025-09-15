using NsFuncionario;

namespace FuncionarioTerceirizado;

public class Terceirizado : Funcionario
{
     public double DespesasAdicionais { get; set; }

    public Terceirizado(string nome, int horas, double valorPorHora, double despesasAdicionais)
    : base(nome, horas, valorPorHora)
    {
        this.DespesasAdicionais = despesasAdicionais;
    }

    public sealed override double pagamento()
    {
        return base.pagamento() + DespesasAdicionais * 1.1;
    }

}