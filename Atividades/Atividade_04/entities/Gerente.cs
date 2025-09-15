
using SCFuncinario;

namespace FuncionarioGerente;

public class Gerente : Funcionario
{
    public decimal Bonus { get; set; }
    public Gerente(string nome, decimal bonus) : base(nome)
    {
        this.Bonus = bonus;
    }

    public override decimal CalcularSalario()
    {
        return SalarioBase + Bonus;
    }

}
