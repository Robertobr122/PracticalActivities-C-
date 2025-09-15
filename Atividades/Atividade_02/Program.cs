using System;
using Person;

class Program
{
    static void Main(String[] args)
    {
        Console.Write("\nNome:");
        string nome = Console.ReadLine();

        Console.Write("Data de Nascimento:");
        DateTime idade = DateTime.Parse(Console.ReadLine());

        Pessoa pessoaUm = new Pessoa(nome: nome, dataNascimento: idade);

        Console.WriteLine("\n-------------------------------------\n");
        Console.WriteLine($"MENSAGEM DE {nome}: " + pessoaUm.apresentar());
        Console.WriteLine("\n-------------------------------------\n");


    }
}