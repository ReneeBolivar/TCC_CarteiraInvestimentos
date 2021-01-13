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
        public static List<Cromossomo> YDUQ3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "YDUQ3",
                Nome = "ESTACIO PARTICIPAÇÕES SA.",
                Setor = Setor.Diversos,
                PrecoAtivoNoPeriodo = ObterAtivos_YDUQ3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 15.03f,
                    PVPA = 2.56f,
                    PFCO = 9.33f,
                    DY = 0.81f,
                    PSR = 2.21f,
                    EVEBIT = 11.23f,
                    ROE = 17.09f,
                    ROIC = 17.34f,
                    LC = 1.87f,
                    DBPL = 0.20f,
                    LPA = 1.57f,
                    VPA = 9.21f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 13.88f,
                    PVPA = 2.56f,
                    PFCO = 9.57f,
                    DY = 1.34f,
                    PSR = 2.26f,
                    EVEBIT = 11.55f,
                    ROE = 18.41f,
                    ROIC = 19.44f,
                    LC = 1.95f,
                    DBPL = 0.14f,
                    LPA = 1.80f,
                    VPA = 9.75f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 11.98f,
                    PVPA = 2.36f,
                    PFCO = 5.89f,
                    DY = 1.30f,
                    PSR = 2.08f,
                    EVEBIT = 9.49f,
                    ROE = 19.72f,
                    ROIC = 20.47f,
                    LC = 2.01f,
                    DBPL = 0.14f,
                    LPA = 1.94f,
                    VPA = 9.83f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.10f,
                    PVPA = 3.26f,
                    PFCO = 8.00f,
                    DY = 6.98f,
                    PSR = 2.34f,
                    EVEBIT = 10.95f,
                    ROE = 24.89f,
                    ROIC = 22.40f,
                    LC = 1.20f,
                    DBPL = 0.32f,
                    LPA = 2.03f,
                    VPA = 8.15f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 13.92f,
                    PVPA = 1.97f,
                    PFCO = 8.66f,
                    DY = 11.15f,
                    PSR = 1.74f,
                    EVEBIT = 11.92f,
                    ROE = 14.12f,
                    ROIC = 12.97f,
                    LC = 1.62f,
                    DBPL = 0.41f,
                    LPA = 1.14f,
                    VPA = 8.05f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.50f,
                    PVPA = 1.70f,
                    PFCO = 9.10f,
                    DY = 11.43f,
                    PSR = 1.55f,
                    EVEBIT = 7.64f,
                    ROE = 20.02f,
                    ROIC = 17.47f,
                    LC = 1.64f,
                    DBPL = 0.38f,
                    LPA = 1.72f,
                    VPA = 8.60f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 18.54f,
                    PVPA = 3.61f,
                    PFCO = 15.46f,
                    DY = 5.31f,
                    PSR = 3.26f,
                    EVEBIT = 15.15f,
                    ROE = 19.44f,
                    ROIC = 18.21f,
                    LC = 2.27f,
                    DBPL = 0.30f,
                    LPA = 1.77f,
                    VPA = 9.08f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 27.16f,
                    PVPA = 4.16f,
                    PFCO = 16.53f,
                    DY = 0.86f,
                    PSR = 3.49f,
                    EVEBIT = 21.37f,
                    ROE = 15.29f,
                    ROIC = 16.03f,
                    LC = 1.97f,
                    DBPL = 0.20f,
                    LPA = 1.34f,
                    VPA = 8.74f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 7.78f,
                    PVPA = 1.34f,
                    PFCO = 8.51f,
                    DY = 2.74f,
                    PSR = 1.50f,
                    EVEBIT = 8.28f,
                    ROE = 17.18f,
                    ROIC = 14.18f,
                    LC = 2.93f,
                    DBPL = 0.29f,
                    LPA = 1.52f,
                    VPA = 8.83f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 16.31f,
                    PVPA = 2.01f,
                    PFCO = 11.04f,
                    DY = 2.22f,
                    PSR = 2.00f,
                    EVEBIT = 15.31f,
                    ROE = 12.36f,
                    ROIC = 10.67f,
                    LC = 2.97f,
                    DBPL = 0.30f,
                    LPA = 1.04f,
                    VPA = 8.42f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 18.36f,
                    PVPA = 2.01f,
                    PFCO = 9.12f,
                    DY = 2.06f,
                    PSR = 2.00f,
                    EVEBIT = 16.14f,
                    ROE = 10.97f,
                    ROIC = 10.18f,
                    LC = 2.42f,
                    DBPL = 0.29f,
                    LPA = 0.97f,
                    VPA = 8.87f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.62f,
                    PVPA = 2.06f,
                    PFCO = 6.00f,
                    DY = 10.99f,
                    PSR = 1.75f,
                    EVEBIT = 12.29f,
                    ROE = 15.12f,
                    ROIC = 13.14f,
                    LC = 1.55f,
                    DBPL = 0.42f,
                    LPA = 1.16f,
                    VPA = 7.66f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_YDUQ3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 25.63m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 31.43m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 22.11m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 22.67m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 22.89m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 14.02m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 13.14m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 27.84m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 29.49m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 9.24m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 13.7m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 14.39m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 13.96m));

            #endregion

            return ativos;
        }
    }
}
