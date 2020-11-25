using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;
using TCC_CarteiraInvestimento.Utils;
using static TCC_CarteiraInvestimento.Utils.Enums;

namespace TCC_CarteiraInvestimento.AlgoritmoGenetico
{
    public static partial class AG
    {
        public static void AvaliarIndividuos()
        {
            foreach (var individuo in GestorEntidades.Populacao.Individuos)
            {
                var pesoAnaliseFundamentalista = 0f;
                foreach (var cromossomo in individuo.Cromossomos) // Avaliar cromossomo a cromossomo
                    pesoAnaliseFundamentalista += CalcularAvalicaoIndicadores(cromossomo);

                var pesoSetoresDiferentes = AvaliarSetores(individuo);
                var pesoCromossomosDiferentes = AvaliarCromossomos(individuo);

                individuo.Peso = pesoAnaliseFundamentalista + pesoSetoresDiferentes + pesoCromossomosDiferentes;
            }
        }

        private static float CalcularAvalicaoIndicadores(Cromossomo cromossomo)
        {
            switch (GestorConfiguracao.ConfiguracaoFitness)
            {
                case ConfiguracaoFitness.Primeira:
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
                case ConfiguracaoFitness.Segunda:
                    return (AvaliarPL(cromossomo.AnaliseFundamentalista.PL) * 2) +
                           AvaliarPVPA(cromossomo.AnaliseFundamentalista.PVPA) +
                           AvaliarPFCO(cromossomo.AnaliseFundamentalista.PFCO) +
                           (AvaliarDY(cromossomo.AnaliseFundamentalista.DY) * 2) +
                           (AvaliarPSR(cromossomo.AnaliseFundamentalista.PSR) * 2) +
                           AvaliarEVEBIT(cromossomo.AnaliseFundamentalista.EVEBIT) +
                           AvaliarROE(cromossomo.AnaliseFundamentalista.ROE) +
                           AvaliarROIC(cromossomo.AnaliseFundamentalista.ROIC) +
                           (AvaliarLC(cromossomo.AnaliseFundamentalista.LC) * 2) +
                           AvaliarDBPL(cromossomo.AnaliseFundamentalista.DBPL) +
                           AvaliarLPA(cromossomo.AnaliseFundamentalista.LPA) +
                           AvaliarVPA(cromossomo.AnaliseFundamentalista.VPA) +
                           AvaliarDPA(cromossomo.AnaliseFundamentalista.DPA);
                case ConfiguracaoFitness.Terceita:
                    return AvaliarPL(cromossomo.AnaliseFundamentalista.PL) +
                           AvaliarDY(cromossomo.AnaliseFundamentalista.DY) +
                           AvaliarPSR(cromossomo.AnaliseFundamentalista.PSR) +
                           AvaliarLC(cromossomo.AnaliseFundamentalista.LC);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #region Avaliação de indicadores
        private static float AvaliarPL(float? pl)
            => PesoInversamenteProporcional(GestorEntidades.RangePL.Max, GestorEntidades.RangePL.Min, pl.GetValueOrDefault());

        private static float AvaliarPVPA(float? pvpa)
            => PesoDiretamenteProporcional(GestorEntidades.RangePVPA.Max, GestorEntidades.RangePVPA.Min, pvpa.GetValueOrDefault());

        private static float AvaliarPFCO(float? pfco)
            => PesoDiretamenteProporcional(GestorEntidades.RangePFCO.Max, GestorEntidades.RangePFCO.Min, pfco.GetValueOrDefault());

        private static float AvaliarDY(float? dy)
            => PesoDiretamenteProporcional(GestorEntidades.RangeDY.Max, GestorEntidades.RangeDY.Min, dy.GetValueOrDefault());

        private static float AvaliarPSR(float? psr)
            => PesoDiretamenteProporcional(GestorEntidades.RangePSR.Max, GestorEntidades.RangePSR.Min, psr.GetValueOrDefault());

        private static float AvaliarEVEBIT(float? evebit)
            => PesoDiretamenteProporcional(GestorEntidades.RangeEVEBIT.Max, GestorEntidades.RangeEVEBIT.Min, evebit.GetValueOrDefault());

        private static float AvaliarROE(float? roe)
            => PesoDiretamenteProporcional(GestorEntidades.RangeROE.Max, GestorEntidades.RangeROE.Min, roe.GetValueOrDefault());

        private static float AvaliarROIC(float? roic)
            => PesoDiretamenteProporcional(GestorEntidades.RangeROIC.Max, GestorEntidades.RangeROIC.Min, roic.GetValueOrDefault());

        private static float AvaliarLC(float? lc)
            => PesoDiretamenteProporcional(GestorEntidades.RangeLC.Max, GestorEntidades.RangeLC.Min, lc.GetValueOrDefault());

        private static float AvaliarDBPL(float? dbpl)
            => PesoInversamenteProporcional(GestorEntidades.RangePL.Max, GestorEntidades.RangePL.Min, dbpl.GetValueOrDefault());

        private static float AvaliarLPA(float? lpa)
            => PesoDiretamenteProporcional(GestorEntidades.RangeLPA.Max, GestorEntidades.RangeLPA.Min, lpa.GetValueOrDefault());

        private static float AvaliarVPA(float? vpa)
            => PesoDiretamenteProporcional(GestorEntidades.RangeVPA.Max, GestorEntidades.RangeVPA.Min, vpa.GetValueOrDefault());

        private static float AvaliarDPA(float? dpa)
            => PesoDiretamenteProporcional(GestorEntidades.RangeDPA.Max, GestorEntidades.RangeDPA.Min, dpa.GetValueOrDefault());
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

        private static float NormalizarEscala(float maximoDaAntigaEscala, float minimoDaAntigaEscala, float valor)
        {
            var razaoMaxMinEscalas = (MaximoNaNovaEscala - MinimoNaNovaEscala) / (maximoDaAntigaEscala - minimoDaAntigaEscala);

            return (razaoMaxMinEscalas * (valor - minimoDaAntigaEscala)) + MinimoNaNovaEscala;
        }

        private static float MaximoNaNovaEscala = 10.0f;
        private static float MinimoNaNovaEscala = 0.0f;

        private static float PesoInversamenteProporcional(float max, float min, float valor)
            => MaximoNaNovaEscala - NormalizarEscala(max, min, valor);

        private static float PesoDiretamenteProporcional(float max, float min, float valor)
            => NormalizarEscala(max, min, valor);
    }
}
