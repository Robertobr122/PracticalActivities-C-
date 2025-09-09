namespace NsFuncionario;

public class Funcionario
{
    public string Nome { get; set; }
    public int Horas { get; set; }
    public double ValorPorHora { get; set; }

    public Funcionario()
    {

    }
    public Funcionario(string nome, int horas, double valorPorHora)
    {
        this.Nome = nome;
        this.Horas = horas;
        this.ValorPorHora = valorPorHora;
    }

    public virtual double pagamento()
    {
        return ValorPorHora * Horas;
    }

}