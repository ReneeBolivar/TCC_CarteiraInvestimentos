using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> EQTL3()
        {
            var localList = new List<Cromossomo>();

            var empresa = new Empresa
            {
                Codigo = "EQTL3",
                Nome = "EQUATORIAL ENERGIA S/A.",
                Setor = Setor.EnergiaEletrica,
                PrecoAtivoNoPeriodo = ObterAtivos_EQTL3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 11.57f,
                    PVPA = 2.01f,
                    PFCO = 10.93f,
                    DY = 0.97f,
                    PSR = 1.81f,
                    EVEBIT = 9.93f,
                    ROE = 17.35f,
                    ROIC = 11.06f,
                    LC = 1.84f,
                    DBPL = 1.23f,
                    LPA = 5.10f,
                    VPA = 29.38f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 11.33f,
                    PVPA = 1.92f,
                    PFCO = 9.71f,
                    DY = 2.13f,
                    PSR = 1.85f,
                    EVEBIT = 9.87f,
                    ROE = 16.93f,
                    ROIC = 10.55f,
                    LC = 2.00f,
                    DBPL = 1.32f,
                    LPA = 5.07f,
                    VPA = 29.91f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 15.05f,
                    PVPA = 2.27f,
                    PFCO = 13.09f,
                    DY = 2.11f,
                    PSR = 2.02f,
                    EVEBIT = 11.92f,
                    ROE = 15.08f,
                    ROIC = 9.92f,
                    LC = 1.73f,
                    DBPL = 1.33f,
                    LPA = 4.75f,
                    VPA = 31.47f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.00f,
                    PSR = 0.00f,
                    EVEBIT = 0.00f,
                    ROE = 0.00f,
                    ROIC = 0.00f,
                    LC = 0.00f,
                    DBPL = 0.00f,
                    LPA = 0.00f,
                    VPA = 0.00f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 19.79f,
                    PVPA = 2.37f,
                    PFCO = 226.31f,
                    DY = 1.60f,
                    PSR = 1.97f,
                    EVEBIT = 13.44f,
                    ROE = 11.98f,
                    ROIC = 9.15f,
                    LC = 1.86f,
                    DBPL = 0.94f,
                    LPA = 2.97f,
                    VPA = 24.83f,
                    DPA = 0.86f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 22.60f,
                    PVPA = 2.40f,
                    PFCO = 273.03f,
                    DY = 1.62f,
                    PSR = 1.92f,
                    EVEBIT = 13.72f,
                    ROE = 10.66f,
                    ROIC = 9.31f,
                    LC = 1.68f,
                    DBPL = 0.96f,
                    LPA = 2.71f,
                    VPA = 25.47f,
                    DPA = 0.86f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 19.71f,
                    PVPA = 2.40f,
                    PFCO = 57.84f,
                    DY = 1.40f,
                    PSR = 1.93f,
                    EVEBIT = 12.59f,
                    ROE = 12.10f,
                    ROIC = 10.17f,
                    LC = 1.51f,
                    DBPL = 0.90f,
                    LPA = 3.33f,
                    VPA = 27.41f,
                    DPA = 0.86f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.72f,
                    PVPA = 2.38f,
                    PFCO = 12.95f,
                    DY = 1.05f,
                    PSR = 2.14f,
                    EVEBIT = 11.69f,
                    ROE = 17.35f,
                    ROIC = 10.81f,
                    LC = 1.84f,
                    DBPL = 1.21f,
                    LPA = 5.02f,
                    VPA = 28.93f,
                    DPA = 0.86f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.10f,
                    PVPA = 1.85f,
                    PFCO = 6.62f,
                    DY = 2.02f,
                    PSR = 1.55f,
                    EVEBIT = 14.32f,
                    ROE = 20.32f,
                    ROIC = 5.77f,
                    LC = 1.68f,
                    DBPL = 0.85f,
                    LPA = 4.50f,
                    VPA = 2.15f,
                    DPA = 1.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 16.89f,
                    PVPA = 2.10f,
                    PFCO = 9.14f,
                    DY = 2.08f,
                    PSR = 1.75f,
                    EVEBIT = 13.89f,
                    ROE = 12.47f,
                    ROIC = 8.65f,
                    LC = 1.70f,
                    DBPL = 0.80f,
                    LPA = 2.88f,
                    VPA = 23.12f,
                    DPA = 1.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 14.64f,
                    PVPA = 2.07f,
                    PFCO = 10.81f,
                    DY = 1.96f,
                    PSR = 1.76f,
                    EVEBIT = 13.30f,
                    ROE = 14.09f,
                    ROIC = 9.57f,
                    LC = 1.71f,
                    DBPL = 0.74f,
                    LPA = 3.43f,
                    VPA = 24.32f,
                    DPA = 1.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 15.20f,
                    PVPA = 2.22f,
                    PFCO = 0.00f,
                    DY = 1.71f,
                    PSR = 1.87f,
                    EVEBIT = 11.96f,
                    ROE = 14.62f,
                    ROIC = 9.02f,
                    LC = 1.74f,
                    DBPL = 0.99f,
                    LPA = 3.58f,
                    VPA = 24.52f,
                    DPA = 0.86f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_EQTL3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 15.41m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 13.73m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 11.08m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 11.21m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 14.55m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 11.16m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 10.39m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 11.75m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 12.6m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 7.62m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 9.19m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 9.51m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 10.33m));

            #endregion

            return null;
        }
    }
}
