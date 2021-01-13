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
        public static List<Cromossomo> MGLU3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "MGLU3",
                Nome = "MAGAZINE LUIZA SA.",
                Setor = Setor.Comercio,
                PrecoAtivoNoPeriodo = ObterAtivos_MGLU3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 46.92f,
                    PVPA = 10.97f,
                    PFCO = 42.39f,
                    DY = 1.44f,
                    PSR = 1.79f,
                    EVEBIT = 23.27f,
                    ROE = 23.34f,
                    ROIC = 28.54f,
                    LC = 1.32f,
                    DBPL = 0.40f,
                    LPA = 2.51f,
                    VPA = 10.74f,
                    DPA = 0.39f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 42.68f,
                    PVPA = 10.67f,
                    PFCO = 40.84f,
                    DY = 0.52f,
                    PSR = 1.72f,
                    EVEBIT = 22.48f,
                    ROE = 24.96f,
                    ROIC = 30.67f,
                    LC = 1.30f,
                    DBPL = 0.27f,
                    LPA = 2.87f,
                    VPA = 11.48f,
                    DPA = 0.39f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 57.81f,
                    PVPA = 14.34f,
                    PFCO = 48.53f,
                    DY = 0.54f,
                    PSR = 2.29f,
                    EVEBIT = 31.65f,
                    ROE = 24.80f,
                    ROIC = 29.62f,
                    LC = 1.32f,
                    DBPL = 0.25f,
                    LPA = 3.01f,
                    VPA = 12.13f,
                    DPA = 0.39f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 55.22f,
                    PVPA = 14.31f,
                    PFCO = 26.65f,
                    DY = 0.47f,
                    PSR = 2.13f,
                    EVEBIT = 29.95f,
                    ROE = 25.94f,
                    ROIC = 32.34f,
                    LC = 1.19f,
                    DBPL = 0.20f,
                    LPA = 3.13f,
                    VPA = 12.08f,
                    DPA = 0.95f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 27.37f,
                    PVPA = 5.61f,
                    PFCO = 10.45f,
                    DY = 0.00f,
                    PSR = 0.47f,
                    EVEBIT = 6.96f,
                    ROE = 20.50f,
                    ROIC = 29.21f,
                    LC = 1.07f,
                    DBPL = 2.31f,
                    LPA = 6.47f,
                    VPA = 31.56f,
                    DPA = 0.57f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 30.19f,
                    PVPA = 8.16f,
                    PFCO = 7.76f,
                    DY = 3.28f,
                    PSR = 0.64f,
                    EVEBIT = 9.02f,
                    ROE = 27.02f,
                    ROIC = 33.21f,
                    LC = 1.01f,
                    DBPL = 1.85f,
                    LPA = 1.06f,
                    VPA = 3.92f,
                    DPA = 0.06f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 56.89f,
                    PVPA = 17.75f,
                    PFCO = 32.53f,
                    DY = 1.37f,
                    PSR = 1.44f,
                    EVEBIT = 19.62f,
                    ROE = 31.27f,
                    ROIC = 29.97f,
                    LC = 1.11f,
                    DBPL = 1.86f,
                    LPA = 1.41f,
                    VPA = 4.52f,
                    DPA = 0.06f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 45.44f,
                    PVPA = 8.52f,
                    PFCO = 907.11f,
                    DY = 1.76f,
                    PSR = 1.51f,
                    EVEBIT = 19.00f,
                    ROE = 18.76f,
                    ROIC = 27.15f,
                    LC = 1.27f,
                    DBPL = 0.42f,
                    LPA = 2.04f,
                    VPA = 10.88f,
                    DPA = 0.39f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -10.02f,
                    PVPA = 0.95f,
                    PFCO = 1.23f,
                    DY = 0.36f,
                    PSR = 0.19f,
                    EVEBIT = 4.72f,
                    ROE = -9.52f,
                    ROIC = 17.81f,
                    LC = 1.14f,
                    DBPL = 2.66f,
                    LPA = -2.92f,
                    VPA = 30.69f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -14.92f,
                    PVPA = 1.23f,
                    PFCO = 2.51f,
                    DY = 0.00f,
                    PSR = 0.18f,
                    EVEBIT = 4.75f,
                    ROE = -8.27f,
                    ROIC = 19.38f,
                    LC = 1.03f,
                    DBPL = 2.51f,
                    LPA = -2.58f,
                    VPA = 31.20f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -139.09f,
                    PVPA = 2.38f,
                    PFCO = 5.81f,
                    DY = 0.00f,
                    PSR = 0.26f,
                    EVEBIT = 5.66f,
                    ROE = -1.71f,
                    ROIC = 20.67f,
                    LC = 1.02f,
                    DBPL = 2.52f,
                    LPA = -0.55f,
                    VPA = 32.20f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 26.54f,
                    PVPA = 3.24f,
                    PFCO = 8.57f,
                    DY = 0.00f,
                    PSR = 0.35f,
                    EVEBIT = 4.69f,
                    ROE = 12.22f,
                    ROIC = 23.09f,
                    LC = 1.07f,
                    DBPL = 2.61f,
                    LPA = 4.00f,
                    VPA = 32.75f,
                    DPA = 0.57f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_MGLU3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 5.37m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 3.02m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 3.96m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 3.79m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 5.61m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 0.68m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 0.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 2.28m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 2.48m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 0.11m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 0.15m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 0.29m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 0.41m));

            #endregion

            return ativos;
        }
    }
}
