using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> BEES3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "BEES3",
                Nome = "BANESTE SA BANCO DO ESTADO DO ESPIRITO SANTO.",
                Setor = Setor.Financeiros,
                PrecoAtivoNoPeriodo = ObterAtivos_BEES3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 6.63f,
                    PVPA = 0.77f,
                    PFCO = -1.91f,
                    DY = 2.88f,
                    PSR = 2.38f,
                    EVEBIT = null,
                    ROE = 11.49f,
                    ROIC = null,
                    LC = 1.01f,
                    DBPL = null,
                    LPA = 0.51f,
                    VPA = 4.41f,
                    DPA = 0.20f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 6.81f,
                    PVPA = 0.82f,
                    PFCO = -5.35f,
                    DY = 3.42f,
                    PSR = 2.71f,
                    EVEBIT = null,
                    ROE = 12.15f,
                    ROIC = null,
                    LC = 0.99f,
                    DBPL = null,
                    LPA = 0.54f,
                    VPA = 4.47f,
                    DPA = 0.20f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 7.10f,
                    PVPA = 0.92f,
                    PFCO = 1.81f,
                    DY = 4.42f,
                    PSR = 2.87f,
                    EVEBIT = null,
                    ROE = 13.00f,
                    ROIC = null,
                    LC = 0.89f,
                    DBPL = null,
                    LPA = 0.59f,
                    VPA = 4.56f,
                    DPA = 0.24f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.63f,
                    PVPA = 1.04f,
                    PFCO = 1.41f,
                    DY = 6.15f,
                    PSR = 2.94f,
                    EVEBIT = null,
                    ROE = 12.13f,
                    ROIC = null,
                    LC = 0.87f,
                    DBPL = null,
                    LPA = 0.57f,
                    VPA = 4.72f,
                    DPA = 0.28f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 7.06f,
                    PVPA = 0.88f,
                    PFCO = 1.06f,
                    DY = 5.28f,
                    PSR = 1.67f,
                    EVEBIT = null,
                    ROE = 12.54f,
                    ROIC = null,
                    LC = 0.79f,
                    DBPL = null,
                    LPA = 0.51f,
                    VPA = 4.07f,
                    DPA = 0.19f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 7.41f,
                    PVPA = 0.88f,
                    PFCO = 0.73f,
                    DY = 5.93f,
                    PSR = 1.94f,
                    EVEBIT = null,
                    ROE = 11.94f,
                    ROIC = null,
                    LC = 0.82f,
                    DBPL = null,
                    LPA = 0.51f,
                    VPA = 4.28f,
                    DPA = 0.19f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.81f,
                    PVPA = 0.82f,
                    PFCO = 1.73f,
                    DY = 5.40f,
                    PSR = 2.05f,
                    EVEBIT = null,
                    ROE = 12.07f,
                    ROIC = null,
                    LC = 0.91f,
                    DBPL = null,
                    LPA = 0.53f,
                    VPA = 4.38f,
                    DPA = 0.19f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.71f,
                    PVPA = 0.96f,
                    PFCO = -2.10f,
                    DY = 5.48f,
                    PSR = 2.22f,
                    EVEBIT = null,
                    ROE = 12.57f,
                    ROIC = null,
                    LC = 0.89f,
                    DBPL = null,
                    LPA = 0.55f,
                    VPA = 4.41f,
                    DPA = 0.21f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 4.06f,
                    PVPA = 0.52f,
                    PFCO = 0.38f,
                    DY = 11.10f,
                    PSR = 1.68f,
                    EVEBIT = null,
                    ROE = 12.70f,
                    ROIC = null,
                    LC = 0.74f,
                    DBPL = null,
                    LPA = 0.48f,
                    VPA = 3.75f,
                    DPA = 0.19f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 4.67f,
                    PVPA = 0.58f,
                    PFCO = 0.30f,
                    DY = 10.22f,
                    PSR = 1.50f,
                    EVEBIT = null,
                    ROE = 12.63f,
                    ROIC = null,
                    LC = 0.70f,
                    DBPL = null,
                    LPA = 0.48f,
                    VPA = 3.84f,
                    DPA = 0.18f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 5.53f,
                    PVPA = 0.67f,
                    PFCO = 0.51f,
                    DY = 8.12f,
                    PSR = 1.54f,
                    EVEBIT = null,
                    ROE = 11.95f,
                    ROIC = null,
                    LC = 0.78f,
                    DBPL = null,
                    LPA = 0.47f,
                    VPA = 3.90f,
                    DPA = 0.19f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 5.16f,
                    PVPA = 0.66f,
                    PFCO = 0.46f,
                    DY = 7.39f,
                    PSR = 1.48f,
                    EVEBIT = null,
                    ROE = 12.78f,
                    ROIC = null,
                    LC = 0.80f,
                    DBPL = null,
                    LPA = 0.51f,
                    VPA = 4.00f,
                    DPA = 0.18f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_BEES3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 4.65m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 3.75m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 3.13m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 3.44m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 3.88m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 3.03m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 2.81m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 3.21m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 3.22m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 1.51m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 1.79m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 2.17m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 2.21m));

            #endregion

            return null;
        }
    }
}
