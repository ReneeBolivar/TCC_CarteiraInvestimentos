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
        public static void AvaliarIndividuos()
        {
            foreach (var individuo in GestorEntidades.Populacao.Individuos)
            {
                var pesoAnaliseFundamentalista = 0;
                foreach (var cromossomo in individuo.Cromossomos) // Avaliar cromossomo a cromossomo
                    pesoAnaliseFundamentalista += CalcularAvalicaoIndicadores(cromossomo);

                var pesoSetoresDiferentes = AvaliarSetores(individuo);
                var pesoCromossomosDiferentes = AvaliarCromossomos(individuo);

                individuo.Peso = pesoAnaliseFundamentalista + pesoSetoresDiferentes + pesoCromossomosDiferentes;
            }
        }

        private static int CalcularAvalicaoIndicadores(Cromossomo cromossomo)
        {
            return AvaliarPL(cromossomo.AnaliseFundamentalista.PL) +
                   AvaliarPVPA(cromossomo.AnaliseFundamentalista.PVPA) +
                   AvaliarPFCO(cromossomo.AnaliseFundamentalista.PFCO) +
                   AvaliarDY(cromossomo.AnaliseFundamentalista.DY) +
                   AvaliarPSR(cromossomo.AnaliseFundamentalista.PSR) +
                   AvaliarEVEBIT(cromossomo.AnaliseFundamentalista.EVEBIT) +
                   AvaliarROE(cromossomo.AnaliseFundamentalista.ROE) +
                   AvaliarROIC(cromossomo.AnaliseFundamentalista.ROIC) +
                   AvaliarLC(cromossomo.AnaliseFundamentalista.LC) +
                   AvaliarDBPL(cromossomo.AnaliseFundamentalista.DBPL) +
                   AvaliarLPA(cromossomo.AnaliseFundamentalista.LPA) +
                   AvaliarVPA(cromossomo.AnaliseFundamentalista.VPA) +
                   AvaliarDPA(cromossomo.AnaliseFundamentalista.DPA);
        }

        #region Avaliação de indicadores
        private static int AvaliarPL(float? pl) => 0;

        private static int AvaliarPVPA(float? pvpa) => 0;

        private static int AvaliarPFCO(float? pfco) => 0;

        private static int AvaliarDY(float? dy) => 0;

        private static int AvaliarPSR(float? psr) => 0;

        private static int AvaliarEVEBIT(float? evebit) => 0;

        private static int AvaliarROE(float? roe) => 0;

        private static int AvaliarROIC(float? roic) => 0;

        private static int AvaliarLC(float? lc) => 0;

        private static int AvaliarDBPL(float? dbpl) => 0;

        private static int AvaliarLPA(float? lpa) => 0;

        private static int AvaliarVPA(float? vpa) => 0;

        private static int AvaliarDPA(float? dpa) => 0;
        #endregion

        #region Avaliação de elementos únicos
        private static int AvaliarCromossomos(Individuo individuo)
        {
            var qtdeCromossomos = individuo.Cromossomos.Count();
            var cromossomosUnicos = individuo.Cromossomos.Distinct();

            if (cromossomosUnicos.Count() == 1) // Todos os cromossomos são iguais
                return -15;

            if (qtdeCromossomos == cromossomosUnicos.Count()) // Todo os cromossomos são diferentes
                return 15;

            var porcentagemRestante = Utilitario.RegraDeTres(qtdeCromossomos, cromossomosUnicos.Count());

            if (porcentagemRestante > 1 && porcentagemRestante < 26) // Sobrou entre 2% e 25%
                return -4;

            if (porcentagemRestante > 25 && porcentagemRestante < 51) // Sobrou entre 26% e 50%
                return -3;

            if (porcentagemRestante > 50 && porcentagemRestante < 76) // Sobrou entre 51% e 75%
                return -2;

            if (porcentagemRestante > 75 && porcentagemRestante < 100) // Sobrou entre 76% e 99%
                return -1;

            throw new ArgumentOutOfRangeException($"Valor não esperado no método {nameof(AvaliarCromossomos)}");
        }

        private static int AvaliarSetores(Individuo individuo)
        {
            var qtdeCromossomos = individuo.Cromossomos.Count();

            var listaSetores = new List<Setor>();
            individuo.Cromossomos.ForEach(x => listaSetores.Add(x.Empresa.Setor));

            var setoresUnicos = listaSetores.Distinct();

            if (setoresUnicos.Count() == 1) // Todos os setores são iguais
                return -15;

            if (setoresUnicos.Count() == qtdeCromossomos) // Todos os setores são diferentes
                return 15;

            var porcentagemRestante = Utilitario.RegraDeTres(qtdeCromossomos, setoresUnicos.Count());

            if (porcentagemRestante > 1 && porcentagemRestante < 26) // Sobrou entre 2% e 25%
                return -4;

            if (porcentagemRestante > 25 && porcentagemRestante < 51) // Sobrou entre 26% e 50%
                return -3;

            if (porcentagemRestante > 50 && porcentagemRestante < 76) // Sobrou entre 51% e 75%
                return -2;

            if (porcentagemRestante > 75 && porcentagemRestante < 100) // Sobrou entre 76% e 99%
                return -1;

            throw new ArgumentOutOfRangeException($"Valor não esperado no método {nameof(AvaliarSetores)}");
        }
        #endregion
    }
}
