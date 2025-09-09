using System;
using System.Globalization;
using NsFuncionario;
using FuncionarioTerceirizado;
class Program
{
    static void Main(String[] arga)
    {
        List<Funcionario> listaFuncionario = new List<Funcionario>();

        Console.Write("Quantidade de funcionarios: ");
        int numFuncionarios = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numFuncionarios; i++)
        {
            Console.WriteLine($"Dados do Funcionario #0{i}: ");
            Console.Write("Terceirizado (s/n): ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Horas trabalhada: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Valor por Hora: ");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ch == 's')
            {
                Console.WriteLine("Qual o valor das despesas: ");
                double valorDespesas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaFuncionario.Add(new Terceirizado(nome, horas, valorPorHora, valorDespesas));
            }
            else
            {
                listaFuncionario.Add(new Funcionario(nome, horas, valorPorHora));
            }

        }
        
            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");
            foreach (Funcionario emp in listaFuncionario)
            {
                Console.WriteLine(emp.Nome + " - R$ " + emp.pagamento().ToString("F2"));
            }


    }
}
