using System;
using System.Reflection;
using Conta;
using Microsoft.VisualBasic;

class Program
{
    static void Main(String[] args)
    {
        ContaBancaria conta = null;
        while (conta == null)
        {
            try
            {
                Console.WriteLine("\n-------------------");
                Console.WriteLine("Preencha os Dados");
                Console.WriteLine("-------------------\n");

                Console.Write("Nome Titular: ");
                string nome = Console.ReadLine();

                Console.Write("Saldo Inicial: ");
                decimal saldoInicial = decimal.Parse(Console.ReadLine());

                conta = new ContaBancaria(titular: nome, saldo: saldoInicial);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
            }
        }
        try
        {
            Console.Write("Digite o valor para depósito: ");
            decimal valorDeposito = decimal.Parse(Console.ReadLine());
            conta.Deposito(valorDeposito);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao depositar: {ex.Message}");
        }

        try
        {
            Console.Write("Digite o valor para saque: ");
            decimal valorSaque = decimal.Parse(Console.ReadLine());
            conta.Saque(valorSaque);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao sacar: {ex.Message}");
        }

        Console.WriteLine("\nDados da conta:");
        conta.ExibirDados();


    }

}