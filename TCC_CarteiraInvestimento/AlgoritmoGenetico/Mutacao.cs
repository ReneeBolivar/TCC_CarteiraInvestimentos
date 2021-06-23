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

        static List<int> IdxIndividuosParaMutar = new List<int>();

        public static void MutarIndividuos()
        {
            IdxIndividuosParaMutar.Clear();

            for (int i = 0; i < GestorEntidades.Populacao.Individuos.Count; i++)
                if (DeveMutar())
                    IdxIndividuosParaMutar.Add(i);

            if (IdxIndividuosParaMutar.Any())
                Mutar();
        }

        private static void Mutar()
        {
            IdxIndividuosParaMutar.ForEach(idx =>
            {
                var idxCromossomoMutacao = Utilitario.ObterNumeroRandom(0, 4);
                Individuo individuo = GestorEntidades.Populacao.Individuos.ElementAt(idx);
                do
                {
                    var novoCromossomo = ObterNovoCromossomo();
                    individuo.Cromossomos[idxCromossomoMutacao] = novoCromossomo;

                } while (!IndividuoValido(individuo));

                GestorEntidades.Populacao.Individuos[idx] = individuo;
            });
        }

        private static bool DeveMutar()
        {
            var valores = new List<int>();
            for (int i = 0; i < (GestorConfiguracao.TaxaMutacao * 100); i++)
            {
                int novoValor; 
                do
                {
                    novoValor = Utilitario.ObterNumeroRandom(1, 100);
                } while (valores.Contains(novoValor)); // Não permite números repetidos

                valores.Add(novoValor);
            }

            var rand = Utilitario.ObterNumeroRandom(1, 100);

            return valores.Contains(rand);
        }

        private static Cromossomo ObterNovoCromossomo()
        {
            var rand = Utilitario.ObterNumeroRandom(0, GestorEntidades.CromossomosDisponiveis.Count - 1);
            return GestorEntidades.CromossomosDisponiveis.ElementAt(rand);
        }
    }
}
