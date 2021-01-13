using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> ENBR3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "ENBR3",
                Nome = "EDP ENERGIAS DO BRASIL S/A",
                Setor = Setor.EnergiaEletrica,
                PrecoAtivoNoPeriodo = ObterAtivos_ENBR3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 11.38f,
                    PVPA = 0.85f,
                    PFCO = 6.15f,
                    DY = 0.90f,
                    PSR = 1.00f,
                    EVEBIT = 7.43f,
                    ROE = 7.46f,
                    ROIC = 8.21f,
                    LC = 1.30f,
                    DBPL = 0.70f,
                    LPA = 1.14f,
                    VPA = 15.26f,
                    DPA = 0.26f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.99f,
                    PVPA = 0.84f,
                    PFCO = 5.18f,
                    DY = 4.37f,
                    PSR = 0.93f,
                    EVEBIT = 7.01f,
                    ROE = 8.37f,
                    ROIC = 8.50f,
                    LC = 1.23f,
                    DBPL = 0.66f,
                    LPA = 1.28f,
                    VPA = 15.30f,
                    DPA = 0.26f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 9.15f,
                    PVPA = 0.90f,
                    PFCO = 5.71f,
                    DY = 4.74f,
                    PSR = 0.96f,
                    EVEBIT = 7.27f,
                    ROE = 9.84f,
                    ROIC = 8.97f,
                    LC = 1.28f,
                    DBPL = 0.65f,
                    LPA = 1.56f,
                    VPA = 15.80f,
                    DPA = 0.26f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.09f,
                    PVPA = 1.07f,
                    PFCO = 5.87f,
                    DY = 8.20f,
                    PSR = 1.18f,
                    EVEBIT = 7.11f,
                    ROE = 13.16f,
                    ROIC = 10.40f,
                    LC = 1.54f,
                    DBPL = 0.77f,
                    LPA = 2.10f,
                    VPA = 15.94f,
                    DPA = 0.72f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 17.01f,
                    PVPA = 0.93f,
                    PFCO = 3.97f,
                    DY = 8.22f,
                    PSR = 1.33f,
                    EVEBIT = 8.77f,
                    ROE = 5.47f,
                    ROIC = 8.60f,
                    LC = 1.19f,
                    DBPL = 0.61f,
                    LPA = 0.82f,
                    VPA = 15.05f,
                    DPA = 0.67f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 15.77f,
                    PVPA = 0.93f,
                    PFCO = 4.33f,
                    DY = 3.92f,
                    PSR = 1.27f,
                    EVEBIT = 8.32f,
                    ROE = 5.86f,
                    ROIC = 8.63f,
                    LC = 1.22f,
                    DBPL = 0.60f,
                    LPA = 0.90f,
                    VPA = 15.29f,
                    DPA = 0.67f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 18.67f,
                    PVPA = 0.90f,
                    PFCO = 5.17f,
                    DY = 3.60f,
                    PSR = 1.11f,
                    EVEBIT = 8.93f,
                    ROE = 4.81f,
                    ROIC = 8.06f,
                    LC = 1.15f,
                    DBPL = 0.57f,
                    LPA = 0.75f,
                    VPA = 15.50f,
                    DPA = 0.67f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.37f,
                    PVPA = 0.91f,
                    PFCO = 5.95f,
                    DY = 0.86f,
                    PSR = 1.04f,
                    EVEBIT = 7.87f,
                    ROE = 6.77f,
                    ROIC = 8.19f,
                    LC = 1.21f,
                    DBPL = 0.67f,
                    LPA = 1.01f,
                    VPA = 14.89f,
                    DPA = 0.26f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.14f,
                    PVPA = 0.98f,
                    PFCO = 4.36f,
                    DY = 1.25f,
                    PSR = 1.30f,
                    EVEBIT = 4.38f,
                    ROE = 19.02f,
                    ROIC = 16.92f,
                    LC = 1.34f,
                    DBPL = 0.82f,
                    LPA = 2.45f,
                    VPA = 21.86f,
                    DPA = 0.50f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.87f,
                    PVPA = 0.88f,
                    PFCO = 3.99f,
                    DY = 4.76f,
                    PSR = 1.39f,
                    EVEBIT = 5.62f,
                    ROE = 8.95f,
                    ROIC = 11.83f,
                    LC = 1.63f,
                    DBPL = 0.64f,
                    LPA = 1.38f,
                    VPA = 15.44f,
                    DPA = 0.50f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.61f,
                    PVPA = 0.91f,
                    PFCO = 3.75f,
                    DY = 4.34f,
                    PSR = 1.41f,
                    EVEBIT = 5.75f,
                    ROE = 10.60f,
                    ROIC = 11.87f,
                    LC = 1.38f,
                    DBPL = 0.61f,
                    LPA = 1.67f,
                    VPA = 15.76f,
                    DPA = 0.50f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 12.18f,
                    PVPA = 0.90f,
                    PFCO = 3.49f,
                    DY = 8.59f,
                    PSR = 1.35f,
                    EVEBIT = 7.12f,
                    ROE = 7.42f,
                    ROIC = 10.19f,
                    LC = 1.17f,
                    DBPL = 0.62f,
                    LPA = 1.10f,
                    VPA = 14.81f,
                    DPA = 0.67f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_ENBR3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 16.45m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 11.9m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 12.88m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 11.86m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 13.68m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 12.38m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 12.58m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 13.42m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 12.51m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 10.12m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 11.66m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 12.33m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 11.88m));

            #endregion

            return ativos;
        }
    }
}
