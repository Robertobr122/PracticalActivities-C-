using System.Text.RegularExpressions;

namespace NSCliente.Entities;

public class Cliente
{
    public string Nome { get; private set; }
    public int Idade { get; private set; }
    public string CategoriaCnh { get; private set; }

    public Cliente()
    {

    }

    public Cliente(string nome, int idade, string categoriaCnh)
    {


        this.Nome = nome;
        this.Idade = idade;
        this.CategoriaCnh = categoriaCnh;
    }

    public void SetNome(string nome)
{
    if (string.IsNullOrWhiteSpace(nome))
    {
        throw new FormatException("ERRO: O nome não pode ser vazio.");
    }

    if (!Regex.IsMatch(nome, @"^[aA-zZ\s]+$"))
    {
        throw new FormatException("ERRO: O nome deve conter apenas letras");
    }
    Nome = nome; 
}


    public void SetIdade(string idade)
{
    try
    {
        int IdadeFormatada = int.Parse(idade);
        if (IdadeFormatada <= 21)
        {
            throw new ArgumentException("ERRO: A idade deve ser maior ou igual a 21 anos");
        }
        Idade = IdadeFormatada; 
    }
        catch (Exception erro)
        {
            if (erro is ArgumentException)
            {
                throw new FormatException(erro.Message);
            }
            throw new FormatException("ERRO: A idade não pode ser vazia e deve ser um número.");

        }
    }

    public void SetCategoriaCnh(string categoriaCnh)
{
    if (string.IsNullOrWhiteSpace(categoriaCnh) || !Regex.IsMatch(categoriaCnh, @"^[aA-cC]+$"))
    {
        throw new FormatException("Erro: A CNH deve ser A, B, ou C");
    }
    CategoriaCnh = categoriaCnh.ToUpper(); // Adicionar esta linha
}
}