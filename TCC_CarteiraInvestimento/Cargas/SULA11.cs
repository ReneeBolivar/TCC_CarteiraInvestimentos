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
        public static List<Cromossomo> SULA11()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "SULA11",
                Nome = "SUL AMERICA S/A.",
                Setor = Setor.PrevidenciaSeguros,
                PrecoAtivoNoPeriodo = ObterAtivos_SULA11()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 7.62f,
                    PVPA = 1.04f,
                    PFCO = 556.00f,
                    DY = 2.40f,
                    PSR = 0.41f,
                    EVEBIT = -12.84f,
                    ROE = 13.57f,
                    ROIC = 0.70f,
                    LC = 2.00f,
                    DBPL = 0.28f,
                    LPA = 2.31f,
                    VPA = 17.00f,
                    DPA = 0.60f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 10.53f,
                    PVPA = 1.51f,
                    PFCO = 9.15f,
                    DY = 2.88f,
                    PSR = 0.54f,
                    EVEBIT = -6.19f,
                    ROE = 14.34f,
                    ROIC = 2.05f,
                    LC = 1.98f,
                    DBPL = 0.25f,
                    LPA = 2.47f,
                    VPA = 17.21f,
                    DPA = 0.60f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 10.27f,
                    PVPA = 1.56f,
                    PFCO = 19.81f,
                    DY = 2.02f,
                    PSR = 0.56f,
                    EVEBIT = -5.00f,
                    ROE = 15.21f,
                    ROIC = 3.68f,
                    LC = 1.94f,
                    DBPL = 0.24f,
                    LPA = 2.71f,
                    VPA = 17.83f,
                    DPA = 0.60f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 11.20f,
                    PVPA = 1.62f,
                    PFCO = 23.84f,
                    DY = 2.02f,
                    PSR = 0.56f,
                    EVEBIT = -5.21f,
                    ROE = 14.39f,
                    ROIC = 3.73f,
                    LC = 1.89f,
                    DBPL = 0.23f,
                    LPA = 2.66f,
                    VPA = 18.45f,
                    DPA = 0.70f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 7.91f,
                    PVPA = 1.09f,
                    PFCO = -16.57f,
                    DY = 3.19f,
                    PSR = 0.41f,
                    EVEBIT = 22.21f,
                    ROE = 13.81f,
                    ROIC = -3.83f,
                    LC = 1.94f,
                    DBPL = 0.24f,
                    LPA = 2.11f,
                    VPA = 15.26f,
                    DPA = 0.52f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.98f,
                    PVPA = 1.15f,
                    PFCO = -69.55f,
                    DY = 3.05f,
                    PSR = 0.41f,
                    EVEBIT = 37.43f,
                    ROE = 12.77f,
                    ROIC = -4.30f,
                    LC = 1.93f,
                    DBPL = 0.21f,
                    LPA = 1.97f,
                    VPA = 15.45f,
                    DPA = 0.49f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 9.42f,
                    PVPA = 1.17f,
                    PFCO = 986.94f,
                    DY = 2.98f,
                    PSR = 0.42f,
                    EVEBIT = 31.98f,
                    ROE = 12.40f,
                    ROIC = -3.54f,
                    LC = 1.91f,
                    DBPL = 0.21f,
                    LPA = 1.98f,
                    VPA = 15.98f,
                    DPA = 0.52f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.91f,
                    PVPA = 1.36f,
                    PFCO = -34.81f,
                    DY = 3.23f,
                    PSR = 0.50f,
                    EVEBIT = -11.09f,
                    ROE = 13.71f,
                    ROIC = -0.56f,
                    LC = 1.93f,
                    DBPL = 0.28f,
                    LPA = 2.27f,
                    VPA = 16.55f,
                    DPA = 0.60f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_SULA11()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 27.82m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 19.91m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 16.72m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 23.79m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 26.18m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 14.92m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 15.81m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 15.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 16.66m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 12.07m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 11.76m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 12.2m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 13.7m));

            #endregion

            return ativos;
        }
    }
}
