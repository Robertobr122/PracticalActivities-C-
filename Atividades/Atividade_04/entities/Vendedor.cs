
using SCFuncinario;

namespace FuncionarioVendedor;

public class Vendedor : Funcionario
{
    public decimal Comissao { get; set; }

    public Vendedor(string nome, decimal comissao) : base(nome)
    {
        this.Comissao = comissao;
    }

    
    public override decimal CalcularSalario()
    {
        return SalarioBase + Comissao;
    }
}
