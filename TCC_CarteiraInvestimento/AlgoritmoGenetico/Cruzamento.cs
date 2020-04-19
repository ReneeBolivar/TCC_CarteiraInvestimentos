using System.Linq;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;
using TCC_CarteiraInvestimento.Utils;

namespace TCC_CarteiraInvestimento.AlgoritmoGenetico
{
    public static partial class AG
    {
        public static void CruzarIndividuos()
        {
            foreach (var par in GestorEntidades.ParesParaCruzamento)
            {
                var primeiroFilho = new Cromossomo[GestorConfiguracao.CromossomosPorIndividuos];
                var segundoFilho = new Cromossomo[GestorConfiguracao.CromossomosPorIndividuos];

                var pontoCorte = Utilitario.ObterNumeroRandom(1, GestorConfiguracao.CromossomosPorIndividuos - 1); 

                // Head
                for (int i = 0; i < pontoCorte; i++)
                {
                    primeiroFilho[i] = par.Item1.Cromossomos.ElementAt(i);
                    segundoFilho[i] = par.Item2.Cromossomos.ElementAt(i);
                }

                // Tail
                for (int i = pontoCorte; i < GestorConfiguracao.CromossomosPorIndividuos; i++)
                {
                    primeiroFilho[i] = par.Item2.Cromossomos.ElementAt(i);
                    segundoFilho[i] = par.Item1.Cromossomos.ElementAt(i);
                }

                GestorEntidades.Populacao.Individuos.Add(new Individuo(primeiroFilho.ToList()));
                GestorEntidades.Populacao.Individuos.Add(new Individuo(segundoFilho.ToList()));
            }
        }
    }
}
