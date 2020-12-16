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
        public static List<Cromossomo> CRIV4()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "CRIV4",
                Nome = "FINANCEIRA ALFA S.A.-C.F.I.",
                Setor = Setor.Financeiros,
                PrecoAtivoNoPeriodo = ObterAtivos_CRIV4()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 7.40f,
                    PVPA = 0.59f,
                    PFCO = 2.83f,
                    DY = 7.27f,
                    PSR = 5.66f,
                    EVEBIT = null,
                    ROE = 8.03f,
                    ROIC = null,
                    LC = 3.68f,
                    DBPL = null,
                    LPA = 0.67f,
                    VPA = 8.37f,
                    DPA = 0.18f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 7.83f,
                    PVPA = 0.67f,
                    PFCO = 1.05f,
                    DY = 7.14f,
                    PSR = 5.49f,
                    EVEBIT = null,
                    ROE = 8.48f,
                    ROIC = null,
                    LC = 2.18f,
                    DBPL = null,
                    LPA = 0.72f,
                    VPA = 8.45f,
                    DPA = 0.19f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.97f,
                    PVPA = 0.66f,
                    PFCO = 1.80f,
                    DY = 6.68f,
                    PSR = 4.71f,
                    EVEBIT = null,
                    ROE = 7.31f,
                    ROIC = null,
                    LC = 1.60f,
                    DBPL = null,
                    LPA = 0.63f,
                    VPA = 8.56f,
                    DPA = 0.19f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.09f,
                    PVPA = 0.69f,
                    PFCO = 3.16f,
                    DY = 6.66f,
                    PSR = 4.40f,
                    EVEBIT = null,
                    ROE = 7.57f,
                    ROIC = null,
                    LC = 1.37f,
                    DBPL = null,
                    LPA = 0.66f,
                    VPA = 8.69f,
                    DPA = 0.18f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.63f,
                    PVPA = 0.50f,
                    PFCO = -0.78f,
                    DY = 8.95f,
                    PSR = 1.78f,
                    EVEBIT = null,
                    ROE = 5.15f,
                    ROIC = null,
                    LC = 1.17f,
                    DBPL = null,
                    LPA = 0.41f,
                    VPA = 7.87f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 10.93f,
                    PVPA = 0.59f,
                    PFCO = -15.72f,
                    DY = 8.84f,
                    PSR = 2.35f,
                    EVEBIT = null,
                    ROE = 5.38f,
                    ROIC = null,
                    LC = 1.36f,
                    DBPL = null,
                    LPA = 0.43f,
                    VPA = 7.92f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.73f,
                    PVPA = 0.59f,
                    PFCO = -14.37f,
                    DY = 8.18f,
                    PSR = 4.15f,
                    EVEBIT = null,
                    ROE = 6.75f,
                    ROIC = null,
                    LC = 2.63f,
                    DBPL = null,
                    LPA = 0.55f,
                    VPA = 8.13f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.10f,
                    PVPA = 0.62f,
                    PFCO = -10.11f,
                    DY = 7.50f,
                    PSR = 5.83f,
                    EVEBIT = null,
                    ROE = 7.63f,
                    ROIC = null,
                    LC = 6.35f,
                    DBPL = null,
                    LPA = 0.63f,
                    VPA = 8.22f,
                    DPA = 0.18f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 8.53f,
                    PVPA = 0.42f,
                    PFCO = 4.72f,
                    DY = 10.45f,
                    PSR = 2.39f,
                    EVEBIT = null,
                    ROE = 5.01f,
                    ROIC = null,
                    LC = 1.48f,
                    DBPL = null,
                    LPA = 0.38f,
                    VPA = 7.63f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.66f,
                    PVPA = 0.43f,
                    PFCO = -0.47f,
                    DY = 10.30f,
                    PSR = 2.42f,
                    EVEBIT = null,
                    ROE = 5.02f,
                    ROIC = null,
                    LC = 1.75f,
                    DBPL = null,
                    LPA = 0.38f,
                    VPA = 7.66f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 9.87f,
                    PVPA = 0.48f,
                    PFCO = 7.50f,
                    DY = 9.59f,
                    PSR = 1.73f,
                    EVEBIT = null,
                    ROE = 4.96f,
                    ROIC = null,
                    LC = 1.12f,
                    DBPL = null,
                    LPA = 0.38f,
                    VPA = 7.75f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.49f,
                    PVPA = 0.48f,
                    PFCO = 1.04f,
                    DY = 9.72f,
                    PSR = 1.74f,
                    EVEBIT = null,
                    ROE = 4.98f,
                    ROIC = null,
                    LC = 1.14f,
                    DBPL = null,
                    LPA = 0.39f,
                    VPA = 7.77f,
                    DPA = 0.15f
                }));

            #endregion


            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_CRIV4()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 5.63m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 4.42m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 4.50m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 5.12m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 5.13m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 3.23m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 3.27m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 3.74m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 4.07m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 2.65m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 2.96m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 3.07m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 3.02m));

            #endregion

            return null;
        }
    }
}
