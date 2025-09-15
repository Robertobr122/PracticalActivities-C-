using NSVeiculo.Entities;
using System.Text.RegularExpressions;
namespace VeiculoCarro.Entities;

public class Carro : Veiculo
{

    public Carro()
    {
        
    }

   public override void SetCategoriaCnh(string TipoCategoriaCnh)
    {
        base.SetCategoriaCnh(TipoCategoriaCnh);
        if (!Regex.IsMatch(TipoCategoriaCnh, @"^[bBcC]+$"))
        {
            throw new FormatException("Erro: A CNH deve ser do tipo B ou C para carros");
        }
    }

    public override decimal CalcularDiaria(string dias, string diariaBase)
    {
        int diasFormatados = int.Parse(dias);
        decimal diariaBaseFormatada = decimal.Parse(diariaBase);

        if (diasFormatados <= 0)
            throw new ArgumentException("ERRO: O valor de dias não pode ser menor ou igual a 0");
        if (diariaBaseFormatada <= 0)
            throw new ArgumentException("ERRO: O valor da diária não pode ser menor ou igual a 0");

        decimal total = diasFormatados * diariaBaseFormatada;

        if (diasFormatados >= 10)
        {
            total *= 0.90m;
        }
        if (diasFormatados >= 5)
        {
            total *= 0.95m;
        }
        return total;
    }


}

