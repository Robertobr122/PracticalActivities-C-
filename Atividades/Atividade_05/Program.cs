using System;
using NSCliente.Entities;
using NSVeiculo.Entities;
using NSReserva.Entities;
using VeiculoCarro.Entities;
using VeiculoCaminhao.Entities;
using VeiculoMoto.Entities;

class Program
{
    static void Main(string[] args)
    {
        List<Cliente> ListaCliente = new List<Cliente>();
        List<Veiculo> ListaVeiculo = new List<Veiculo>();
        List<Reserva> ListaReserva = new List<Reserva>();

        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("\n--- Locadora AlugaCar ---");
            Console.WriteLine("\nSelecione uma opção: ");
            Console.WriteLine("1) Cadastrar Cliente");
            Console.WriteLine("2) Cadastrar Veículo");
            Console.WriteLine("3) Realizar Reserva");
            Console.WriteLine("4) Sair do Sistema");
            
            int selecao;
            if (!int.TryParse(Console.ReadLine(), out selecao))
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }

            switch (selecao)
            {
                case 1:
                    Console.Clear();
                    CadastrarCliente(ListaCliente);
                    break;
                case 2:
                    Console.Clear();
                    CadastrarVeiculo(ListaVeiculo);
                    break;
                case 3:
                    Console.Clear();
                    RealizarReserva(ListaCliente, ListaVeiculo, ListaReserva);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Sistema Finalizado!");
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void CadastrarCliente(List<Cliente> ListaCliente)
    {
        try
        {
            Cliente cliente = new Cliente();
            
            Console.Write("Nome do Cliente: ");
            string nome = Console.ReadLine();
            cliente.SetNome(nome);

            Console.Write("Idade: ");
            string idade = Console.ReadLine();
            cliente.SetIdade(idade);

            Console.Write("CNH: ");
            string cnh = Console.ReadLine();
            cliente.SetCategoriaCnh(cnh);

            ListaCliente.Add(cliente);
            Console.WriteLine("\nCliente cadastrado com sucesso!");
        }
        catch (FormatException erro)
        {
            Console.Clear();
            Console.WriteLine(erro.Message);
        }
    }

    static void CadastrarVeiculo(List<Veiculo> ListaVeiculo)
    {
        try
        {
            Console.WriteLine("\nSelecione o tipo de veículo a ser cadastrado:");
            Console.WriteLine("1) Carro");
            Console.WriteLine("2) Moto");
            Console.WriteLine("3) Caminhão");
            
            int tipoVeiculo = int.Parse(Console.ReadLine());
            Veiculo novoVeiculo;

            Console.Write("Placa: ");
            string placa = Console.ReadLine();
            
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            
            Console.Write("Diária Base: ");
            string diariaBase = Console.ReadLine();

            switch (tipoVeiculo)
            {
                case 1:
                    novoVeiculo = new Carro();
                    novoVeiculo.SetPlaca(placa);
                    novoVeiculo.SetModelo(modelo);
                    novoVeiculo.SetDiariaBase(diariaBase);
                    novoVeiculo.SetCategoriaCnh("B");
                    break;
                case 2:
                    novoVeiculo = new Moto();
                    novoVeiculo.SetPlaca(placa);
                    novoVeiculo.SetModelo(modelo);
                    novoVeiculo.SetDiariaBase(diariaBase);
                    novoVeiculo.SetCategoriaCnh("A");
                    break;
                case 3:
                    novoVeiculo = new Caminhao();
                    novoVeiculo.SetPlaca(placa);
                    novoVeiculo.SetModelo(modelo);
                    novoVeiculo.SetDiariaBase(diariaBase);
                    novoVeiculo.SetCategoriaCnh("C");
                    break;
                default:
                    Console.WriteLine("Opção de veículo inválida!");
                    return;
            }

            ListaVeiculo.Add(novoVeiculo);
            Console.WriteLine("\nVeículo cadastrado com sucesso!");
        }
        catch (Exception erro)
        {
            Console.Clear();
            Console.WriteLine($"Erro: {erro.Message}");
        }
    }

    static void RealizarReserva(List<Cliente> ListaCliente, List<Veiculo> ListaVeiculo, List<Reserva> ListaReserva)
{
    if (ListaCliente.Count == 0)
    {
        Console.WriteLine("\nNão há clientes cadastrados. Cadastre um cliente primeiro.");
        return;
    }
    if (ListaVeiculo.Count == 0)
    {
        Console.WriteLine("\nNão há veículos cadastrados. Cadastre um veículo primeiro.");
        return;
    }

    try
    {
        Console.WriteLine("\n--- Realizar Reserva ---");
        
        Console.WriteLine("\nClientes disponíveis:");
        for (int i = 0; i < ListaCliente.Count; i++)
        {
            var cliente = ListaCliente[i];
            Console.WriteLine($"{i + 1}) Nome: {cliente.Nome} | CNH: {cliente.CategoriaCnh} | Idade: {cliente.Idade}");
        }

        Console.Write("\nSelecione o número do cliente: ");
        if (!int.TryParse(Console.ReadLine(), out int clienteIndex) || clienteIndex < 1 || clienteIndex > ListaCliente.Count)
        {
            throw new ArgumentException("Seleção de cliente inválida!");
        }
        Cliente clienteSelecionado = ListaCliente[clienteIndex - 1];

        Console.WriteLine("\nVeículos disponíveis:");
        for (int i = 0; i < ListaVeiculo.Count; i++)
        {
            var veiculo = ListaVeiculo[i];
            Console.WriteLine($"{i + 1}) Modelo: {veiculo.Modelo} | Placa: {veiculo.Placa} | CNH Necessária: {veiculo.TipoCategoriaCnh}");
        }

        Console.Write("\nSelecione o número do veículo: ");
        if (!int.TryParse(Console.ReadLine(), out int veiculoIndex) || veiculoIndex < 1 || veiculoIndex > ListaVeiculo.Count)
        {
            throw new ArgumentException("Seleção de veículo inválida!");
        }
        Veiculo veiculoSelecionado = ListaVeiculo[veiculoIndex - 1];

        if (!clienteSelecionado.CategoriaCnh.Equals(veiculoSelecionado.TipoCategoriaCnh, StringComparison.OrdinalIgnoreCase))
        {
            throw new ArgumentException($"Cliente não possui CNH adequada para este veículo. CNH necessária: {veiculoSelecionado.TipoCategoriaCnh}");
        }

        Console.Write("\nData de Início (dd/mm/aaaa): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataInicio))
        {
            throw new ArgumentException("Data de início inválida!");
        }

        Console.Write("Data de Fim (dd/mm/aaaa): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime dataFim))
        {
            throw new ArgumentException("Data de fim inválida!");
        }

        Console.Write("\nCondutor adicional? (S/N): ");
        bool condutorAdicional = Console.ReadLine()?.Trim().ToUpper() == "S";

        Console.Write("\nQuilometragem inicial: ");
        if (!int.TryParse(Console.ReadLine(), out int kmInicial))
        {
            throw new ArgumentException("Quilometragem inválida!");
        }

        var reserva = new Reserva(clienteSelecionado, veiculoSelecionado, dataInicio, dataFim, condutorAdicional, kmInicial);
        var erros = reserva.Validar();
        
        if (erros.Any())
        {
            throw new ArgumentException($"Erros na reserva:\n{string.Join("\n", erros)}");
        }

        reserva.Confirmar();
        ListaReserva.Add(reserva);

        Console.WriteLine("\nReserva realizada com sucesso!");
        Console.WriteLine($"Valor total: R$ {reserva.CalcularValor(false):F2}");
        Console.WriteLine($"Valor total com seguro: R$ {reserva.CalcularValor(true):F2}");
    }
    catch (Exception erro)
    {
        Console.WriteLine($"\nErro ao realizar reserva: {erro.Message}");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
}