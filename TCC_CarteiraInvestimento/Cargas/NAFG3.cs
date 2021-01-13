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
        public static List<Cromossomo> NAFG3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "NAFG3",
                Nome = "NADIR FIGUEIREDO IND E COM SA.",
                Setor = Setor.UtilidadesDomesticas,
                PrecoAtivoNoPeriodo = ObterAtivos_NAFG3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.18f,
                    PVPA = 1.01f,
                    PFCO = 2.97f,
                    DY = 4.56f,
                    PSR = 0.57f,
                    EVEBIT = 3.62f,
                    ROE = 19.51f,
                    ROIC = 19.61f,
                    LC = 1.50f,
                    DBPL = 0.29f,
                    LPA = 5.12f,
                    VPA = 26.23f,
                    DPA = 0.74f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 4.77f,
                    PVPA = 0.98f,
                    PFCO = 3.71f,
                    DY = 4.39f,
                    PSR = 0.61f,
                    EVEBIT = 3.59f,
                    ROE = 20.47f,
                    ROIC = 18.13f,
                    LC = 1.77f,
                    DBPL = 0.39f,
                    LPA = 5.56f,
                    VPA = 27.16f,
                    DPA = 0.74f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.42f,
                    PVPA = 1.31f,
                    PFCO = 5.60f,
                    DY = 3.71f,
                    PSR = 0.77f,
                    EVEBIT = 4.40f,
                    ROE = 20.36f,
                    ROIC = 18.39f,
                    LC = 1.72f,
                    DBPL = 0.38f,
                    LPA = 5.78f,
                    VPA = 28.40f,
                    DPA = 0.56f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 10.67f,
                    PVPA = 2.21f,
                    PFCO = 8.41f,
                    DY = 3.04f,
                    PSR = 1.21f,
                    EVEBIT = 6.75f,
                    ROE = 20.73f,
                    ROIC = 19.24f,
                    LC = 1.65f,
                    DBPL = 0.33f,
                    LPA = 6.09f,
                    VPA = 29.36f,
                    DPA = 0.70f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 7.53f,
                    PVPA = 0.66f,
                    PFCO = 2.77f,
                    DY = 3.93f,
                    PSR = 0.36f,
                    EVEBIT = 5.44f,
                    ROE = 8.72f,
                    ROIC = 10.36f,
                    LC = 1.15f,
                    DBPL = 0.54f,
                    LPA = 1.94f,
                    VPA = 22.28f,
                    DPA = 0.57f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.00f,
                    PVPA = 0.83f,
                    PFCO = 2.87f,
                    DY = 3.94f,
                    PSR = 0.46f,
                    EVEBIT = 4.99f,
                    ROE = 10.38f,
                    ROIC = 13.80f,
                    LC = 1.21f,
                    DBPL = 0.42f,
                    LPA = 2.41f,
                    VPA = 23.18f,
                    DPA = 0.57f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 5.68f,
                    PVPA = 0.83f,
                    PFCO = 2.80f,
                    DY = 3.90f,
                    PSR = 0.46f,
                    EVEBIT = 3.90f,
                    ROE = 14.69f,
                    ROIC = 16.52f,
                    LC = 1.26f,
                    DBPL = 0.37f,
                    LPA = 3.54f,
                    VPA = 24.11f,
                    DPA = 0.66f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 6.10f,
                    PVPA = 0.99f,
                    PFCO = 3.61f,
                    DY = 3.41f,
                    PSR = 0.55f,
                    EVEBIT = 4.27f,
                    ROE = 16.19f,
                    ROIC = 16.34f,
                    LC = 1.38f,
                    DBPL = 0.36f,
                    LPA = 4.10f,
                    VPA = 25.35f,
                    DPA = 0.64f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 10.27f,
                    PVPA = 0.70f,
                    PFCO = 4.55f,
                    DY = 3.22f,
                    PSR = 0.48f,
                    EVEBIT = 6.98f,
                    ROE = 6.82f,
                    ROIC = 9.16f,
                    LC = 1.27f,
                    DBPL = 0.67f,
                    LPA = 1.46f,
                    VPA = 21.35f,
                    DPA = 0.31f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 7.65f,
                    PVPA = 0.70f,
                    PFCO = 3.60f,
                    DY = 2.52f,
                    PSR = 0.42f,
                    EVEBIT = 5.60f,
                    ROE = 9.19f,
                    ROIC = 10.38f,
                    LC = 1.12f,
                    DBPL = 0.63f,
                    LPA = 1.96f,
                    VPA = 21.37f,
                    DPA = 0.38f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.58f,
                    PVPA = 0.70f,
                    PFCO = 2.59f,
                    DY = 2.66f,
                    PSR = 0.40f,
                    EVEBIT = 5.53f,
                    ROE = 10.68f,
                    ROIC = 10.37f,
                    LC = 1.10f,
                    DBPL = 0.61f,
                    LPA = 2.28f,
                    VPA = 21.31f,
                    DPA = 0.40f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.01f,
                    PVPA = 0.67f,
                    PFCO = 2.03f,
                    DY = 3.66f,
                    PSR = 0.37f,
                    EVEBIT = 5.58f,
                    ROE = 9.61f,
                    ROIC = 10.49f,
                    LC = 1.12f,
                    DBPL = 0.54f,
                    LPA = 2.14f,
                    VPA = 22.30f,
                    DPA = 0.55f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_NAFG3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 56.57m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 22.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 32.3m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 0m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 12.2m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 13.19m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 15.52m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 17.42m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 0m));

            #endregion

            return ativos;
        }
    }
}
