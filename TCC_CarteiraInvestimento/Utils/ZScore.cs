using System;
using System.Collections.Generic;
using System.Linq;

namespace TCC_CarteiraInvestimento.Utils
{
    public static class ZScore
    {
        public static List<(string codEmpresa, decimal valor, decimal zscore)> Calcular(List<ValueTuple<string , decimal>> dados)
        {
            var result = new List<(string codEmpresa, decimal valor, decimal zscore)>();

            var valores = dados.Select(x => x.Item2).ToList();
            var media = CalcularMedia(valores);
            var desvioPadrao = CalcularDesvioPadrao(valores);

            foreach(var valor in dados)
            {
                var zscore = ObterZScore(media, desvioPadrao, valor.Item2);
                result.Add((valor.Item1, valor.Item2, zscore));
            }

            return result;
        }

        private static decimal ObterZScore(decimal media, decimal desvioPadrao, decimal valorTeste)
            => (valorTeste - media) / desvioPadrao;

        private static decimal CalcularMedia(List<decimal> valores)
            => valores.Sum() / valores.Count;

        private static decimal CalcularDesvioPadrao(List<decimal> valores)
        {
            var step1 = valores.Sum();
            var step2 = step1 * step1;
            var step3 = step2 / valores.Count;
            var step4 = valores.Sum(x => x * x);
            var step5 = step4 - step3;
            var step6 = valores.Count - 1;
            var step7 = step5 / step6;

            return (decimal)Math.Sqrt((double)step7);
        }
    }
}
