using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> BGIP4()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "BGIP4",
                Nome = "BANCO DO ESTADO DE SERGIPE SA.",
                Setor = Setor.Financeiros,
                PrecoAtivoNoPeriodo = ObterAtivos_BGIP4()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 6.01f,
                    PVPA = 1.52f,
                    PFCO = -1.81f,
                    DY = 8.17f,
                    PSR = 2.29f,
                    EVEBIT = null,
                    ROE = 25.34f,
                    ROIC = null,
                    LC = 1.16f,
                    DBPL = null,
                    LPA = 6.32f,
                    VPA = 24.94f,
                    DPA = 1.77f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 6.11f,
                    PVPA = 1.37f,
                    PFCO = 2.47f,
                    DY = 4.87f,
                    PSR = 2.27f,
                    EVEBIT = null,
                    ROE = 22.47f,
                    ROIC = null,
                    LC = 1.00f,
                    DBPL = null,
                    LPA = 5.71f,
                    VPA = 25.40f,
                    DPA = 1.67f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.41f,
                    PVPA = 1.35f,
                    PFCO = 3.91f,
                    DY = 5.00f,
                    PSR = 2.23f,
                    EVEBIT = null,
                    ROE = 20.99f,
                    ROIC = null,
                    LC = 0.98f,
                    DBPL = null,
                    LPA = 5.50f,
                    VPA = 26.21f,
                    DPA = 1.69f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.98f,
                    PVPA = 1.38f,
                    PFCO = 1.54f,
                    DY = 4.87f,
                    PSR = 2.24f,
                    EVEBIT = null,
                    ROE = 15.41f,
                    ROIC = null,
                    LC = 0.94f,
                    DBPL = null,
                    LPA = 4.09f,
                    VPA = 26.56f,
                    DPA = 1.40f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.13f,
                    PVPA = 1.02f,
                    PFCO = 0.66f,
                    DY = 4.69f,
                    PSR = 1.93f,
                    EVEBIT = null,
                    ROE = 19.91f,
                    ROIC = null,
                    LC = 1.17f,
                    DBPL = null,
                    LPA = 4.48f,
                    VPA = 22.49f,
                    DPA = 1.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 6.20f,
                    PVPA = 1.47f,
                    PFCO = 1.66f,
                    DY = 13.86f,
                    PSR = 2.16f,
                    EVEBIT = null,
                    ROE = 23.77f,
                    ROIC = null,
                    LC = 1.19f,
                    DBPL = null,
                    LPA = 5.19f,
                    VPA = 21.85f,
                    DPA = 1.42f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.64f,
                    PVPA = 1.59f,
                    PFCO = 3.77f,
                    DY = 10.37f,
                    PSR = 2.22f,
                    EVEBIT = null,
                    ROE = 23.88f,
                    ROIC = null,
                    LC = 1.16f,
                    DBPL = null,
                    LPA = 5.42f,
                    VPA = 22.69f,
                    DPA = 1.79f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.01f,
                    PVPA = 1.78f,
                    PFCO = -4.30f,
                    DY = 11.81f,
                    PSR = 2.23f,
                    EVEBIT = null,
                    ROE = 25.38f,
                    ROIC = null,
                    LC = 1.16f,
                    DBPL = null,
                    LPA = 6.13f,
                    VPA = 24.15f,
                    DPA = 1.76f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 4.94f,
                    PVPA = 0.59f,
                    PFCO = -1.28f,
                    DY = 10.42f,
                    PSR = 1.41f,
                    EVEBIT = null,
                    ROE = 11.88f,
                    ROIC = null,
                    LC = 1.11f,
                    DBPL = null,
                    LPA = 2.31f,
                    VPA = 19.46f,
                    DPA = 1.28f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 6.88f,
                    PVPA = 0.58f,
                    PFCO = -0.48f,
                    DY = 10.33f,
                    PSR = 1.51f,
                    EVEBIT = null,
                    ROE = 8.39f,
                    ROIC = null,
                    LC = 1.14f,
                    DBPL = null,
                    LPA = 1.64f,
                    VPA = 19.59f,
                    DPA = 0.96f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 9.14f,
                    PVPA = 0.66f,
                    PFCO = 9.69f,
                    DY = 7.22f,
                    PSR = 1.50f,
                    EVEBIT = null,
                    ROE = 7.27f,
                    ROIC = null,
                    LC = 1.08f,
                    DBPL = null,
                    LPA = 1.51f,
                    VPA = 20.77f,
                    DPA = 0.66f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 3.41f,
                    PVPA = 0.67f,
                    PFCO = 0.71f,
                    DY = 2.49f,
                    PSR = 1.52f,
                    EVEBIT = null,
                    ROE = 19.59f,
                    ROIC = null,
                    LC = 1.10f,
                    DBPL = null,
                    LPA = 4.29f,
                    VPA = 21.88f,
                    DPA = 1.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_BGIP4()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 35.35m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 40.01m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 37.9m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 32.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 34.17m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 19.72m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 23.64m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 30.33m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 33.28m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 9.34m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 9.23m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 11.52m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 12.24m));

            #endregion

            return ativos;
        }
    }
}
