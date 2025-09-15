namespace Person;

public class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }

    public Pessoa() { }
    public Pessoa(string nome, DateTime dataNascimento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
    }

    public int Idade()
    {
        var DataAtual = DateTime.Today;
        int idade = DataAtual.Year - DataNascimento.Year;
        if (DataAtual.Month < DataNascimento.Month || (DataAtual.Month == DataNascimento.Month && DataAtual.Day < DataNascimento.Day))
        {
            idade--;
        }
        return idade;
    }

    public string apresentar()
    {
        return $"Olá! meu nome é {Nome}, e eu tenho {Idade()} anos";
    }
}


