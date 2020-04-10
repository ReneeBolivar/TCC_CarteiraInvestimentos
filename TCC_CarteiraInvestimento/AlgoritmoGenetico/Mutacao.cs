using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;
using TCC_CarteiraInvestimento.Utils;

namespace TCC_CarteiraInvestimento.AlgoritmoGenetico
{
    public static partial class AG
    {
        private static Dictionary<int, int> CromossomosParaMutar = new Dictionary<int, int>();

        public static void MutarIndividuos()
        {
            CromossomosParaMutar.Clear();

            for (int idxIndividuo = 0; idxIndividuo < GestorEntidades.Populacao.Individuos.Count; idxIndividuo++)
                for (int idxCromossomo = 0; idxCromossomo < GestorConfiguracao.CromossomosPorIndividuos; idxCromossomo++)
                    if (DeveMutar())
                    { 
                        CromossomosParaMutar.Add(idxIndividuo, idxCromossomo);
                        break;
                    }

            AplicarMutacao();
        }

        private static void AplicarMutacao()
        {
            foreach (var cromossomoParaMutar in CromossomosParaMutar)
            {
                //Remove o cromossomo no index especificado
                GestorEntidades.Populacao.Individuos
                    .ElementAt(cromossomoParaMutar.Key)
                    .Cromossomos
                    .RemoveAt(cromossomoParaMutar.Value);

                //Adiciona o novo cromossomo no index especificado
                GestorEntidades.Populacao.Individuos
                    .ElementAt(cromossomoParaMutar.Key)
                    .Cromossomos
                    .Insert(cromossomoParaMutar.Value, ObterNovoCromossomo());
            }
        }

        private static bool DeveMutar()
        {
            var rand = Utilitario.ObterNumeroRandom(0, 100);

            if (rand >= 0 && rand <= (GestorConfiguracao.TaxaMutacao * 100))
                return true;

            return false;
        }

        private static Cromossomo ObterNovoCromossomo()
        {
            var rand = Utilitario.ObterNumeroRandom(0, GestorEntidades.CromossomosDisponiveis.Count - 1);
            return GestorEntidades.CromossomosDisponiveis.ElementAt(rand);
        }
    }
}
