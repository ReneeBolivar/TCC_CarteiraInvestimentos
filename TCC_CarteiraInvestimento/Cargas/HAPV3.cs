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
        public static List<Cromossomo> HAPV3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "HAPV3",
                Nome = "HAPVIDA PARTICIPAÇÕES E INVESTIMENTOS S.A.",
                Setor = Setor.Saude,
                PrecoAtivoNoPeriodo = ObterAtivos_HAPV3()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.00f,
                    PSR = 0.00f,
                    EVEBIT = -0.87f,
                    ROE = 125.78f,
                    ROIC = 106.67f,
                    LC = 0.88f,
                    DBPL = 0.00f,
                    LPA = 1.28f,
                    VPA = 1.02f,
                    DPA = 0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 19.79f,
                    PVPA = 5.97f,
                    PFCO = 21.53f,
                    DY = 0.00f,
                    PSR = 3.32f,
                    EVEBIT = 15.37f,
                    ROE = 30.07f,
                    ROIC = 25.04f,
                    LC = 1.04f,
                    DBPL = 0.00f,
                    LPA = 1.51f,
                    VPA = 5.01f,
                    DPA = 0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 13.41f,
                    PVPA = 4.54f,
                    PFCO = 16.20f,
                    DY = 0.00f,
                    PSR = 2.24f,
                    EVEBIT = 10.75f,
                    ROE = 33.80f,
                    ROIC = 27.39f,
                    LC = 1.32f,
                    DBPL = 0.00f,
                    LPA = 1.79f,
                    VPA = 5.29f,
                    DPA = 0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 26.67f,
                    PVPA = 5.81f,
                    PFCO = 40.58f,
                    DY = 0.00f,
                    PSR = 4.58f,
                    EVEBIT = 23.06f,
                    ROE = 21.84f,
                    ROIC = 17.10f,
                    LC = 1.29f,
                    DBPL = 0.00f,
                    LPA = 1.17f,
                    VPA = 5.37f,
                    DPA = 0.28f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.00f,
                    PSR = 0.00f,
                    EVEBIT = 0.00f,
                    ROE = 0.00f,
                    ROIC = 0.00f,
                    LC = 0.00f,
                    DBPL = 0.00f,
                    LPA = 0.00f,
                    VPA = 0.00f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.00f,
                    PSR = 0.00f,
                    EVEBIT = 0.00f,
                    ROE = 0.00f,
                    ROIC = 0.00f,
                    LC = 0.00f,
                    DBPL = 0.00f,
                    LPA = 0.00f,
                    VPA = 0.00f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.00f,
                    PSR = 0.00f,
                    EVEBIT = 0.00f,
                    ROE = 0.00f,
                    ROIC = 0.00f,
                    LC = 0.00f,
                    DBPL = 0.00f,
                    LPA = 0.00f,
                    VPA = 0.00f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.00f,
                    PSR = 0.00f,
                    EVEBIT = -1.16f,
                    ROE = 137.45f,
                    ROIC = 114.21f,
                    LC = 0.83f,
                    DBPL = 0.00f,
                    LPA = 0.97f,
                    VPA = 0.70f,
                    DPA = 0.04f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_HAPV3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 6.07m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 5.87m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 4.71m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 6.16m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 0m));

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
