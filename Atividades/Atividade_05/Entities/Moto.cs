using NSVeiculo.Entities;
using System.Text.RegularExpressions;
namespace VeiculoMoto.Entities;

public class Moto : Veiculo
{

    public Moto()
    {
    }

   public override void SetCategoriaCnh(string TipoCategoriaCnh)
    {
        base.SetCategoriaCnh(TipoCategoriaCnh);
        if (!Regex.IsMatch(TipoCategoriaCnh, @"^[aA]+$"))
        {
            throw new FormatException("Erro: A CNH deve ser do tipo A para motos");
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

        return total *= 0.85m;
    }


}

