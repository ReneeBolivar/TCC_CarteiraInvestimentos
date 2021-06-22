using System;
using System.Collections.Generic;
using System.Linq;
using TCC_CarteiraInvestimento.AlgoritmoGenetico;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Utils
{
    public static class ZScore
    {
        public static void GerarTabelaBalanceamento()
        {
            List<(string codEmpresa, decimal valor, decimal score)> ObterValores(int ano, int tri)
            {
                GestorConfiguracao.AnoTreinamento = ano;
                GestorConfiguracao.TrimestreTreinamento = tri;
                Console.WriteLine($"Gerando população do ano {ano} trimestre {tri}..");
                AG.GerarPopulacaoInicial();

                return CalcularBalanceamento(ano, tri);
            }

            for (int a = 2017; a <= 2018; a++) //Anos
                for (int t = 1; t <= 4; t++) //Trimestres
                {
                    var c2017_1 = ObterValores(a, t);
                    Excel.InicializarArquivo();
                    Excel.ExportarZScore($"Ano_{a}_Trimestre_{t}", c2017_1);
                }

            Excel.LiberarRecursos();
        }

        private static List<(string codEmpresa, decimal valor, decimal score)> CalcularBalanceamento(int ano, int trismestre)
        {
            var dados = GestorEntidades.CromossomosDisponiveis
                                       .Where(x => x.Periodo.Ano == ano && x.Periodo.Trimestre == trismestre)
                                       .Select(x =>
                                        new ValueTuple<string, decimal>
                                           (x.Empresa.Codigo,
                                            x.Empresa.PrecoAtivoNoPeriodo
                                                                 .Where(y => y.Item1.Ano == ano && y.Item1.Trimestre == trismestre)
                                                                 .Select(z => z.Item2)
                                                                 .SingleOrDefault())
                                       )
                                       .ToList();

            return ZScore.Calcular(dados);
        }

        private static List<(string codEmpresa, decimal valor, decimal zscore)> Calcular(List<ValueTuple<string , decimal>> dados)
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
