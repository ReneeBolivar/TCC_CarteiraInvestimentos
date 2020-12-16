using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> ELET3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "ELET3",
                Nome = "CENTRAIS ELETRICAS BRASILEIRAS SA.",
                Setor = Setor.EnergiaEletrica,
                PrecoAtivoNoPeriodo = ObterAtivos_ELET3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = -5.62f,
                    PVPA = 0.41f,
                    PFCO = 4.73f,
                    DY = 0.00f,
                    PSR = 1.53f,
                    EVEBIT = 30.12f,
                    ROE = -7.32f,
                    ROIC = 0.93f,
                    LC = 1.09f,
                    DBPL = 1.06f,
                    LPA = -2.31f,
                    VPA = 31.52f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = -34.47f,
                    PVPA = 0.46f,
                    PFCO = 5.83f,
                    DY = 0.00f,
                    PSR = 1.52f,
                    EVEBIT = 14.20f,
                    ROE = -1.35f,
                    ROIC = 2.01f,
                    LC = 1.24f,
                    DBPL = 1.01f,
                    LPA = -0.45f,
                    VPA = 33.59f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = -11.67f,
                    PVPA = 0.74f,
                    PFCO = 7.35f,
                    DY = 0.00f,
                    PSR = 1.65f,
                    EVEBIT = 49.09f,
                    ROE = -6.34f,
                    ROIC = -1.00f,
                    LC = 1.15f,
                    DBPL = 1.02f,
                    LPA = -2.05f,
                    VPA = 32.33f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 3.74f,
                    PVPA = 0.89f,
                    PFCO = 20.59f,
                    DY = 0.00f,
                    PSR = 3.73f,
                    EVEBIT = 5.30f,
                    ROE = 23.68f,
                    ROIC = 14.13f,
                    LC = 1.28f,
                    DBPL = 1.00f,
                    LPA = 9.80f,
                    VPA = 41.41f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 2.66f,
                    PVPA = 0.50f,
                    PFCO = -19.32f,
                    DY = 0.00f,
                    PSR = 1.02f,
                    EVEBIT = 2.49f,
                    ROE = 19.01f,
                    ROIC = 15.83f,
                    LC = 1.04f,
                    DBPL = 1.03f,
                    LPA = 6.44f,
                    VPA = 33.91f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -7.21f,
                    PVPA = 0.58f,
                    PFCO = 42.87f,
                    DY = 0.00f,
                    PSR = 1.74f,
                    EVEBIT = 16.20f,
                    ROE = -8.00f,
                    ROIC = 3.26f,
                    LC = 1.11f,
                    DBPL = 1.02f,
                    LPA = -2.73f,
                    VPA = 34.18f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -6.51f,
                    PVPA = 0.56f,
                    PFCO = 27.76f,
                    DY = 0.00f,
                    PSR = 1.71f,
                    EVEBIT = 17.38f,
                    ROE = -8.59f,
                    ROIC = 2.98f,
                    LC = 1.14f,
                    DBPL = 0.99f,
                    LPA = -2.97f,
                    VPA = 34.62f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = -17.16f,
                    PVPA = 0.71f,
                    PFCO = 12.65f,
                    DY = 0.00f,
                    PSR = 1.86f,
                    EVEBIT = 13.58f,
                    ROE = -4.13f,
                    ROIC = 3.88f,
                    LC = 1.09f,
                    DBPL = 1.09f,
                    LPA = -1.30f,
                    VPA = 31.61f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -0.46f,
                    PVPA = 0.24f,
                    PFCO = 1.06f,
                    DY = 0.00f,
                    PSR = 1.66f,
                    EVEBIT = -2.96f,
                    ROE = -51.84f,
                    ROIC = -19.28f,
                    LC = 0.98f,
                    DBPL = 1.24f,
                    LPA = -14.49f,
                    VPA = 27.94f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -3.15f,
                    PVPA = 0.34f,
                    PFCO = 2.46f,
                    DY = 0.00f,
                    PSR = 1.05f,
                    EVEBIT = 6.93f,
                    ROE = -10.86f,
                    ROIC = -1.19f,
                    LC = 0.87f,
                    DBPL = 0.92f,
                    LPA = -4.08f,
                    VPA = 37.54f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -40.98f,
                    PVPA = 0.51f,
                    PFCO = 4.82f,
                    DY = 0.00f,
                    PSR = 1.18f,
                    EVEBIT = 4.46f,
                    ROE = -1.25f,
                    ROIC = 5.22f,
                    LC = 0.85f,
                    DBPL = 0.90f,
                    LPA = -0.47f,
                    VPA = 37.94f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.02f,
                    PVPA = 0.70f,
                    PFCO = 16.34f,
                    DY = 0.00f,
                    PSR = 1.18f,
                    EVEBIT = 3.90f,
                    ROE = 7.77f,
                    ROIC = 10.37f,
                    LC = 0.94f,
                    DBPL = 1.07f,
                    LPA = 2.53f,
                    VPA = 32.58f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_ELET3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 34.31m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 19.64m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 11.4m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 14.5m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 22.66m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 15.99m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 11.65m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 18.48m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 18.08m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 6.2m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 12.01m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 18.01m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 21.33m));

            #endregion

            return null;
        }
    }
}
