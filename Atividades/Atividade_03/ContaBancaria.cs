namespace Conta;

public class ContaBancaria
{
    private static int proximoNumero = 1;
    public int NumeroConta { get; }
    public string Titular { get; }
    public decimal Saldo { get; private set; }

    public ContaBancaria(string titular, decimal saldo)
    {
        if (string.IsNullOrWhiteSpace(titular))
            throw new ArgumentException("O titular não pode ser vazio");
        if (saldo < 50)
            throw new ArgumentException("O saldo deve ser maior ou igual a 50");
       
        NumeroConta = proximoNumero++;
        Titular = titular;
        Saldo = saldo;
    }

    public void Deposito(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor de deposito deve ser maior que 0");
        }
        Saldo += valor;
    }

    public void Saque(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor deve Saque deve ser positivo");
        }
        if (valor > Saldo)
        {
            throw new ArgumentException("Saldo Insuficiente");
        }
        Saldo -= valor;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nº Conta: {NumeroConta}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo:F2}");
    }


}