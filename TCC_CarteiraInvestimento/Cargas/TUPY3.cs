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
        public static List<Cromossomo> TUPY3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "TUPY3",
                Nome = "TUPY SA.",
                Setor = Setor.MaterialTransporte,
                PrecoAtivoNoPeriodo = ObterAtivos_TUPY3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 15.04f,
                    PVPA = 1.20f,
                    PFCO = 8.27f,
                    DY = 8.17f,
                    PSR = 0.93f,
                    EVEBIT = 14.49f,
                    ROE = 7.97f,
                    ROIC = 6.64f,
                    LC = 1.97f,
                    DBPL = 0.64f,
                    LPA = 1.13f,
                    VPA = 14.20f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 14.90f,
                    PVPA = 1.35f,
                    PFCO = 7.66f,
                    DY = 7.25f,
                    PSR = 1.02f,
                    EVEBIT = 11.70f,
                    ROE = 9.05f,
                    ROIC = 7.20f,
                    LC = 1.97f,
                    DBPL = 0.69f,
                    LPA = 1.36f,
                    VPA = 14.98f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 13.91f,
                    PVPA = 1.29f,
                    PFCO = 5.95f,
                    DY = 5.99f,
                    PSR = 0.94f,
                    EVEBIT = 10.85f,
                    ROE = 9.27f,
                    ROIC = 7.47f,
                    LC = 2.03f,
                    DBPL = 0.68f,
                    LPA = 1.44f,
                    VPA = 15.54f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.64f,
                    PVPA = 1.19f,
                    PFCO = 4.52f,
                    DY = 6.02f,
                    PSR = 0.82f,
                    EVEBIT = 8.94f,
                    ROE = 12.35f,
                    ROIC = 7.88f,
                    LC = 2.00f,
                    DBPL = 0.64f,
                    LPA = 1.88f,
                    VPA = 15.26f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o  ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -14.05f,
                    PVPA = 1.04f,
                    PFCO = 11.10f,
                    DY = 4.70f,
                    PSR = 1.12f,
                    EVEBIT = -14.87f,
                    ROE = -7.43f,
                    ROIC = -2.47f,
                    LC = 2.26f,
                    DBPL = 0.89f,
                    LPA = -1.05f,
                    VPA = 14.15f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -23.32f,
                    PVPA = 1.22f,
                    PFCO = 15.13f,
                    DY = 6.58f,
                    PSR = 1.22f,
                    EVEBIT = -16.48f,
                    ROE = -5.25f,
                    ROIC = -1.63f,
                    LC = 2.26f,
                    DBPL = 0.89f,
                    LPA = -0.74f,
                    VPA = 14.12f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -67.59f,
                    PVPA = 1.29f,
                    PFCO = 9.75f,
                    DY = 5.49f,
                    PSR = 1.16f,
                    EVEBIT = -27.34f,
                    ROE = -1.93f,
                    ROIC = 0.19f,
                    LC = 2.31f,
                    DBPL = 0.81f,
                    LPA = -0.27f,
                    VPA = 14.17f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 16.75f,
                    PVPA = 1.29f,
                    PFCO = 9.53f,
                    DY = 6.31f,
                    PSR = 1.01f,
                    EVEBIT = 17.43f,
                    ROE = 7.73f,
                    ROIC = 5.81f,
                    LC = 1.65f,
                    DBPL = 0.82f,
                    LPA = 1.06f,
                    VPA = 13.76f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_TUPY3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 17.94m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 16.16m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 17.28m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 19.74m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 19.95m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 13.15m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 14.56m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 16.62m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 17.03m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 14.17m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 10.14m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 12.16m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 10.7m));

            #endregion

            return null;
        }
    }
}
