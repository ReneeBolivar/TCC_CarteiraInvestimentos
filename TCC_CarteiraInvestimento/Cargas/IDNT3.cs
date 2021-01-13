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
        public static List<Cromossomo> IDNT3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "IDNT3",
                Nome = "IDEIASNET SA.",
                Setor = Setor.ProgramasServicos,
                PrecoAtivoNoPeriodo = ObterAtivos_IDNT3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 16.67f,
                    PVPA = 250.00f,
                    PFCO = -7.23f,
                    DY = 0.00f,
                    PSR = 484.49f,
                    EVEBIT = 7.74f,
                    ROE = 1300.53f,
                    ROIC = 2642.53f,
                    LC = 0.36f,
                    DBPL = 0.00f,
                    LPA = 0.45f,
                    VPA = 0.03f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = -10.93f,
                    PVPA = 24.94f,
                    PFCO = -14.40f,
                    DY = 0.00f,
                    PSR = 0.00f,
                    EVEBIT = -9.25f,
                    ROE = -230.36f,
                    ROIC = -255.60f,
                    LC = 0.27f,
                    DBPL = 0.00f,
                    LPA = -0.73f,
                    VPA = 0.32f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = -31.63f,
                    PVPA = 23.12f,
                    PFCO = -9.46f,
                    DY = 0.00f,
                    PSR = 0.00f,
                    EVEBIT = -20.25f,
                    ROE = -75.12f,
                    ROIC = -95.58f,
                    LC = 0.34f,
                    DBPL = 0.00f,
                    LPA = -0.19f,
                    VPA = 0.26f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 4.32f,
                    PVPA = 3.68f,
                    PFCO = -4.18f,
                    DY = 0.00f,
                    PSR = 0.00f,
                    EVEBIT = 4.71f,
                    ROE = 85.01f,
                    ROIC = 81.26f,
                    LC = 1.30f,
                    DBPL = 0.00f,
                    LPA = 0.69f,
                    VPA = 0.81f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 0.90f,
                    PVPA = -11.06f,
                    PFCO = -0.53f,
                    DY = 0.00f,
                    PSR = -2.06f,
                    EVEBIT = 0.57f,
                    ROE = -1226.01f,
                    ROIC = -1433.45f,
                    LC = 31.73f,
                    DBPL = 0.00f,
                    LPA = 6.17f,
                    VPA = -0.50f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 1.07f,
                    PVPA = 8.18f,
                    PFCO = -0.82f,
                    DY = 0.00f,
                    PSR = -1.48f,
                    EVEBIT = 0.76f,
                    ROE = 770.26f,
                    ROIC = 950.57f,
                    LC = 1.27f,
                    DBPL = 0.00f,
                    LPA = 8.21f,
                    VPA = 1.07f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 1.30f,
                    PVPA = 22.11f,
                    PFCO = -0.96f,
                    DY = 0.00f,
                    PSR = -1.19f,
                    EVEBIT = 1.01f,
                    ROE = 1690.73f,
                    ROIC = 2102.84f,
                    LC = 0.28f,
                    DBPL = 0.00f,
                    LPA = 8.01f,
                    VPA = 0.47f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.50f,
                    PVPA = 65.20f,
                    PFCO = -9.39f,
                    DY = 0.00f,
                    PSR = 328.89f,
                    EVEBIT = 6.90f,
                    ROE = 784.22f,
                    ROIC = 889.47f,
                    LC = 0.34f,
                    DBPL = 0.00f,
                    LPA = 1.15f,
                    VPA = 0.15f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -0.92f,
                    PVPA = -1.18f,
                    PFCO = 1.67f,
                    DY = 0.00f,
                    PSR = 0.31f,
                    EVEBIT = -1.46f,
                    ROE = 129.28f,
                    ROIC = 302.09f,
                    LC = 0.55f,
                    DBPL = -0.63f,
                    LPA = -10.26f,
                    VPA = -7.93f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -0.69f,
                    PVPA = -0.75f,
                    PFCO = 1.54f,
                    DY = 0.00f,
                    PSR = 0.35f,
                    EVEBIT = -1.15f,
                    ROE = 108.26f,
                    ROIC = 242.78f,
                    LC = 0.50f,
                    DBPL = -0.58f,
                    LPA = -9.34f,
                    VPA = -8.59f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -0.77f,
                    PVPA = -1.69f,
                    PFCO = 1.85f,
                    DY = 0.00f,
                    PSR = 0.46f,
                    EVEBIT = -0.73f,
                    ROE = 218.66f,
                    ROIC = -823.24f,
                    LC = 2.71f,
                    DBPL = -1.24f,
                    LPA = -4.13f,
                    VPA = -1.89f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 0.67f,
                    PVPA = -4.71f,
                    PFCO = -0.39f,
                    DY = 0.00f,
                    PSR = 74.51f,
                    EVEBIT = 0.36f,
                    ROE = -706.78f,
                    ROIC = -888.22f,
                    LC = 22.50f,
                    DBPL = 0.00f,
                    LPA = 6.42f,
                    VPA = -0.91f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_IDNT3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 2.98m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 9.49m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 6.68m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 7.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 5.93m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 5.53m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 9.79m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 6.58m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 10.39m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 9.39m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 6.44m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 3.20m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 4.29m));

            #endregion

            return ativos;
        }
    }
}
