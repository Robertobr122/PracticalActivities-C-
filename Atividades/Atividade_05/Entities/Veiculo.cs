using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace NSVeiculo.Entities;

public abstract class Veiculo
{
    public string Placa { get; private set; }
    public string Modelo { get; private set; }
    public decimal DiariaBase { get; private set; }
    public string TipoCategoriaCnh { get; private set; }



    public Veiculo()
    { }
public virtual void SetCategoriaCnh(string tipoCategoriaCnh)
{
    if (string.IsNullOrWhiteSpace(tipoCategoriaCnh))
    {
        throw new FormatException("Erro: A CNH não pode ser vazia");
    }
    TipoCategoriaCnh = tipoCategoriaCnh.ToUpper(); // Adicionar esta linha
}

   public void SetPlaca(string placa)
{
    if (string.IsNullOrWhiteSpace(placa) || !Regex.IsMatch(placa, @"^[aA-zZ-Z0-9]+$"))
    {
        throw new FormatException("ERRO: O valor deve conter apenas letras e numeros e não pode ser nulo.");
    }
    Placa = placa.ToUpper(); 
}
    public void SetModelo(string modelo)
{
    if (string.IsNullOrWhiteSpace(modelo) || !Regex.IsMatch(modelo, @"^[aA-zZ-Z0-9\s]+$"))
    {
        throw new FormatException("ERRO: O valor deve conter apenas letras e numeros e não pode ser nulo.");
    }
    Modelo = modelo; 
}

     public void SetDiariaBase(string diariaBase)
    {
        try
        {
            this.DiariaBase = decimal.Parse(diariaBase);
        }
        catch (Exception)
        {
            throw new FormatException("ERRO: O valor da diária base deve ser um número válido.");
        }
    }


    public virtual decimal CalcularDiaria(string dias, string diariaBase)
    {
        try
        {
            int diasFormatados = int.Parse(dias);
            decimal diariaBaseFormatada = decimal.Parse(diariaBase);

            if (diasFormatados <= 0)
                throw new ArgumentException("ERRO: O valor de dias não pode ser menor ou igual a 0");
            if (diariaBaseFormatada <= 0)
                throw new ArgumentException("ERRO: O valor da diária não pode ser menor ou igual a 0");

            return diasFormatados * diariaBaseFormatada;
        }
        catch (Exception)
        {
            throw new FormatException("ERRO: Os valores de dias e diária devem ser números válidos e maiores que zero.");
        }
    }

}