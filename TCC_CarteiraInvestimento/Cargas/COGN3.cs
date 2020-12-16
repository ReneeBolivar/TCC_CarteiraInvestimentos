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
        public static List<Cromossomo> COGN3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "COGN3",
                Nome = "KROTON EDUCACIONAL S.A.",
                Setor = Setor.Diversos,
                PrecoAtivoNoPeriodo = ObterAtivos_COGN3()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 8.78f,
                    PVPA = 1.05f,
                    PFCO = 9.72f,
                    DY = 3.22f,
                    PSR = 2.97f,
                    EVEBIT = 9.06f,
                    ROE = 11.89f,
                    ROIC = 10.33f,
                    LC = 3.13f,
                    DBPL = 0.02f,
                    LPA = 1.15f,
                    VPA = 9.64f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 10.36f,
                    PVPA = 1.18f,
                    PFCO = 12.29f,
                    DY = 4.65f,
                    PSR = 3.34f,
                    EVEBIT = 11.16f,
                    ROE = 11.35f,
                    ROIC = 9.81f,
                    LC = 2.86f,
                    DBPL = 0.01f,
                    LPA = 1.10f,
                    VPA = 9.67f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.51f,
                    PVPA = 0.90f,
                    PFCO = 8.73f,
                    DY = 3.64f,
                    PSR = 3.61f,
                    EVEBIT = 9.06f,
                    ROE = 10.58f,
                    ROIC = 6.64f,
                    LC = 7.29f,
                    DBPL = 0.36f,
                    LPA = 1.03f,
                    VPA = 9.77f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 12.33f,
                    PVPA = 1.08f,
                    PFCO = 15.26f,
                    DY = 4.42f,
                    PSR = 4.02f,
                    EVEBIT = 17.94f,
                    ROE = 8.77f,
                    ROIC = 5.31f,
                    LC = 2.17f,
                    DBPL = 0.48f,
                    LPA = 0.86f,
                    VPA = 9.84f,
                    DPA = 0.00f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 12.30f,
                    PVPA = 1.50f,
                    PFCO = 10.77f,
                    DY = 2.90f,
                    PSR = 4.09f,
                    EVEBIT = 12.49f,
                    ROE = 12.25f,
                    ROIC = 10.68f,
                    LC = 2.46f,
                    DBPL = 0.03f,
                    LPA = 1.08f,
                    VPA = 8.83f,
                    DPA = 0.36f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 16.11f,
                    PVPA = 1.96f,
                    PFCO = 15.25f,
                    DY = 2.59f,
                    PSR = 5.31f,
                    EVEBIT = 16.95f,
                    ROE = 12.16f,
                    ROIC = 10.52f,
                    LC = 2.46f,
                    DBPL = 0.03f,
                    LPA = 1.10f,
                    VPA = 9.04f,
                    DPA = 0.24f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.69f,
                    PVPA = 1.99f,
                    PFCO = 15.53f,
                    DY = 1.97f,
                    PSR = 4.94f,
                    EVEBIT = 13.00f,
                    ROE = 15.71f,
                    ROIC = 13.94f,
                    LC = 2.85f,
                    DBPL = 0.03f,
                    LPA = 1.45f,
                    VPA = 9.25f,
                    DPA = 0.13f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 12.53f,
                    PVPA = 1.55f,
                    PFCO = 12.94f,
                    DY = 2.31f,
                    PSR = 4.26f,
                    EVEBIT = 13.10f,
                    ROE = 12.38f,
                    ROIC = 10.68f,
                    LC = 2.63f,
                    DBPL = 0.02f,
                    LPA = 1.16f,
                    VPA = 9.35f,
                    DPA = 0.13f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_COGN3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 10.52m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 13.2m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 9.05m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 11.19m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 8.77m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 12.52m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 14.14m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 19.2m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 17.73m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 10.49m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 12.59m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 13.78m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 12.49m));

            #endregion

            return null;
        }
    }
}
