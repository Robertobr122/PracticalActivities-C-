namespace VeiculoCaminhao.Entities;

using NSVeiculo.Entities;
using System.Text.RegularExpressions;


public class Caminhao : Veiculo
{
    public Caminhao()
    {
    }

    public override void SetCategoriaCnh(string TipoCategoriaCnh)
    {
        base.SetCategoriaCnh(TipoCategoriaCnh);
        if (!Regex.IsMatch(TipoCategoriaCnh, @"^[cC]+$"))
        {
            throw new FormatException("Erro: A CNH deve ser do tipo C para caminhões");
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

        return total + 150;
    }

}
