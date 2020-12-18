using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> TAEE11()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "TAEE11",
                Nome = "TRANSMISSORA ALIANÇA DE ENERGIA ELÉTRICA S.A.",
                Setor = Setor.EnergiaEletrica,
                PrecoAtivoNoPeriodo = ObterAtivos_TAEE11()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.85f,
                    PVPA = 1.43f,
                    PFCO = 4.65f,
                    DY = 8.13f,
                    PSR = 8.64f,
                    EVEBIT = 10.32f,
                    ROE = 14.55f,
                    ROIC = 11.40f,
                    LC = 3.40f,
                    DBPL = 0.67f,
                    LPA = 1.93f,
                    VPA = 13.25f,
                    DPA = 1.26f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.10f,
                    PVPA = 1.56f,
                    PFCO = 5.05f,
                    DY = 10.38f,
                    PSR = 7.70f,
                    EVEBIT = 8.65f,
                    ROE = 19.30f,
                    ROIC = 13.97f,
                    LC = 3.03f,
                    DBPL = 0.71f,
                    LPA = 2.47f,
                    VPA = 12.80f,
                    DPA = 1.48f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 7.85f,
                    PVPA = 1.78f,
                    PFCO = 6.32f,
                    DY = 11.08f,
                    PSR = 7.87f,
                    EVEBIT = 8.41f,
                    ROE = 22.63f,
                    ROIC = 15.08f,
                    LC = 3.80f,
                    DBPL = 0.83f,
                    LPA = 2.97f,
                    VPA = 13.10f,
                    DPA = 1.75f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.97f,
                    PVPA = 1.87f,
                    PFCO = 7.14f,
                    DY = 11.81f,
                    PSR = 6.98f,
                    EVEBIT = 8.27f,
                    ROE = 23.43f,
                    ROIC = 16.29f,
                    LC = 2.98f,
                    DBPL = 0.72f,
                    LPA = 3.11f,
                    VPA = 13.27f,
                    DPA = 2.32f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.77f,
                    PVPA = 1.75f,
                    PFCO = 4.92f,
                    DY = 11.86f,
                    PSR = 7.81f,
                    EVEBIT = 8.84f,
                    ROE = 17.96f,
                    ROIC = 14.60f,
                    LC = 2.08f,
                    DBPL = 0.74f,
                    LPA = 2.35f,
                    VPA = 13.09f,
                    DPA = 1.77f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 11.24f,
                    PVPA = 1.80f,
                    PFCO = 4.59f,
                    DY = 9.81f,
                    PSR = 8.59f,
                    EVEBIT = 10.43f,
                    ROE = 15.95f,
                    ROIC = 12.64f,
                    LC = 1.90f,
                    DBPL = 0.81f,
                    LPA = 1.96f,
                    VPA = 12.27f,
                    DPA = 1.64f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 13.82f,
                    PVPA = 1.80f,
                    PFCO = 4.88f,
                    DY = 7.98f,
                    PSR = 9.92f,
                    EVEBIT = 13.13f,
                    ROE = 13.03f,
                    ROIC = 10.38f,
                    LC = 1.94f,
                    DBPL = 0.81f,
                    LPA = 1.61f,
                    VPA = 12.35f,
                    DPA = 1.27f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 11.06f,
                    PVPA = 1.65f,
                    PFCO = 4.87f,
                    DY = 8.27f,
                    PSR = 9.07f,
                    EVEBIT = 10.92f,
                    ROE = 14.91f,
                    ROIC = 11.84f,
                    LC = 3.02f,
                    DBPL = 0.69f,
                    LPA = 1.88f,
                    VPA = 12.62f,
                    DPA = 1.26f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 7.23f,
                    PVPA = 1.50f,
                    PFCO = 4.26f,
                    DY = 11.03f,
                    PSR = 6.33f,
                    EVEBIT = 6.18f,
                    ROE = 20.76f,
                    ROIC = 17.52f,
                    LC = 4.34f,
                    DBPL = 0.76f,
                    LPA = 2.79f,
                    VPA = 13.44f,
                    DPA = 1.46f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 7.14f,
                    PVPA = 1.54f,
                    PFCO = 4.29f,
                    DY = 15.97f,
                    PSR = 6.39f,
                    EVEBIT = 6.46f,
                    ROE = 21.61f,
                    ROIC = 17.58f,
                    LC = 4.20f,
                    DBPL = 0.82f,
                    LPA = 2.69f,
                    VPA = 12.46f,
                    DPA = 2.10f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 7.34f,
                    PVPA = 1.68f,
                    PFCO = 4.54f,
                    DY = 12.72f,
                    PSR = 6.74f,
                    EVEBIT = 6.74f,
                    ROE = 22.87f,
                    ROIC = 18.00f,
                    LC = 3.94f,
                    DBPL = 0.84f,
                    LPA = 2.86f,
                    VPA = 12.52f,
                    DPA = 2.68f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.30f,
                    PVPA = 1.66f,
                    PFCO = 4.43f,
                    DY = 13.04f,
                    PSR = 6.85f,
                    EVEBIT = 7.54f,
                    ROE = 20.01f,
                    ROIC = 16.62f,
                    LC = 1.82f,
                    DBPL = 0.76f,
                    LPA = 2.50f,
                    VPA = 12.50f,
                    DPA = 1.77f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_TAEE11()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 21.05m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 16.23m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 14.78m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 16.19m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 20.02m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 15.91m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 15.97m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 16.24m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 15.96m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 12.69m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 12.64m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 14.16m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 14.36m));

            #endregion

            return null;
        }
    }
}
