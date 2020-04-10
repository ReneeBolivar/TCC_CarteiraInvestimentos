using System;
using System.Collections.Generic;
using System.Linq;
using TCC_CarteiraInvestimento.Entidades;

namespace TCC_CarteiraInvestimento.Gestores
{
    public static class GestorEntidades
    {
        static GestorEntidades()
        {
            if (Geracoes == null) Geracoes = new List<Geracao>();
            if (ParesParaCruzamento == null) ParesParaCruzamento = new List<Tuple<Individuo, Individuo>>();
        }

        public static Populacao Populacao { get; set; }

        public static List<Geracao> Geracoes { get; set; }

        private static List<Cromossomo> _cromossomosDisponiveis;
        public static List<Cromossomo> CromossomosDisponiveis
        {
            get { return _cromossomosDisponiveis; }
            set 
            { 
                _cromossomosDisponiveis = value;
                CarregarTuplas(); // Necessário executar logo após carregar todos os cromossomo disponíveis
            }
        }
        
        public static List<Tuple<Individuo, Individuo>> ParesParaCruzamento { get; set; }

        #region Máximo e mínimos da análise fundamentalista

        public static (float Max, float Min) RangePL { get; set; }
        public static (float Max, float Min) RangePVPA { get; set; }
        public static (float Max, float Min) RangePFCO { get; set; }
        public static (float Max, float Min) RangeDY { get; set; }
        public static (float Max, float Min) RangePSR { get; set; }
        public static (float Max, float Min) RangeEVEBIT { get; set; }
        public static (float Max, float Min) RangeROE { get; set; }
        public static (float Max, float Min) RangeROIC { get; set; }
        public static (float Max, float Min) RangeLC { get; set; }
        public static (float Max, float Min) RangeDBPL { get; set; }
        public static (float Max, float Min) RangeLPA { get; set; }
        public static (float Max, float Min) RangeVPA { get; set; }
        public static (float Max, float Min) RangeDPA { get; set; }
        
        private static void CarregarTuplas()
        {
            RangePL = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.PL.GetValueOrDefault()),
                       CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.PL.GetValueOrDefault()));

            RangePVPA = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.PVPA.GetValueOrDefault()),
                         CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.PVPA.GetValueOrDefault()));

            RangePFCO = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.PFCO.GetValueOrDefault()),
                         CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.PFCO.GetValueOrDefault()));

            RangeDY = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.DY.GetValueOrDefault()),
                       CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.DY.GetValueOrDefault()));

            RangePSR = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.PSR.GetValueOrDefault()),
                        CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.PSR.GetValueOrDefault()));

            RangeEVEBIT = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.EVEBIT.GetValueOrDefault()),
                           CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.EVEBIT.GetValueOrDefault()));

            RangeROE = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.ROE.GetValueOrDefault()),
                        CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.ROE.GetValueOrDefault()));

            RangeROIC = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.ROIC.GetValueOrDefault()),
                         CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.ROIC.GetValueOrDefault()));

            RangeLC = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.LC.GetValueOrDefault()),
                       CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.LC.GetValueOrDefault()));

            RangeDBPL = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.DBPL.GetValueOrDefault()),
                         CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.DBPL.GetValueOrDefault()));

            RangeLPA = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.LPA.GetValueOrDefault()),
                        CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.LPA.GetValueOrDefault()));

            RangeVPA = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.VPA.GetValueOrDefault()),
                        CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.VPA.GetValueOrDefault()));

            RangeDPA = (CromossomosDisponiveis.Max(x => x.AnaliseFundamentalista.DPA.GetValueOrDefault()),
                        CromossomosDisponiveis.Min(x => x.AnaliseFundamentalista.DPA.GetValueOrDefault()));
        } 
        #endregion
    }
}
