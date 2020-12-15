using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> CEDO3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Nome = "COMPANHIA DE FIAÇÃO E TECIDOS CEDRO E CACHOEIRA",
                Codigo = "CEDO3",
                Setor = Setor.TecidosVestuarioCalcados,
                PrecoAtivoNoPeriodo = ObterAtivos_CEDO3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 0.93f,
                    PVPA = 0.55f,
                    PFCO = -8.02f,
                    DY = 0.00f,
                    PSR = 0.44f,
                    EVEBIT = 3.94f,
                    ROE = 59.40f,
                    ROIC = 31.64f,
                    LC = 0.94f,
                    DBPL = 1.46f,
                    LPA = 9.69f,
                    VPA = 16.32f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 0.89f,
                    PVPA = 0.40f,
                    PFCO = 3.33f,
                    DY = 0.00f,
                    PSR = 0.36f,
                    EVEBIT = 4.00f,
                    ROE = 44.60f,
                    ROIC = 22.46f,
                    LC = 0.92f,
                    DBPL = 1.50f,
                    LPA = 7.29f,
                    VPA = 16.35f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 1.37f,
                    PVPA = 0.44f,
                    PFCO = -12.34f,
                    DY = 0.00f,
                    PSR = 0.36f,
                    EVEBIT = 5.68f,
                    ROE = 32.12f,
                    ROIC = 16.78f,
                    LC = 0.92f,
                    DBPL = 1.55f,
                    LPA = 4.95f,
                    VPA = 15.40f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 1.23f,
                    PVPA = 0.29f,
                    PFCO = -1.61f,
                    DY = 0.00f,
                    PSR = 0.32f,
                    EVEBIT = 4.89f,
                    ROE = 23.29f,
                    ROIC = 12.30f,
                    LC = 1.04f,
                    DBPL = 1.23f,
                    LPA = 4.86f,
                    VPA = 20.87f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -0.38f,
                    PVPA = 0.79f,
                    PFCO = -11.22f,
                    DY = 0.00f,
                    PSR = 0.37f,
                    EVEBIT = -4.44f,
                    ROE = -207.33f,
                    ROIC = -20.19f,
                    LC = 0.75f,
                    DBPL = 3.68f,
                    LPA = -13.07f,
                    VPA = 6.30f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -0.81f,
                    PVPA = 0.72f,
                    PFCO = -3.98f,
                    DY = 0.00f,
                    PSR = 0.35f,
                    EVEBIT = -8.59f,
                    ROE = -88.93f,
                    ROIC = -0.68f,
                    LC = 0.87f,
                    DBPL = 2.59f,
                    LPA = -7.99f,
                    VPA = 8.99f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -2.29f,
                    PVPA = 1.04f,
                    PFCO = 6.18f,
                    DY = 0.00f,
                    PSR = 0.46f,
                    EVEBIT = -19.38f,
                    ROE = -45.41f,
                    ROIC = 6.48f,
                    LC = 1.05f,
                    DBPL = 2.10f,
                    LPA = -4.80f,
                    VPA = 10.57f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 1.15f,
                    PVPA = 0.00f,
                    PFCO = 15.26f,
                    DY = 0.00f,
                    PSR = 0.15f,
                    EVEBIT = 2.02f,
                    ROE = 0.00f,
                    ROIC = 155.91f,
                    LC = 0.99f,
                    DBPL = 0.00f,
                    LPA = 8.27f,
                    VPA = 0.00f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -0.71f,
                    PVPA = 0.41f,
                    PFCO = 30.52f,
                    DY = 0.00f,
                    PSR = 0.59f,
                    EVEBIT = -3.90f,
                    ROE = -57.68f,
                    ROIC = -17.18f,
                    LC = 0.90f,
                    DBPL = 1.15f,
                    LPA = -11.26f,
                    VPA = 19.52f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -0.66f,
                    PVPA = 0.47f,
                    PFCO = -14.67f,
                    DY = 0.00f,
                    PSR = 0.53f,
                    EVEBIT = -3.91f,
                    ROE = -71.46f,
                    ROIC = -18.59f,
                    LC = 0.80f,
                    DBPL = 1.36f,
                    LPA = -12.06f,
                    VPA = 16.87f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -0.67f,
                    PVPA = 0.46f,
                    PFCO = -4.29f,
                    DY = 0.00f,
                    PSR = 0.53f,
                    EVEBIT = -5.74f,
                    ROE = -68.43f,
                    ROIC = -12.00f,
                    LC = 0.91f,
                    DBPL = 1.51f,
                    LPA = -10.37f,
                    VPA = 15.15f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = -0.43f,
                    PVPA = 0.77f,
                    PFCO = -3.12f,
                    DY = 0.00f,
                    PSR = 0.40f,
                    EVEBIT = -3.65f,
                    ROE = -180.95f,
                    ROIC = -24.41f,
                    LC = 0.76f,
                    DBPL = 3.04f,
                    LPA = -14.03f,
                    VPA = 7.75f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_CEDO3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 6m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 9.7m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 6.47m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 0m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 5m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 4.9m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 5.01m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 11m));

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
