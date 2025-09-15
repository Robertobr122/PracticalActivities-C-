using System.Xml;
using System.Text.RegularExpressions;

namespace SCFuncinario;

public class Funcionario
{
    public string Nome { get; set; }
    public decimal SalarioBase { get; protected set; }

    public Funcionario()
    {
    }
    public Funcionario(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome) || !Regex.IsMatch(nome, @"^[a-zA-Z\s]+$"))
        {
            throw new ArgumentException("Erro: O nome deve ser válido.");
        }
        this.Nome = nome;
    }


    public void adicionarSalario(decimal valor)
    {
        if (valor < 1200)
        {
            throw new ArgumentException("Erro: Salario base deve ser maior que 1200");
        }
        SalarioBase += valor;
    }

    public virtual decimal CalcularSalario()
    {
        return SalarioBase;
    }

    public string ExibirDados()
    {
        return $"Nome: {Nome}\nSalária: R${SalarioBase:F2}";
    }


}
