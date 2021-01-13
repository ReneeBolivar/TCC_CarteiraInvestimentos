using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> CRPG5()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Nome = "CRISTAL PIGMENTOS DO BRASIL S.A.",
                Codigo = "CRPG5",
                Setor = Setor.Quimicos,
                PrecoAtivoNoPeriodo = ObterAtivos_CRPG5()
            };

            #region Compreendo todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.33f,
                    PVPA = 1.07f,
                    PFCO = 4.35f,
                    DY = 2.10f,
                    PSR = 0.84f,
                    EVEBIT = 3.41f,
                    ROE = 20.01f,
                    ROIC = 19.16f,
                    LC = 5.37f,
                    DBPL = 0.00f,
                    LPA = 4.09f,
                    VPA = 20.45f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 5.35f,
                    PVPA = 1.33f,
                    PFCO = 4.77f,
                    DY = 10.05f,
                    PSR = 1.04f,
                    EVEBIT = 3.91f,
                    ROE = 24.83f,
                    ROIC = 23.27f,
                    LC = 5.97f,
                    DBPL = 0.00f,
                    LPA = 5.05f,
                    VPA = 20.34f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 5.55f,
                    PVPA = 1.64f,
                    PFCO = 9.53f,
                    DY = 14.06f,
                    PSR = 1.26f,
                    EVEBIT = 4.70f,
                    ROE = 29.67f,
                    ROIC = 28.11f,
                    LC = 5.72f,
                    DBPL = 0.00f,
                    LPA = 6.17f,
                    VPA = 20.81f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 5.93f,
                    PVPA = 1.81f,
                    PFCO = 9.57f,
                    DY = 13.57f,
                    PSR = 1.45f,
                    EVEBIT = 5.64f,
                    ROE = 30.58f,
                    ROIC = 29.83f,
                    LC = 9.41f,
                    DBPL = 0.00f,
                    LPA = 6.71f,
                    VPA = 21.93f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 2.18f,
                    PVPA = 0.42f,
                    PFCO = 2.55f,
                    DY = 0.00f,
                    PSR = 0.38f,
                    EVEBIT = 2.69f,
                    ROE = 19.37f,
                    ROIC = 11.14f,
                    LC = 5.52f,
                    DBPL = 0.02f,
                    LPA = 3.58f,
                    VPA = 18.47f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 3.11f,
                    PVPA = 0.72f,
                    PFCO = 3.70f,
                    DY = 3.08f,
                    PSR = 0.56f,
                    EVEBIT = 4.09f,
                    ROE = 23.19f,
                    ROIC = 13.04f,
                    LC = 4.87f,
                    DBPL = 0.02f,
                    LPA = 4.41f,
                    VPA = 19.02f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 2.89f,
                    PVPA = 0.78f,
                    PFCO = 4.14f,
                    DY = 2.31f,
                    PSR = 0.50f,
                    EVEBIT = 3.01f,
                    ROE = 26.99f,
                    ROIC = 17.62f,
                    LC = 4.97f,
                    DBPL = 0.01f,
                    LPA = 5.43f,
                    VPA = 20.10f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 5.53f,
                    PVPA = 0.97f,
                    PFCO = 6.00f,
                    DY = 2.68f,
                    PSR = 0.77f,
                    EVEBIT = 3.79f,
                    ROE = 17.53f,
                    ROIC = 16.54f,
                    LC = 6.21f,
                    DBPL = 0.01f,
                    LPA = 3.40f,
                    VPA = 19.41f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -2.72f,
                    PVPA = 0.11f,
                    PFCO = 0.85f,
                    DY = 0.00f,
                    PSR = 0.09f,
                    EVEBIT = -10.21f,
                    ROE = -4.09f,
                    ROIC = -2.97f,
                    LC = 3.06f,
                    DBPL = 0.20f,
                    LPA = -0.61f,
                    VPA = 14.89f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -6.17f,
                    PVPA = 0.19f,
                    PFCO = 2.64f,
                    DY = 0.00f,
                    PSR = 0.20f,
                    EVEBIT = -6.32f,
                    ROE = -3.09f,
                    ROIC = -3.33f,
                    LC = 3.69f,
                    DBPL = 0.11f,
                    LPA = -0.48f,
                    VPA = 15.65f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -21.58f,
                    PVPA = 0.32f,
                    PFCO = 1.97f,
                    DY = 0.00f,
                    PSR = 0.54f,
                    EVEBIT = -5.30f,
                    ROE = -1.51f,
                    ROIC = -4.19f,
                    LC = 3.41f,
                    DBPL = 0.13f,
                    LPA = -0.24f,
                    VPA = 16.01f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 1.65f,
                    PVPA = 0.33f,
                    PFCO = 2.62f,
                    DY = 0.00f,
                    PSR = 0.29f,
                    EVEBIT = 2.20f,
                    ROE = 19.92f,
                    ROIC = 8.78f,
                    LC = 3.42f,
                    DBPL = 0.12f,
                    LPA = 3.62f,
                    VPA = 18.17f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_CRPG5()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 31.65m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 13.36m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 15m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 20.76m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 27.82m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 5.19m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 9.17m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 12.18m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 10.49m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 1.10m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 1.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 3.47m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 4.01m));

            #endregion

            return ativos;
        }
    }
}
