using System.Collections.Generic;
using System.Linq;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.AlgoritmoGenetico
{
    public static partial class AG
    {
        public static bool PopulacaoApta()
        {
            if (GestorEntidades.Geracoes.Count < 9) 
                return false;

            if (SemEvolucao() && IndividuosUnicos())
                return true;

            return false;
        }

        private static bool IndividuosUnicos()
        {
            var ultimaGeracao = GestorEntidades.Geracoes.OrderByDescending(x => x.DataGeracao).First();

            var melhorIndividuoPopulacao = ultimaGeracao.Populacao.Individuos.OrderByDescending(x => x.Peso).First();

            var setoresMelhorIndividuo = new List<Setor>();
            melhorIndividuoPopulacao.Cromossomos.ForEach(x => setoresMelhorIndividuo.Add(x.Empresa.Setor));

            var qtdeDistintosNecessarios = melhorIndividuoPopulacao.Cromossomos.Count;

            if (melhorIndividuoPopulacao.Cromossomos.Distinct().Count() == qtdeDistintosNecessarios)
                if (setoresMelhorIndividuo.Distinct().Count() == qtdeDistintosNecessarios)
                    return true;


            return false;
        }

        private static bool SemEvolucao()
        {
            var ultimasOitoGeracoes = GestorEntidades.Geracoes.OrderByDescending(x => x.DataGeracao).Take(8);

            var pesos = new List<float>();

            foreach (var geracao in ultimasOitoGeracoes)
                pesos.Add(geracao.Populacao.Individuos.Max(x => x.Peso));

            if (pesos.Distinct().Count() == 1)
                return true;

            return false;
        }
    }
}
