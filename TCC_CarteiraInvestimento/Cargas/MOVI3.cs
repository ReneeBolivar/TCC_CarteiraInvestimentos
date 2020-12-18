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
        public static List<Cromossomo> MOVI3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "MOVI3",
                Nome = "MOVIDA PARTICIPAÇÕES S.A.",
                Setor = Setor.Diversos,
                PrecoAtivoNoPeriodo = ObterAtivos_MOVI3()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 12.52f,
                    PVPA = 0.91f,
                    PFCO = -1.02f,
                    DY = 1.28f,
                    PSR = 0.67f,
                    EVEBIT = 6.83f,
                    ROE = 7.22f,
                    ROIC = 9.96f,
                    LC = 0.62f,
                    DBPL = 1.33f,
                    LPA = 0.44f,
                    VPA = 6.05f,
                    DPA = 0.10f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 10.28f,
                    PVPA = 0.83f,
                    PFCO = -0.93f,
                    DY = 2.39f,
                    PSR = 0.92f,
                    EVEBIT = 6.44f,
                    ROE = 8.05f,
                    ROIC = 8.73f,
                    LC = 1.08f,
                    DBPL = 1.52f,
                    LPA = 0.57f,
                    VPA = 7.10f,
                    DPA = 0.13f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.13f,
                    PVPA = 1.11f,
                    PFCO = -1.79f,
                    DY = 2.20f,
                    PSR = 1.22f,
                    EVEBIT = 7.59f,
                    ROE = 9.08f,
                    ROIC = 9.70f,
                    LC = 1.14f,
                    DBPL = 1.26f,
                    LPA = 0.70f,
                    VPA = 7.67f,
                    DPA = 0.25f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 14.47f,
                    PVPA = 1.40f,
                    PFCO = -2.27f,
                    DY = 3.49f,
                    PSR = 1.61f,
                    EVEBIT = 9.93f,
                    ROE = 9.63f,
                    ROIC = 8.47f,
                    LC = 0.87f,
                    DBPL = 1.37f,
                    LPA = 0.75f,
                    VPA = 7.77f,
                    DPA = 0.35f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 69.42f,
                    PVPA = 0.00f,
                    PFCO = -17.13f,
                    DY = 0.00f,
                    PSR = 1.21f,
                    EVEBIT = 12.82f,
                    ROE = 0.00f,
                    ROIC = 0.00f,
                    LC = 0.00f,
                    DBPL = 0.00f,
                    LPA = 0.12f,
                    VPA = 0.00f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 58.82f,
                    PVPA = 1.70f,
                    PFCO = -6.40f,
                    DY = 0.00f,
                    PSR = 1.40f,
                    EVEBIT = 15.29f,
                    ROE = 2.91f,
                    ROIC = 6.64f,
                    LC = 0.74f,
                    DBPL = 1.11f,
                    LPA = 0.17f,
                    VPA = 5.87f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 45.39f,
                    PVPA = 1.38f,
                    PFCO = -2.10f,
                    DY = 0.00f,
                    PSR = 1.15f,
                    EVEBIT = 13.29f,
                    ROE = 2.96f,
                    ROIC = 5.78f,
                    LC = 0.78f,
                    DBPL = 1.54f,
                    LPA = 0.18f,
                    VPA = 5.94f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 25.45f,
                    PVPA = 1.31f,
                    PFCO = -1.65f,
                    DY = 1.00f,
                    PSR = 1.10f,
                    EVEBIT = 10.96f,
                    ROE = 5.17f,
                    ROIC = 7.23f,
                    LC = 0.72f,
                    DBPL = 1.45f,
                    LPA = 0.31f,
                    VPA = 6.02f,
                    DPA = 0.07f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_MOVI3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 10.63m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 6.88m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 5.18m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 5.64m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 8.42m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 7.89m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 9.47m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 7.94m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 6.68m));

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
