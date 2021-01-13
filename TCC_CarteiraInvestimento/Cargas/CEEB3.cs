using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> CEEB3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "CEEB3",
                Nome = "CIA ELETRICIDADE DA BAHIA",
                Setor = Setor.EnergiaEletrica,
                PrecoAtivoNoPeriodo = ObterAtivos_CEEB3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 32.05f,
                    PVPA = 1.15f,
                    PFCO = 31.55f,
                    DY = 2.42f,
                    PSR = 1.04f,
                    EVEBIT = 13.73f,
                    ROE = 3.59f,
                    ROIC = 6.47f,
                    LC = 1.03f,
                    DBPL = 1.32f,
                    LPA = 0.78f,
                    VPA = 21.74f,
                    DPA = 0.61f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 18.68f,
                    PVPA = 1.15f,
                    PFCO = -7.76f,
                    DY = 1.90f,
                    PSR = 1.10f,
                    EVEBIT = 12.51f,
                    ROE = 6.18f,
                    ROIC = 6.55f,
                    LC = 1.16f,
                    DBPL = 1.52f,
                    LPA = 1.36f,
                    VPA = 22.05f,
                    DPA = 1.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 9.78f,
                    PVPA = 0.96f,
                    PFCO = -5.20f,
                    DY = 1.86f,
                    PSR = 1.22f,
                    EVEBIT = 9.78f,
                    ROE = 9.83f,
                    ROIC = 6.97f,
                    LC = 1.41f,
                    DBPL = 1.43f,
                    LPA = 2.72f,
                    VPA = 27.65f,
                    DPA = 1.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.70f,
                    PVPA = 1.07f,
                    PFCO = 14.25f,
                    DY = 4.45f,
                    PSR = 1.19f,
                    EVEBIT = 9.54f,
                    ROE = 12.27f,
                    ROIC = 8.92f,
                    LC = 1.23f,
                    DBPL = 1.21f,
                    LPA = 3.39f,
                    VPA = 27.66f,
                    DPA = 3.04f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 13.69f,
                    PVPA = 1.43f,
                    PFCO = 8.46f,
                    DY = 5.22f,
                    PSR = 1.07f,
                    EVEBIT = 11.65f,
                    ROE = 10.42f,
                    ROIC = 9.24f,
                    LC = 0.65f,
                    DBPL = 1.72f,
                    LPA = 1.68f,
                    VPA = 16.13f,
                    DPA = 1.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 17.17f,
                    PVPA = 1.57f,
                    PFCO = 3.78f,
                    DY = 5.22f,
                    PSR = 1.10f,
                    EVEBIT = 12.85f,
                    ROE = 9.14f,
                    ROIC = 8.57f,
                    LC = 0.70f,
                    DBPL = 1.87f,
                    LPA = 1.45f,
                    VPA = 15.85f,
                    DPA = 1.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 19.59f,
                    PVPA = 1.47f,
                    PFCO = 2.58f,
                    DY = 5.23f,
                    PSR = 1.02f,
                    EVEBIT = 12.21f,
                    ROE = 7.51f,
                    ROIC = 8.19f,
                    LC = 0.82f,
                    DBPL = 1.86f,
                    LPA = 1.22f,
                    VPA = 16.30f,
                    DPA = 1.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 26.01f,
                    PVPA = 1.45f,
                    PFCO = 14.08f,
                    DY = 2.49f,
                    PSR = 1.00f,
                    EVEBIT = 13.60f,
                    ROE = 5.59f,
                    ROIC = 7.68f,
                    LC = 0.77f,
                    DBPL = 1.69f,
                    LPA = 0.94f,
                    VPA = 16.82f,
                    DPA = 0.61f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 13.53f,
                    PVPA = 1.52f,
                    PFCO = 5.56f,
                    DY = 1.77f,
                    PSR = 1.10f,
                    EVEBIT = 10.02f,
                    ROE = 11.20f,
                    ROIC = 9.70f,
                    LC = 0.97f,
                    DBPL = 1.33f,
                    LPA = 1.87f,
                    VPA = 16.67f,
                    DPA = 0.21f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 14.48f,
                    PVPA = 1.46f,
                    PFCO = 6.11f,
                    DY = 0.14f,
                    PSR = 1.17f,
                    EVEBIT = 9.37f,
                    ROE = 10.07f,
                    ROIC = 10.82f,
                    LC = 0.98f,
                    DBPL = 1.22f,
                    LPA = 1.74f,
                    VPA = 17.23f,
                    DPA = 0.21f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 13.68f,
                    PVPA = 1.40f,
                    PFCO = 5.81f,
                    DY = 2.71f,
                    PSR = 1.08f,
                    EVEBIT = 9.01f,
                    ROE = 10.21f,
                    ROIC = 11.30f,
                    LC = 0.80f,
                    DBPL = 1.32f,
                    LPA = 1.71f,
                    VPA = 16.74f,
                    DPA = 0.21f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 14.38f,
                    PVPA = 1.46f,
                    PFCO = 16.80f,
                    DY = 5.30f,
                    PSR = 1.13f,
                    EVEBIT = 11.65f,
                    ROE = 10.11f,
                    ROIC = 9.33f,
                    LC = 0.71f,
                    DBPL = 1.66f,
                    LPA = 1.62f,
                    VPA = 15.99f,
                    DPA = 1.15f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_CEEB3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 27.82m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 20.91m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 21.25m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 22.05m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 23.1m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 19.13m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 19.14m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 19.49m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 20.39m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 21.03m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 20.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 19.47m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 19.39m));

            #endregion

            return ativos;
        }
    }
}
