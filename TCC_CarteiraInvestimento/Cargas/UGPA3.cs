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
        public static List<Cromossomo> UGPA3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "UGPA3",
                Nome = "ULTRAPAR PARTICIPAÇÕES SA.",
                Setor = Setor.HoldingsDiversificadas,
                PrecoAtivoNoPeriodo = ObterAtivos_UGPA3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 20.65f,
                    PVPA = 2.79f,
                    PFCO = 14.98f,
                    DY = 2.47f,
                    PSR = 0.47f,
                    EVEBIT = 14.49f,
                    ROE = 13.52f,
                    ROIC = 7.16f,
                    LC = 2.74f,
                    DBPL = 1.56f,
                    LPA = 2.30f,
                    VPA = 17.01f,
                    DPA = 1.72f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 16.30f,
                    PVPA = 2.17f,
                    PFCO = 12.58f,
                    DY = 3.81f,
                    PSR = 0.37f,
                    EVEBIT = 12.66f,
                    ROE = 13.33f,
                    ROIC = 6.83f,
                    LC = 2.27f,
                    DBPL = 1.57f,
                    LPA = 2.29f,
                    VPA = 17.20f,
                    DPA = 1.72f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 27.42f,
                    PVPA = 3.00f,
                    PFCO = 14.65f,
                    DY = 3.91f,
                    PSR = 0.46f,
                    EVEBIT = 19.50f,
                    ROE = 10.95f,
                    ROIC = 5.51f,
                    LC = 2.35f,
                    DBPL = 1.63f,
                    LPA = 1.88f,
                    VPA = 17.19f,
                    DPA = 1.44f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 22.71f,
                    PVPA = 2.67f,
                    PFCO = 9.05f,
                    DY = 2.74f,
                    PSR = 0.43f,
                    EVEBIT = 18.34f,
                    ROE = 11.74f,
                    ROIC = 4.98f,
                    LC = 2.56f,
                    DBPL = 1.55f,
                    LPA = 2.07f,
                    VPA = 17.61f,
                    DPA = 1.24f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 25.76f,
                    PVPA = 4.52f,
                    PFCO = 12.89f,
                    DY = 2.31f,
                    PSR = 0.63f,
                    EVEBIT = 15.36f,
                    ROE = 17.51f,
                    ROIC = 11.58f,
                    LC = 2.33f,
                    DBPL = 1.25f,
                    LPA = 2.78f,
                    VPA = 15.85f,
                    DPA = 1.64f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 29.93f,
                    PVPA = 4.73f,
                    PFCO = 13.85f,
                    DY = 2.19f,
                    PSR = 0.68f,
                    EVEBIT = 17.69f,
                    ROE = 15.83f,
                    ROIC = 9.69f,
                    LC = 2.51f,
                    DBPL = 1.37f,
                    LPA = 2.56f,
                    VPA = 16.20f,
                    DPA = 1.64f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 26.04f,
                    PVPA = 4.56f,
                    PFCO = 14.62f,
                    DY = 2.28f,
                    PSR = 0.67f,
                    EVEBIT = 16.39f,
                    ROE = 17.53f,
                    ROIC = 9.72f,
                    LC = 2.51f,
                    DBPL = 1.43f,
                    LPA = 2.88f,
                    VPA = 16.46f,
                    DPA = 1.71f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 25.09f,
                    PVPA = 4.06f,
                    PFCO = 17.33f,
                    DY = 2.29f,
                    PSR = 0.62f,
                    EVEBIT = 16.21f,
                    ROE = 16.20f,
                    ROIC = 8.79f,
                    LC = 2.17f,
                    DBPL = 1.40f,
                    LPA = 2.83f,
                    VPA = 17.47f,
                    DPA = 1.72f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_UGPA3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 22.93m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 33.71m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 21.84m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 17.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 25.61m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 33.23m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 35.96m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 35.37m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 35.21m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 31.62m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 32.21m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 32.52m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 31.33m));

            #endregion

            return ativos;
        }
    }
}
