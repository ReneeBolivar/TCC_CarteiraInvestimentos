using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> EKTR4()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "EKTR4",
                Nome = "ELEKTRO ELETRICIDADE E SERVIÇOS S.A.",
                Setor = Setor.EnergiaEletrica,
                PrecoAtivoNoPeriodo = ObterAtivos_EKTR4()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.44f,
                    PVPA = 1.62f,
                    PFCO = 12.93f,
                    DY = 9.02f,
                    PSR = 0.93f,
                    EVEBIT = 8.77f,
                    ROE = 17.13f,
                    ROIC = 10.60f,
                    LC = 1.14f,
                    DBPL = 1.37f,
                    LPA = 1.86f,
                    VPA = 10.83f,
                    DPA = 1.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.87f,
                    PVPA = 1.74f,
                    PFCO = 26.60f,
                    DY = 7.09f,
                    PSR = 1.22f,
                    EVEBIT = 9.32f,
                    ROE = 17.62f,
                    ROIC = 8.10f,
                    LC = 1.94f,
                    DBPL = 2.14f,
                    LPA = 1.98f,
                    VPA = 11.21f,
                    DPA = 1.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 11.18f,
                    PVPA = 1.55f,
                    PFCO = 30.88f,
                    DY = 0.00f,
                    PSR = 1.13f,
                    EVEBIT = 9.28f,
                    ROE = 13.87f,
                    ROIC = 8.10f,
                    LC = 1.91f,
                    DBPL = 1.84f,
                    LPA = 1.62f,
                    VPA = 11.70f,
                    DPA = 1.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.88f,
                    PVPA = 1.60f,
                    PFCO = 10.94f,
                    DY = 3.78f,
                    PSR = 1.17f,
                    EVEBIT = 9.14f,
                    ROE = 18.06f,
                    ROIC = 8.99f,
                    LC = 1.92f,
                    DBPL = 1.72f,
                    LPA = 2.14f,
                    VPA = 11.84f,
                    DPA = 0.70f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 11.40f,
                    PVPA = 2.04f,
                    PFCO = 4.67f,
                    DY = 7.74f,
                    PSR = 1.24f,
                    EVEBIT = 9.80f,
                    ROE = 17.92f,
                    ROIC = 10.45f,
                    LC = 1.08f,
                    DBPL = 1.24f,
                    LPA = 1.93f,
                    VPA = 10.77f,
                    DPA = 1.81f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 10.05f,
                    PVPA = 1.91f,
                    PFCO = 5.43f,
                    DY = 8.62f,
                    PSR = 1.15f,
                    EVEBIT = 8.96f,
                    ROE = 18.99f,
                    ROIC = 10.77f,
                    LC = 1.09f,
                    DBPL = 1.30f,
                    LPA = 1.99f,
                    VPA = 10.47f,
                    DPA = 1.81f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 9.16f,
                    PVPA = 2.26f,
                    PFCO = 6.95f,
                    DY = 12.86f,
                    PSR = 1.16f,
                    EVEBIT = 8.77f,
                    ROE = 24.71f,
                    ROIC = 12.14f,
                    LC = 1.00f,
                    DBPL = 1.48f,
                    LPA = 2.49f,
                    VPA = 10.07f,
                    DPA = 2.50f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 10.73f,
                    PVPA = 1.98f,
                    PFCO = 8.40f,
                    DY = 8.16f,
                    PSR = 1.01f,
                    EVEBIT = 9.32f,
                    ROE = 18.44f,
                    ROIC = 10.63f,
                    LC = 0.95f,
                    DBPL = 1.47f,
                    LPA = 1.93f,
                    VPA = 10.48f,
                    DPA = 1.22f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 13.70f,
                    PVPA = 2.16f,
                    PFCO = 6.18f,
                    DY = 15.13f,
                    PSR = 1.31f,
                    EVEBIT = 10.91f,
                    ROE = 15.77f,
                    ROIC = 9.44f,
                    LC = 1.46f,
                    DBPL = 1.56f,
                    LPA = 1.65f,
                    VPA = 10.47f,
                    DPA = 1.92f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 11.92f,
                    PVPA = 1.75f,
                    PFCO = 3.20f,
                    DY = 11.17f,
                    PSR = 1.13f,
                    EVEBIT = 9.32f,
                    ROE = 14.64f,
                    ROIC = 9.82f,
                    LC = 1.30f,
                    DBPL = 1.39f,
                    LPA = 1.51f,
                    VPA = 10.29f,
                    DPA = 1.92f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.90f,
                    PVPA = 1.77f,
                    PFCO = 3.04f,
                    DY = 8.87f,
                    PSR = 1.12f,
                    EVEBIT = 9.03f,
                    ROE = 13.68f,
                    ROIC = 10.39f,
                    LC = 1.24f,
                    DBPL = 1.38f,
                    LPA = 1.38f,
                    VPA = 10.06f,
                    DPA = 1.51f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 10.98f,
                    PVPA = 1.94f,
                    PFCO = 3.83f,
                    DY = 8.52f,
                    PSR = 1.25f,
                    EVEBIT = 9.54f,
                    ROE = 17.60f,
                    ROIC = 9.98f,
                    LC = 1.15f,
                    DBPL = 1.37f,
                    LPA = 1.82f,
                    VPA = 10.31f,
                    DPA = 1.81f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_EKTR4()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 18.46m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 19.45m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 16.97m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 18.44m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 18.29m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 19.15m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 19.66m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 19.13m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 21.5m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 19.66m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 15.65m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 15.5m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 17.4m));

            #endregion

            return ativos;
        }
    }
}
