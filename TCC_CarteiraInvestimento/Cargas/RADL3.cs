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
        public static List<Cromossomo> RADL3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "RADL3",
                Nome = "RAIA DROGASIL S.A.",
                Setor = Setor.ComercioDistribuicao,
                PrecoAtivoNoPeriodo = ObterAtivos_RADL3()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 44.31f,
                    PVPA = 7.26f,
                    PFCO = 33.88f,
                    DY = 0.82f,
                    PSR = 1.75f,
                    EVEBIT = 29.71f,
                    ROE = 16.38f,
                    ROIC = 16.39f,
                    LC = 1.53f,
                    DBPL = 0.18f,
                    LPA = 1.60f,
                    VPA = 9.76f,
                    DPA = 0.61f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 45.27f,
                    PVPA = 7.22f,
                    PFCO = 35.52f,
                    DY = 0.93f,
                    PSR = 1.76f,
                    EVEBIT = 30.89f,
                    ROE = 15.91f,
                    ROIC = 14.65f,
                    LC = 1.69f,
                    DBPL = 0.28f,
                    LPA = 1.60f,
                    VPA = 10.03f,
                    DPA = 0.62f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 36.41f,
                    PVPA = 5.56f,
                    PFCO = 33.12f,
                    DY = 0.86f,
                    PSR = 1.37f,
                    EVEBIT = 25.29f,
                    ROE = 15.29f,
                    ROIC = 14.17f,
                    LC = 1.61f,
                    DBPL = 0.27f,
                    LPA = 1.57f,
                    VPA = 10.28f,
                    DPA = 0.62f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 42.96f,
                    PVPA = 6.10f,
                    PFCO = 31.59f,
                    DY = 1.11f,
                    PSR = 1.50f,
                    EVEBIT = 30.74f,
                    ROE = 14.21f,
                    ROIC = 13.52f,
                    LC = 1.55f,
                    DBPL = 0.24f,
                    LPA = 1.52f,
                    VPA = 10.70f,
                    DPA = 0.63f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 41.91f,
                    PVPA = 6.61f,
                    PFCO = 32.47f,
                    DY = 1.01f,
                    PSR = 1.67f,
                    EVEBIT = 26.59f,
                    ROE = 15.75f,
                    ROIC = 17.27f,
                    LC = 1.55f,
                    DBPL = 0.16f,
                    LPA = 1.40f,
                    VPA = 8.87f,
                    DPA = 0.60f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 52.32f,
                    PVPA = 7.66f,
                    PFCO = 38.42f,
                    DY = 0.87f,
                    PSR = 1.93f,
                    EVEBIT = 32.71f,
                    ROE = 14.68f,
                    ROIC = 15.18f,
                    LC = 1.66f,
                    DBPL = 0.25f,
                    LPA = 1.34f,
                    VPA = 9.15f,
                    DPA = 0.60f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 65.57f,
                    PVPA = 9.75f,
                    PFCO = 50.43f,
                    DY = 0.81f,
                    PSR = 2.41f,
                    EVEBIT = 41.01f,
                    ROE = 14.91f,
                    ROIC = 15.43f,
                    LC = 1.59f,
                    DBPL = 0.23f,
                    LPA = 1.40f,
                    VPA = 9.42f,
                    DPA = 0.61f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 49.34f,
                    PVPA = 7.77f,
                    PFCO = 40.18f,
                    DY = 0.67f,
                    PSR = 1.94f,
                    EVEBIT = 32.32f,
                    ROE = 15.73f,
                    ROIC = 16.02f,
                    LC = 1.58f,
                    DBPL = 0.19f,
                    LPA = 1.55f,
                    VPA = 9.84f,
                    DPA = 0.61f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_RADL3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 12.94m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 14.7m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 13.07m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 14.29m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 11.3m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 11.45m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 13.7m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 14.68m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 18m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 10.09m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 12.23m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 12.87m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 11.9m));

            #endregion

            return ativos;
        }
    }
}
