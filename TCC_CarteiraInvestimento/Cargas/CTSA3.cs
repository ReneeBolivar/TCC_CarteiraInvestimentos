using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> CTSA3()
        {
            var localList = new List<Cromossomo>();
            
            var empresa = new Empresa
            {
                Nome = "CIA TECIDOS SANTANENSE",
                Codigo = "CTSA3",
                Setor = Setor.TecidosVestuarioCalcados,
                PrecoAtivoNoPeriodo = ObterAtivos_CTSA3()
            };

            #region Compreede todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.66f,
                    PVPA = 0.56f,
                    PFCO = 6.76f,
                    DY = 0.75f,
                    PSR = 0.46f,
                    EVEBIT = 7.26f,
                    ROE = 9.87f,
                    ROIC = 9.00f,
                    LC = 1.15f,
                    DBPL = 0.68f,
                    LPA = 0.68f,
                    VPA = 6.88f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 5.19f,
                    PVPA = 0.79f,
                    PFCO = 42.93f,
                    DY = 58.24f,
                    PSR = 0.51f,
                    EVEBIT = 7.68f,
                    ROE = 15.25f,
                    ROIC = 10.46f,
                    LC = 1.16f,
                    DBPL = 1.03f,
                    LPA = 0.77f,
                    VPA = 5.08f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 7.99f,
                    PVPA = 0.89f,
                    PFCO = -3.06f,
                    DY = 51.83f,
                    PSR = 0.67f,
                    EVEBIT = 9.87f,
                    ROE = 12.84f,
                    ROIC = 8.97f,
                    LC = 1.37f,
                    DBPL = 1.24f,
                    LPA = 1.67f,
                    VPA = 5.23f,
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
                    PL = -78.33f,
                    PVPA = 0.37f,
                    PFCO = 2.65f,
                    DY = 0.00f,
                    PSR = 0.30f,
                    EVEBIT = 21.29f,
                    ROE = -0.47f,
                    ROIC = 2.87f,
                    LC = 1.15f,
                    DBPL = 0.61f,
                    LPA = -0.03f,
                    VPA = 6.32f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 26.90f,
                    PVPA = 0.42f,
                    PFCO = 2.49f,
                    DY = 0.00f,
                    PSR = 0.37f,
                    EVEBIT = 12.51f,
                    ROE = 1.61f,
                    ROIC = 4.62f,
                    LC = 1.16f,
                    DBPL = 0.65f,
                    LPA = 0.10f,
                    VPA = 6.38f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 9.58f,
                    PVPA = 0.55f,
                    PFCO = 4.80f,
                    DY = 0.00f,
                    PSR = 0.44f,
                    EVEBIT = 9.13f,
                    ROE = 5.77f,
                    ROIC = 6.76f,
                    LC = 1.10f,
                    DBPL = 0.65f,
                    LPA = 0.38f,
                    VPA = 6.63f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.82f,
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

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -4.26f,
                    PVPA = 0.36f,
                    PFCO = -7.78f,
                    DY = 0.29f,
                    PSR = 0.33f,
                    EVEBIT = -10.40f,
                    ROE = -8.58f,
                    ROIC = -1.72f,
                    LC = 1.57f,
                    DBPL = 0.48f,
                    LPA = -0.54f,
                    VPA = 6.35f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -2.92f,
                    PVPA = 0.25f,
                    PFCO = -2.80f,
                    DY = 0.00f,
                    PSR = 0.23f,
                    EVEBIT = -9.53f,
                    ROE = -8.45f,
                    ROIC = -1.74f,
                    LC = 1.46f,
                    DBPL = 0.54f,
                    LPA = -0.53f,
                    VPA = 6.28f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -5.05f,
                    PVPA = 0.30f,
                    PFCO = 47.94f,
                    DY = 0.00f,
                    PSR = 0.26f,
                    EVEBIT = -17.04f,
                    ROE = -5.95f,
                    ROIC = -0.31f,
                    LC = 1.45f,
                    DBPL = 0.47f,
                    LPA = -0.37f,
                    VPA = 6.24f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = -20.12f,
                    PVPA = 0.26f,
                    PFCO = 3.39f,
                    DY = 0.00f,
                    PSR = 0.24f,
                    EVEBIT = 40.79f,
                    ROE = -1.28f,
                    ROIC = 1.77f,
                    LC = 1.32f,
                    DBPL = 0.61f,
                    LPA = -0.08f,
                    VPA = 6.30f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_CTSA3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 1.52m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 1.17m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 1.07m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 1.2m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 1.42m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 0.68m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 0.62m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 0.85m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 1.07m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 0.67m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 0.45m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 0.54m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 0.47m));

            #endregion

            return null;
        }
    }
}
