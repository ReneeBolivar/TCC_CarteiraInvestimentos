using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> BBAS3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "BBAS3",
                Nome = "BANCO DO BRASIL S.A.",
                Setor = Setor.Financeiros,
                PrecoAtivoNoPeriodo = ObterAtivos_BBAS3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 6.27f,
                    PVPA = 0.78f,
                    PFCO = -15.03f,
                    DY = 2.86f,
                    PSR = 0.81f,
                    EVEBIT = null,
                    ROE = 12.49f,
                    ROIC = null,
                    LC = 0.78f,
                    DBPL = null,
                    LPA = 3.91f,
                    VPA = 31.33f,
                    DPA = 1.17f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 7.22f,
                    PVPA = 0.92f,
                    PFCO = 6.03f,
                    DY = 4.21f,
                    PSR = 0.89f,
                    EVEBIT = null,
                    ROE = 12.78f,
                    ROIC = null,
                    LC = 0.80f,
                    DBPL = null,
                    LPA = 4.08f,
                    VPA = 31.96f,
                    DPA = 1.23f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 10.79f,
                    PVPA = 1.39f,
                    PFCO = 5.16f,
                    DY = 4.34f,
                    PSR = 1.21f,
                    EVEBIT = null,
                    ROE = 12.91f,
                    ROIC = null,
                    LC = 0.78f,
                    DBPL = null,
                    LPA = 4.18f,
                    VPA = 32.37f,
                    DPA = 1.43f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 11.05f,
                    PVPA = 1.52f,
                    PFCO = 8.15f,
                    DY = 3.26f,
                    PSR = 1.34f,
                    EVEBIT = null,
                    ROE = 13.75f,
                    ROIC = null,
                    LC = 0.79f,
                    DBPL = null,
                    LPA = 4.41f,
                    VPA = 32.10f,
                    DPA = 1.80f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 12.06f,
                    PVPA = 1.23f,
                    PFCO = -2.38f,
                    DY = 2.42f,
                    PSR = 0.86f,
                    EVEBIT = null,
                    ROE = 10.21f,
                    ROIC = null,
                    LC = 0.76f,
                    DBPL = null,
                    LPA = 2.80f,
                    VPA = 27.80f,
                    DPA = 0.84f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 11.67f,
                    PVPA = 1.20f,
                    PFCO = -1.90f,
                    DY = 3.06f,
                    PSR = 0.83f,
                    EVEBIT = null,
                    ROE = 10.28f,
                    ROIC = null,
                    LC = 0.76f,
                    DBPL = null,
                    LPA = 2.86f,
                    VPA = 27.83f,
                    DPA = 0.85f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 10.36f,
                    PVPA = 1.11f,
                    PFCO = -1.36f,
                    DY = 2.37f,
                    PSR = 0.86f,
                    EVEBIT = null,
                    ROE = 10.70f,
                    ROIC = null,
                    LC = 0.75f,
                    DBPL = null,
                    LPA = 3.07f,
                    VPA = 28.66f,
                    DPA = 0.91f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 11.16f,
                    PVPA = 1.39f,
                    PFCO = -1.29f,
                    DY = 2.97f,
                    PSR = 1.10f,
                    EVEBIT = null,
                    ROE = 12.43f,
                    ROIC = null,
                    LC = 0.75f,
                    DBPL = null,
                    LPA = 3.80f,
                    VPA = 30.55f,
                    DPA = 1.13f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.27f,
                    PVPA = 0.78f,
                    PFCO = 2.28f,
                    DY = 8.80f,
                    PSR = 0.69f,
                    EVEBIT = null,
                    ROE = 14.70f,
                    ROIC = null,
                    LC = 0.80f,
                    DBPL = null,
                    LPA = 3.75f,
                    VPA = 25.50f,
                    DPA = 1.42f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 4.80f,
                    PVPA = 0.68f,
                    PFCO = 2.31f,
                    DY = 7.96f,
                    PSR = 0.66f,
                    EVEBIT = null,
                    ROE = 14.13f,
                    ROIC = null,
                    LC = 0.77f,
                    DBPL = null,
                    LPA = 3.58f,
                    VPA = 25.33f,
                    DPA = 1.27f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.91f,
                    PVPA = 0.88f,
                    PFCO = 2.57f,
                    DY = 5.18f,
                    PSR = 0.75f,
                    EVEBIT = null,
                    ROE = 12.68f,
                    ROIC = null,
                    LC = 0.76f,
                    DBPL = null,
                    LPA = 3.30f,
                    VPA = 26.03f,
                    DPA = 1.08f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 10.14f,
                    PVPA = 1.06f,
                    PFCO = 3.43f,
                    DY = 3.25f,
                    PSR = 0.79f,
                    EVEBIT = null,
                    ROE = 10.40f,
                    ROIC = null,
                    LC = 0.75f,
                    DBPL = null,
                    LPA = 2.77f,
                    VPA = 26.60f,
                    DPA = 0.82f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_BBAS3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 45.68m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 36.89m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 25.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 26.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 43.06m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 29.42m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 23.53m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 30.90m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 28.43m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 16.68m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 14.71m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 19.68m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 24.41m));

            #endregion

            return ativos;
        }
    }
}
