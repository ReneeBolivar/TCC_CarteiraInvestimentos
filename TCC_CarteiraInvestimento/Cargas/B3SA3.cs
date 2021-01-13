using System;
using System.Collections.Generic;
using System.Text;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> B3SA3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "B3SA3",
                Nome = "BM&F BOVESPA S/A - BOLSA DE VALORES, MERCADORIAS E FUTUROS.",
                Setor = Setor.ServicosFinanceirosDiversos,
                PrecoAtivoNoPeriodo = ObterAtivos_B3SA3()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 26.32f,
                    PVPA = 1.41f,
                    PFCO = 3.09f,
                    DY = 1.70f,
                    PSR = 9.30f,
                    EVEBIT = 19.57f,
                    ROE = 5.40f,
                    ROIC = 4.69f,
                    LC = 1.73f,
                    DBPL = 0.23f,
                    LPA = 0.73f,
                    VPA = 13.58f,
                    DPA = 0.51f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 22.50f,
                    PVPA = 1.72f,
                    PFCO = 3.93f,
                    DY = 3.44f,
                    PSR = 10.52f,
                    EVEBIT = 19.14f,
                    ROE = 7.64f,
                    ROIC = 6.43f,
                    LC = 1.69f,
                    DBPL = 0.24f,
                    LPA = 1.04f,
                    VPA = 13.64f,
                    DPA = 0.79f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 23.57f,
                    PVPA = 1.91f,
                    PFCO = 4.55f,
                    DY = 3.59f,
                    PSR = 11.38f,
                    EVEBIT = 20.94f,
                    ROE = 8.11f,
                    ROIC = 6.89f,
                    LC = 1.60f,
                    DBPL = 0.25f,
                    LPA = 1.11f,
                    VPA = 13.72f,
                    DPA = 0.94f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 27.93f,
                    PVPA = 2.33f,
                    PFCO = 15.90f,
                    DY = 2.62f,
                    PSR = 12.63f,
                    EVEBIT = 23.40f,
                    ROE = 8.34f,
                    ROIC = 7.25f,
                    LC = 1.30f,
                    DBPL = 0.18f,
                    LPA = 1.15f,
                    VPA = 13.80f,
                    DPA = 0.79f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 25.38f,
                    PVPA = 1.45f,
                    PFCO = -5.28f,
                    DY = 2.60f,
                    PSR = 17.02f,
                    EVEBIT = 28.12f,
                    ROE = 5.75f,
                    ROIC = 4.06f,
                    LC = 1.07f,
                    DBPL = 0.27f,
                    LPA = 0.76f,
                    VPA = 13.29f,
                    DPA = 0.50f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 25.37f,
                    PVPA = 1.75f,
                    PFCO = -30.69f,
                    DY = 2.44f,
                    PSR = 17.28f,
                    EVEBIT = 44.77f,
                    ROE = 6.89f,
                    ROIC = 3.78f,
                    LC = 1.22f,
                    DBPL = 0.26f,
                    LPA = 0.92f,
                    VPA = 13.32f,
                    DPA = 0.48f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 24.23f,
                    PVPA = 1.69f,
                    PFCO = -53.41f,
                    DY = 1.66f,
                    PSR = 14.33f,
                    EVEBIT = 31.37f,
                    ROE = 6.98f,
                    ROIC = 4.65f,
                    LC = 1.61f,
                    DBPL = 0.23f,
                    LPA = 0.94f,
                    VPA = 13.48f,
                    DPA = 0.41f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 36.27f,
                    PVPA = 1.92f,
                    PFCO = 4.18f,
                    DY = 1.99f,
                    PSR = 13.82f,
                    EVEBIT = 31.48f,
                    ROE = 5.33f,
                    ROIC = 4.02f,
                    LC = 1.18f,
                    DBPL = 0.23f,
                    LPA = 0.71f,
                    VPA = 13.39f,
                    DPA = 0.51f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_B3SA3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 30.47m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 24.52m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 19.03m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 21.93m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 25.30m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 17.41m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 17.88m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 21.72m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 20.94m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 13.51m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 15.86m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 14.94m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 14.89m));

            #endregion

            return ativos;
        }
    }
}
