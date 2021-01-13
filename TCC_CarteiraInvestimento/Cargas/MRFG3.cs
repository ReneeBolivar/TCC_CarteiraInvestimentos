using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> MRFG3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa 
            {
                Codigo = "MRFG3",
                Nome = "MARFRIG GLOBAL FOODS SA.",
                Setor = Setor.Alimentos,
                PrecoAtivoNoPeriodo = ObterAtivos_MRFG3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = -9.43f,
                    PVPA = 1.76f,
                    PFCO = -32.60f,
                    DY = 0.00f,
                    PSR = 0.87f,
                    EVEBIT = 10.49f,
                    ROE = -18.61f,
                    ROIC = 9.82f,
                    LC = 1.80f,
                    DBPL = 5.01f,
                    LPA = -0.87f,
                    VPA = 4.67f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = -3.35f,
                    PVPA = 1.13f,
                    PFCO = -5.80f,
                    DY = 0.00f,
                    PSR = 0.82f,
                    EVEBIT = 30.37f,
                    ROE = -33.65f,
                    ROIC = 5.54f,
                    LC = 1.12f,
                    DBPL = 7.68f,
                    LPA = -1.58f,
                    VPA = 4.69f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = -3.36f,
                    PVPA = 1.26f,
                    PFCO = 6.03f,
                    DY = 0.00f,
                    PSR = 0.62f,
                    EVEBIT = 15.63f,
                    ROE = -37.42f,
                    ROIC = 8.18f,
                    LC = 1.09f,
                    DBPL = 8.59f,
                    LPA = -1.62f,
                    VPA = 4.32f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 2.23f,
                    PVPA = 0.78f,
                    PFCO = 2.05f,
                    DY = 0.00f,
                    PSR = 0.49f,
                    EVEBIT = 26.45f,
                    ROE = 34.78f,
                    ROIC = 4.26f,
                    LC = 1.36f,
                    DBPL = 3.80f,
                    LPA = 2.68f,
                    VPA = 7.70f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -3.68f,
                    PVPA = 0.99f,
                    PFCO = 2.04f,
                    DY = 0.00f,
                    PSR = 0.73f,
                    EVEBIT = 10.15f,
                    ROE = -26.88f,
                    ROIC = 8.80f,
                    LC = 1.97f,
                    DBPL = 3.96f,
                    LPA = -1.55f,
                    VPA = 5.75f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -3.82f,
                    PVPA = 1.18f,
                    PFCO = 2.38f,
                    DY = 0.00f,
                    PSR = 0.75f,
                    EVEBIT = 11.82f,
                    ROE = -31.08f,
                    ROIC = 8.94f,
                    LC = 1.66f,
                    DBPL = 4.49f,
                    LPA = -1.61f,
                    VPA = 5.19f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -5.19f,
                    PVPA = 1.36f,
                    PFCO = 5.71f,
                    DY = 0.00f,
                    PSR = 0.74f,
                    EVEBIT = 11.10f,
                    ROE = -26.01f,
                    ROIC = 9.65f,
                    LC = 1.59f,
                    DBPL = 4.12f,
                    LPA = -1.41f,
                    VPA = 5.40f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = -6.08f,
                    PVPA = 1.12f,
                    PFCO = -419.68f,
                    DY = 0.00f,
                    PSR = 0.73f,
                    EVEBIT = 9.89f,
                    ROE = -18.35f,
                    ROIC = 10.00f,
                    LC = 1.62f,
                    DBPL = 4.73f,
                    LPA = -0.93f,
                    VPA = 5.05f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -28.22f,
                    PVPA = 3.31f,
                    PFCO = 1.66f,
                    DY = 0.00f,
                    PSR = 0.72f,
                    EVEBIT = 7.57f,
                    ROE = -11.88f,
                    ROIC = 14.17f,
                    LC = 1.26f,
                    DBPL = 11.51f,
                    LPA = -0.23f,
                    VPA = 1.96f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -11.96f,
                    PVPA = 1.71f,
                    PFCO = 1.75f,
                    DY = 0.00f,
                    PSR = 0.67f,
                    EVEBIT = 7.18f,
                    ROE = -14.39f,
                    ROIC = 13.83f,
                    LC = 1.24f,
                    DBPL = 6.42f,
                    LPA = -0.47f,
                    VPA = 3.29f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -4.50f,
                    PVPA = 1.78f,
                    PFCO = 1.69f,
                    DY = 0.00f,
                    PSR = 0.70f,
                    EVEBIT = 7.75f,
                    ROE = -39.31f,
                    ROIC = 10.37f,
                    LC = 1.26f,
                    DBPL = 7.57f,
                    LPA = -1.16f,
                    VPA = 2.94f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = -5.08f,
                    PVPA = 3.13f,
                    PFCO = 2.06f,
                    DY = 0.00f,
                    PSR = 0.68f,
                    EVEBIT = 9.23f,
                    ROE = -61.70f,
                    ROIC = 11.02f,
                    LC = 1.26f,
                    DBPL = 10.16f,
                    LPA = -1.30f,
                    VPA = 2.11f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_MRFG3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 5.98m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 5.94m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 8.14m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 5.3m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 5.46m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 5.71m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 6.76m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 6.47m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 7.32m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 6.49m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 5.62m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 5.22m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 6.61m));

            #endregion

            return ativos;
        }
    }
}
