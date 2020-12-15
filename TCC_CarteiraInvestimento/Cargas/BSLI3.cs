using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> BSLI3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "BSLI3",
                Nome = "BRB-BANCO DE BRASILIA SA.",
                Setor = Setor.Financeiros,
                PrecoAtivoNoPeriodo = ObterAtivos_BSLI3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 4.27f,
                    PVPA = 1.02f,
                    PFCO = 28.27f,
                    DY = 14.33f,
                    PSR = 2.23f,
                    EVEBIT = null,
                    ROE = 23.99f,
                    ROIC = null,
                    LC = 0.81f,
                    DBPL = null,
                    LPA = 8.90f,
                    VPA = 37.08f,
                    DPA = 3.61f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 4.52f,
                    PVPA = 1.00f,
                    PFCO = 3.05f,
                    DY = 8.46f,
                    PSR = 2.28f,
                    EVEBIT = null,
                    ROE = 22.00f,
                    ROIC = null,
                    LC = 0.83f,
                    DBPL = null,
                    LPA = 8.40f,
                    VPA = 38.17f,
                    DPA = 4.42f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 4.31f,
                    PVPA = 0.86f,
                    PFCO = 2.25f,
                    DY = 6.24f,
                    PSR = 2.34f,
                    EVEBIT = null,
                    ROE = 19.89f,
                    ROIC = null,
                    LC = 0.85f,
                    DBPL = null,
                    LPA = 7.89f,
                    VPA = 39.65f,
                    DPA = 4.08f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.00f,
                    PSR = 0.00f,
                    EVEBIT = null,
                    ROE = 0.00f,
                    ROIC = null,
                    LC = 0.00f,
                    DBPL = null,
                    LPA = 0.00f,
                    VPA = 0.00f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 4.39f,
                    PVPA = 0.84f,
                    PFCO = 1.81f,
                    DY = 4.68f,
                    PSR = 1.60f,
                    EVEBIT = null,
                    ROE = 19.13f,
                    ROIC = null,
                    LC = 0.82f,
                    DBPL = null,
                    LPA = 6.27f,
                    VPA = 32.80f,
                    DPA = 1.32f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 4.59f,
                    PVPA = 0.95f,
                    PFCO = 2.28f,
                    DY = 9.83f,
                    PSR = 1.75f,
                    EVEBIT = null,
                    ROE = 20.64f,
                    ROIC = null,
                    LC = 0.83f,
                    DBPL = null,
                    LPA = 6.87f,
                    VPA = 33.30f,
                    DPA = 1.45f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 5.46f,
                    PVPA = 0.91f,
                    PFCO = 3.59f,
                    DY = 13.79f,
                    PSR = 1.84f,
                    EVEBIT = null,
                    ROE = 16.69f,
                    ROIC = null,
                    LC = 0.88f,
                    DBPL = null,
                    LPA = 5.77f,
                    VPA = 34.61f,
                    DPA = 1.80f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 4.40f,
                    PVPA = 0.90f,
                    PFCO = 1.62f,
                    DY = 11.70f,
                    PSR = 2.04f,
                    EVEBIT = null,
                    ROE = 20.45f,
                    ROIC = null,
                    LC = 0.90f,
                    DBPL = null,
                    LPA = 7.16f,
                    VPA = 35.01f,
                    DPA = 3.61f
                }));

            #endregion

            #region  Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 16.89f,
                    PVPA = 0.75f,
                    PFCO = -11.53f,
                    DY = 2.96f,
                    PSR = 1.53f,
                    EVEBIT = null,
                    ROE = 4.44f,
                    ROIC = null,
                    LC = 0.82f,
                    DBPL = null,
                    LPA = 1.48f,
                    VPA = 33.27f,
                    DPA = 0.76f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.62f,
                    PVPA = 0.83f,
                    PFCO = 23.65f,
                    DY = 4.04f,
                    PSR = 1.54f,
                    EVEBIT = null,
                    ROE = 8.63f,
                    ROIC = null,
                    LC = 0.82f,
                    DBPL = null,
                    LPA = 2.60f,
                    VPA = 30.11f,
                    DPA = 1.02f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 4.89f,
                    PVPA = 0.75f,
                    PFCO = -21.96f,
                    DY = 3.99f,
                    PSR = 1.75f,
                    EVEBIT = null,
                    ROE = 15.39f,
                    ROIC = null,
                    LC = 0.86f,
                    DBPL = null,
                    LPA = 5.11f,
                    VPA = 33.19f,
                    DPA = 1.02f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 4.53f,
                    PVPA = 0.77f,
                    PFCO = 6.02f,
                    DY = 4.52f,
                    PSR = 1.50f,
                    EVEBIT = null,
                    ROE = 17.08f,
                    ROIC = null,
                    LC = 0.79f,
                    DBPL = null,
                    LPA = 5.52f,
                    VPA = 32.34f,
                    DPA = 1.32f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_BSLI3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 0m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 0m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 0m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 0m));

            #endregion

            return null;
        }
    }
}
