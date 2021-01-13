using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> CGAS5()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "CGAS5",
                Nome = "COMPANHIA DE GÁS DE SÃO PAULO",
                Setor = Setor.Gas,
                PrecoAtivoNoPeriodo = ObterAtivos_CGAS5()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 10.73f,
                    PVPA = 3.51f,
                    PFCO = 4.60f,
                    DY = 12.29f,
                    PSR = 1.81f,
                    EVEBIT = 8.18f,
                    ROE = 32.67f,
                    ROIC = 15.42f,
                    LC = 1.15f,
                    DBPL = 1.73f,
                    LPA = 5.62f,
                    VPA = 17.20f,
                    DPA = 4.75f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.17f,
                    PVPA = 2.72f,
                    PFCO = 3.82f,
                    DY = 12.13f,
                    PSR = 1.57f,
                    EVEBIT = 7.66f,
                    ROE = 29.65f,
                    ROIC = 13.91f,
                    LC = 1.32f,
                    DBPL = 1.85f,
                    LPA = 5.37f,
                    VPA = 18.10f,
                    DPA = 4.75f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 11.23f,
                    PVPA = 2.99f,
                    PFCO = 4.37f,
                    DY = 14.62f,
                    PSR = 1.66f,
                    EVEBIT = 8.87f,
                    ROE = 26.59f,
                    ROIC = 14.10f,
                    LC = 1.37f,
                    DBPL = 1.54f,
                    LPA = 5.21f,
                    VPA = 19.58f,
                    DPA = 4.75f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.79f,
                    PVPA = 3.83f,
                    PFCO = 6.63f,
                    DY = 8.30f,
                    PSR = 1.96f,
                    EVEBIT = 7.31f,
                    ROE = 49.22f,
                    ROIC = 19.78f,
                    LC = 1.69f,
                    DBPL = 1.34f,
                    LPA = 10.52f,
                    VPA = 21.38f,
                    DPA = 4.70f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 7.58f,
                    PVPA = 2.51f,
                    PFCO = 2.91f,
                    DY = 10.26f,
                    PSR = 1.69f,
                    EVEBIT = 5.98f,
                    ROE = 33.15f,
                    ROIC = 15.62f,
                    LC = 1.26f,
                    DBPL = 1.69f,
                    LPA = 6.16f,
                    VPA = 18.57f,
                    DPA = 1.85f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 10.72f,
                    PVPA = 2.56f,
                    PFCO = 3.52f,
                    DY = 10.40f,
                    PSR = 1.82f,
                    EVEBIT = 7.88f,
                    ROE = 23.88f,
                    ROIC = 12.39f,
                    LC = 1.28f,
                    DBPL = 1.58f,
                    LPA = 4.71f,
                    VPA = 19.72f,
                    DPA = 1.85f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.90f,
                    PVPA = 2.81f,
                    PFCO = 4.11f,
                    DY = 8.67f,
                    PSR = 1.91f,
                    EVEBIT = 8.89f,
                    ROE = 21.76f,
                    ROIC = 12.04f,
                    LC = 1.16f,
                    DBPL = 1.43f,
                    LPA = 4.65f,
                    VPA = 21.36f,
                    DPA = 1.85f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 11.63f,
                    PVPA = 3.69f,
                    PFCO = 4.55f,
                    DY = 17.63f,
                    PSR = 1.88f,
                    EVEBIT = 8.69f,
                    ROE = 31.73f,
                    ROIC = 13.90f,
                    LC = 1.06f,
                    DBPL = 2.09f,
                    LPA = 5.03f,
                    VPA = 15.84f,
                    DPA = 4.75f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.71f,
                    PVPA = 2.25f,
                    PFCO = 2.69f,
                    DY = 40.70f,
                    PSR = 1.25f,
                    EVEBIT = 5.37f,
                    ROE = 39.47f,
                    ROIC = 18.05f,
                    LC = 0.91f,
                    DBPL = 1.70f,
                    LPA = 6.83f,
                    VPA = 17.30f,
                    DPA = 2.32f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 6.02f,
                    PVPA = 2.34f,
                    PFCO = 2.99f,
                    DY = 28.34f,
                    PSR = 1.40f,
                    EVEBIT = 5.05f,
                    ROE = 38.86f,
                    ROIC = 19.33f,
                    LC = 1.12f,
                    DBPL = 1.40f,
                    LPA = 7.73f,
                    VPA = 19.89f,
                    DPA = 2.32f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.62f,
                    PVPA = 2.43f,
                    PFCO = 3.55f,
                    DY = 25.11f,
                    PSR = 1.61f,
                    EVEBIT = 5.04f,
                    ROE = 36.67f,
                    ROIC = 19.89f,
                    LC = 1.23f,
                    DBPL = 1.30f,
                    LPA = 7.92f,
                    VPA = 21.59f,
                    DPA = 2.32f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 6.48f,
                    PVPA = 2.26f,
                    PFCO = 2.80f,
                    DY = 25.75f,
                    PSR = 1.67f,
                    EVEBIT = 4.95f,
                    ROE = 34.78f,
                    ROIC = 17.48f,
                    LC = 1.52f,
                    DBPL = 1.57f,
                    LPA = 7.08f,
                    VPA = 20.35f,
                    DPA = 1.85f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_CGAS5()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 62.72m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 41.51m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 42.03m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 34.89m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 44.93m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 28.97m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 28.72m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 34.28m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 42.49m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 22.03m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 26.27m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 29.61m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 26.61m));

            #endregion

            return ativos;
        }
    }
}
