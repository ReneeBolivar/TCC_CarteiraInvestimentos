using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> BBDC3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "BBDC3",
                Nome = "BANCO BRADESCO SA.",
                Setor = Setor.Financeiros,
                PrecoAtivoNoPeriodo = ObterAtivos_BBDC3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 17.17f,
                    PVPA = 2.27f,
                    PFCO = 15.96f,
                    DY = 2.95f,
                    PSR = 3.49f,
                    EVEBIT = null,
                    ROE = 13.23f,
                    ROIC = null,
                    LC = 0.88f,
                    DBPL = null,
                    LPA = 2.24f,
                    VPA = 16.93f,
                    DPA = 1.06f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 10.46f,
                    PVPA = 1.45f,
                    PFCO = -81.56f,
                    DY = 4.65f,
                    PSR = 3.07f,
                    EVEBIT = null,
                    ROE = 13.86f,
                    ROIC = null,
                    LC = 0.90f,
                    DBPL = null,
                    LPA = 2.33f,
                    VPA = 16.82f,
                    DPA = 1.18f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 9.72f,
                    PVPA = 1.50f,
                    PFCO = -15.02f,
                    DY = 4.40f,
                    PSR = 3.37f,
                    EVEBIT = null,
                    ROE = 15.39f,
                    ROIC = null,
                    LC = 0.89f,
                    DBPL = null,
                    LPA = 2.65f,
                    VPA = 17.21f,
                    DPA = 1.19f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.33f,
                    PVPA = 2.10f,
                    PFCO = 22.77f,
                    DY = 3.08f,
                    PSR = 4.20f,
                    EVEBIT = null,
                    ROE = 15.76f,
                    ROIC = null,
                    LC = 0.88f,
                    DBPL = null,
                    LPA = 2.84f,
                    VPA = 18.02f,
                    DPA = 1.09f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 11.83f,
                    PVPA = 1.70f,
                    PFCO = 2.32f,
                    DY = 3.67f,
                    PSR = 1.85f,
                    EVEBIT = null,
                    ROE = 14.38f,
                    ROIC = null,
                    LC = 0.73f,
                    DBPL = null,
                    LPA = 2.71f,
                    VPA = 18.83f,
                    DPA = 1.33f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 10.34f,
                    PVPA = 1.44f,
                    PFCO = 2.23f,
                    DY = 3.81f,
                    PSR = 1.98f,
                    EVEBIT = null,
                    ROE = 13.87f,
                    ROIC = null,
                    LC = 0.81f,
                    DBPL = null,
                    LPA = 2.67f,
                    VPA = 19.23f,
                    DPA = 1.24f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.33f,
                    PVPA = 1.61f,
                    PFCO = 3.06f,
                    DY = 1.90f,
                    PSR = 2.20f,
                    EVEBIT = null,
                    ROE = 13.11f,
                    ROIC = null,
                    LC = 0.80f,
                    DBPL = null,
                    LPA = 2.60f,
                    VPA = 19.86f,
                    DPA = 1.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.84f,
                    PVPA = 1.84f,
                    PFCO = 12.74f,
                    DY = 3.54f,
                    PSR = 2.63f,
                    EVEBIT = null,
                    ROE = 13.27f,
                    ROIC = null,
                    LC = 0.79f,
                    DBPL = null,
                    LPA = 2.64f,
                    VPA = 19.89f,
                    DPA = 1.30f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.80f,
                    PVPA = 1.79f,
                    PFCO = -1.90f,
                    DY = 3.74f,
                    PSR = 1.79f,
                    EVEBIT = null,
                    ROE = 18.29f,
                    ROIC = null,
                    LC = 0.81f,
                    DBPL = null,
                    LPA = 3.07f,
                    VPA = 16.81f,
                    DPA = 1.08f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.97f,
                    PVPA = 1.56f,
                    PFCO = -2.73f,
                    DY = 4.31f,
                    PSR = 1.56f,
                    EVEBIT = null,
                    ROE = 17.36f,
                    ROIC = null,
                    LC = 0.77f,
                    DBPL = null,
                    LPA = 3.01f,
                    VPA = 17.35f,
                    DPA = 1.09f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 9.95f,
                    PVPA = 1.60f,
                    PFCO = 26.29f,
                    DY = 6.07f,
                    PSR = 1.55f,
                    EVEBIT = null,
                    ROE = 16.08f,
                    ROIC = null,
                    LC = 0.71f,
                    DBPL = null,
                    LPA = 2.85f,
                    VPA = 17.75f,
                    DPA = 1.24f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 10.71f,
                    PVPA = 1.61f,
                    PFCO = 2.02f,
                    DY = 4.08f,
                    PSR = 1.70f,
                    EVEBIT = null,
                    ROE = 15.02f,
                    ROIC = null,
                    LC = 0.73f,
                    DBPL = null,
                    LPA = 2.72f,
                    VPA = 18.09f,
                    DPA = 1.26f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_BBDC3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 26.83m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 24.02m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 16.81m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 17.91m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 23.93m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 17.62m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 16.71m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 20.38m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 20.02m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 14.41m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 14.36m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 15.12m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 15.98m));

            #endregion

            return null;
        }
    }
}
