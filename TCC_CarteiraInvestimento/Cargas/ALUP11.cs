using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> ALUP11()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "ALUP11",
                Nome = "ALUPAR INVESTIMENTOS S/A.",
                Setor = Setor.EnergiaEletrica,
                PrecoAtivoNoPeriodo = ObterAtivos_ALUP11()
            };

            #region Compreende todo o ano de 2018

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 11.91f,
                    PVPA = 0.67f,
                    PFCO = 3.41f,
                    DY = 4.04f,
                    PSR = 4.80f,
                    EVEBIT = 6.35f,
                    ROE = 5.59f,
                    ROIC = 9.24f,
                    LC = 2.22f,
                    DBPL = 0.77f,
                    LPA = 1.27f,
                    VPA = 22.68f,
                    DPA = 0.00f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 11.32f,
                    PVPA = 0.68f,
                    PFCO = 3.43f,
                    DY = 3.55f,
                    PSR = 4.71f,
                    EVEBIT = 6.38f,
                    ROE = 5.98f,
                    ROIC = 9.42f,
                    LC = 2.10f,
                    DBPL = 0.73f,
                    LPA = 1.40f,
                    VPA = 23.38f,
                    DPA = 0.00f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.85f,
                    PVPA = 0.61f,
                    PFCO = 3.62f,
                    DY = 3.41f,
                    PSR = 4.11f,
                    EVEBIT = 5.14f,
                    ROE = 6.93f,
                    ROIC = 10.51f,
                    LC = 2.30f,
                    DBPL = 0.70f,
                    LPA = 1.79f,
                    VPA = 25.87f,
                    DPA = 0.00f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 11.83f,
                    PVPA = 0.73f,
                    PFCO = 6.73f,
                    DY = 3.93f,
                    PSR = 5.46f,
                    EVEBIT = 6.20f,
                    ROE = 6.18f,
                    ROIC = 8.04f,
                    LC = 3.26f,
                    DBPL = 1.02f,
                    LPA = 1.55f,
                    VPA = 25.02f,
                    DPA = 0.74f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 15.52f,
                    PVPA = 1.11f,
                    PFCO = 4.33f,
                    DY = 4.20f,
                    PSR = 5.36f,
                    EVEBIT = 15.36f,
                    ROE = 7.14f,
                    ROIC = 12.47f,
                    LC = 1.39f,
                    DBPL = 0.95f,
                    LPA = 1.32f,
                    VPA = 18.48f,
                    DPA = 0.60f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 15.19f,
                    PVPA = 0.81f,
                    PFCO = 3.96f,
                    DY = 2.87f,
                    PSR = 5.05f,
                    EVEBIT = 14.30f,
                    ROE = 5.37f,
                    ROIC = 10.59f,
                    LC = 1.84f,
                    DBPL = 0.76f,
                    LPA = 1.19f,
                    VPA = 22.22f,
                    DPA = 0.60f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.22f,
                    PVPA = 0.82f,
                    PFCO = 3.77f,
                    DY = 2.73f,
                    PSR = 5.19f,
                    EVEBIT = 14.45f,
                    ROE = 6.66f,
                    ROIC = 10.27f,
                    LC = 1.98f,
                    DBPL = 0.78f,
                    LPA = 1.51f,
                    VPA = 22.63f,
                    DPA = 0.60f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.27f,
                    PVPA = 0.78f,
                    PFCO = 3.97f,
                    DY = 2.78f,
                    PSR = 5.24f,
                    EVEBIT = 6.61f,
                    ROE = 5.90f,
                    ROIC = 9.52f,
                    LC = 2.11f,
                    DBPL = 0.85f,
                    LPA = 1.32f,
                    VPA = 22.40f,
                    DPA = 0.60f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 19.80f,
                    PVPA = 0.90f,
                    PFCO = 3.51f,
                    DY = 7.70f,
                    PSR = 4.86f,
                    EVEBIT = 14.15f,
                    ROE = 4.51f,
                    ROIC = 11.13f,
                    LC = 1.31f,
                    DBPL = 1.14f,
                    LPA = 0.75f,
                    VPA = 16.59f,
                    DPA = 0.40f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 15.22f,
                    PVPA = 0.82f,
                    PFCO = 3.11f,
                    DY = 6.22f,
                    PSR = 4.46f,
                    EVEBIT = 12.69f,
                    ROE = 5.39f,
                    ROIC = 12.11f,
                    LC = 1.28f,
                    DBPL = 1.05f,
                    LPA = 0.92f,
                    VPA = 17.01f,
                    DPA = 0.40f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 19.02f,
                    PVPA = 0.88f,
                    PFCO = 3.84f,
                    DY = 5.25f,
                    PSR = 4.89f,
                    EVEBIT = 13.70f,
                    ROE = 4.67f,
                    ROIC = 11.45f,
                    LC = 1.60f,
                    DBPL = 1.03f,
                    LPA = 0.85f,
                    VPA = 18.29f,
                    DPA = 0.40f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.79f,
                    PVPA = 0.94f,
                    PFCO = 3.77f,
                    DY = 4.91f,
                    PSR = 4.93f,
                    EVEBIT = 13.27f,
                    ROE = 6.82f,
                    ROIC = 12.27f,
                    LC = 1.45f,
                    DBPL = 1.00f,
                    LPA = 1.24f,
                    VPA = 18.21f,
                    DPA = 0.60f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_ALUP11()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 22.51m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 16.86m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 14.60m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 15.24m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 17.79m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 18.58m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 16.88m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 17.51m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 17.20m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 11.95m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 12.70m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 14.64m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 15.51m));

            #endregion

            return ativos;
        }
    }
}
