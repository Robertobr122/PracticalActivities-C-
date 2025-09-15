using System;
using SCFuncinario;
using FuncionarioGerente;
using FuncionarioVendedor;


class Program
{
    static void Main(String[] args)
    {
        MenuPrincipal();
    }
    public static void MenuPrincipal()
    {
        bool continuarPrograma = true;
        do
        {
            try
            {
                Console.WriteLine("--- Cadastro Funcionarios ---");
                Console.WriteLine("1) Cadastrar funcionario");
                Console.WriteLine("2) Encerrar Programa");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Digite sua escolha:");

                int entrada = int.Parse(Console.ReadLine());
                switch (entrada)
                {
                    case 1:
                        CadastrarFuncionario();
                        break;
                    case 2:
                        continuarPrograma = false;
                        Console.Clear();
                        Console.WriteLine("Programa Encerrado!");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nValor Inválido! Tente Novamente.\n");

                        break;
                }

            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Erro: {ex.Message}");
            }
        } while (continuarPrograma);
    }

    public static void CadastrarFuncionario()
    {
        Console.Clear();
        Console.Write("Digite o Nome: ");
        string nome = Console.ReadLine();

        try
        {
            Console.Write("Digite o salário: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal salario))
            {
                Console.WriteLine("Entrada de salário inválida. Por favor, digite um número.");
                return;
            }

            Console.WriteLine("Escolha o tipo de funcionário:");
            Console.WriteLine("1) Gerente");
            Console.WriteLine("2) Vendedor");
            Console.WriteLine("3) Comum");
            Console.Write("Opção: ");

            if (!int.TryParse(Console.ReadLine(), out int tipoFuncionario))
            {
                Console.WriteLine("Opção de tipo de funcionário inválida.");
                return;
            }

            Funcionario funcionario = null;

            switch (tipoFuncionario)
            {
                case 1:
                    Console.Write("Digite o bônus do gerente: ");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal bonus))
                    {
                        Console.WriteLine("Entrada de bônus inválida. Por favor, digite um número.");
                        return;
                    }
                    funcionario = new Gerente(nome, bonus);
                    break;
                case 2:
                    Console.Write("Digite a comissão do vendedor: ");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal comissao))
                    {
                        Console.WriteLine("Entrada de comissão inválida. Por favor, digite um número.");
                        return;
                    }
                    funcionario = new Vendedor(nome, comissao);
                    break;
                case 3:
                    funcionario = new Funcionario(nome);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }

            funcionario.adicionarSalario(salario);
            Console.WriteLine(funcionario.ExibirDados());
            Console.WriteLine($"Salário Calculado: R${funcionario.CalcularSalario():F2}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nErro de validação: {ex.Message}\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nOcorreu um erro inesperado: {ex.Message}\n");
        }
    }
}
