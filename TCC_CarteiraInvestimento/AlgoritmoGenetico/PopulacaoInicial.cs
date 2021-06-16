using System.Collections.Generic;
using System.Linq;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;
using TCC_CarteiraInvestimento.Utils;

namespace TCC_CarteiraInvestimento.AlgoritmoGenetico
{
    public static partial class AG
    {
        public static void GerarPopulacaoInicial()
        {
            GestorEntidades.CromossomosDisponiveis = GestorCargas
                                                        .Cromossomos
                                                        .Where(x => x.Periodo.Ano == GestorConfiguracao.AnoTreinamento &&
                                                                    x.Periodo.Trimestre == GestorConfiguracao.TrimestreTreinamento)
                                                        .ToList();

            GestorEntidades.Populacao = new Populacao();

            int individuosGerados = GerarIndividuosSequenciais();

            for (int i = 0; i < GestorConfiguracao.IndividuosNaPopulacao - individuosGerados; i++)
            {
                GestorEntidades.Populacao.Individuos.Add(new Individuo()
                {
                    Cromossomos = ObterCromossomos()
                });
            }
        }

        private static int GerarIndividuosSequenciais()
        {
            var cromossomos = new List<Cromossomo>();

            foreach (var cromossomo in GestorEntidades.CromossomosDisponiveis)
            {
                cromossomos.Add(cromossomo);

                if(cromossomos.Count == GestorConfiguracao.CromossomosPorIndividuos)
                {
                    GestorEntidades.Populacao.Individuos.Add(new Individuo()
                    {
                        Cromossomos = cromossomos
                    });

                    cromossomos.Clear();
                }  
            }

            if(cromossomos.Count != 0) // Lista não foi limpa por não estar completa
                for (int i = cromossomos.Count; i < GestorConfiguracao.CromossomosPorIndividuos; i++)
                    cromossomos.Add(ObterCromossomoAleatorio());

            return GestorEntidades.Populacao.Individuos.Count;
        }

        private static List<Cromossomo> ObterCromossomos()
        {
            var list = new List<Cromossomo>();

            for (int i = 0; i < GestorConfiguracao.CromossomosPorIndividuos; i++)
                list.Add(ObterCromossomoAleatorio());
            
            return list;
        }

        private static Cromossomo ObterCromossomoAleatorio()
        {
            var rand = Utilitario.ObterNumeroRandom(0, GestorEntidades.CromossomosDisponiveis.Count - 1);
            return GestorEntidades.CromossomosDisponiveis.ElementAt(rand);
        }
    }
}
