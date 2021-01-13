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
        public static List<Cromossomo> SEER3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "SEER3",
                Nome = "SER EDUCACIONAL S.A.",
                Setor = Setor.Diversos,
                PrecoAtivoNoPeriodo = ObterAtivos_SEER3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 11.86f,
                    PVPA = 1.35f,
                    PFCO = 5.87f,
                    DY = 0.00f,
                    PSR = 1.91f,
                    EVEBIT = 7.10f,
                    ROE = 11.39f,
                    ROIC = 11.43f,
                    LC = 4.17f,
                    DBPL = 0.21f,
                    LPA = 1.40f,
                    VPA = 12.31f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 11.25f,
                    PVPA = 1.32f,
                    PFCO = 6.43f,
                    DY = 1.74f,
                    PSR = 1.88f,
                    EVEBIT = 7.37f,
                    ROE = 11.67f,
                    ROIC = 10.91f,
                    LC = 4.46f,
                    DBPL = 0.20f,
                    LPA = 1.47f,
                    VPA = 12.56f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 11.09f,
                    PVPA = 1.24f,
                    PFCO = 4.76f,
                    DY = 2.57f,
                    PSR = 1.68f,
                    EVEBIT = 5.93f,
                    ROE = 11.16f,
                    ROIC = 10.86f,
                    LC = 2.99f,
                    DBPL = 0.20f,
                    LPA = 1.38f,
                    VPA = 12.34f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 12.65f,
                    PVPA = 1.73f,
                    PFCO = 6.56f,
                    DY = 2.73f,
                    PSR = 2.16f,
                    EVEBIT = 8.21f,
                    ROE = 13.69f,
                    ROIC = 12.85f,
                    LC = 2.81f,
                    DBPL = 0.21f,
                    LPA = 1.61f,
                    VPA = 11.74f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 11.39f,
                    PVPA = 2.49f,
                    PFCO = 7.94f,
                    DY = 1.38f,
                    PSR = 2.44f,
                    EVEBIT = 8.62f,
                    ROE = 21.81f,
                    ROIC = 21.46f,
                    LC = 1.92f,
                    DBPL = 0.32f,
                    LPA = 1.80f,
                    VPA = 8.23f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 16.81f,
                    PVPA = 3.46f,
                    PFCO = 11.20f,
                    DY = 1.16f,
                    PSR = 3.37f,
                    EVEBIT = 12.40f,
                    ROE = 20.62f,
                    ROIC = 21.54f,
                    LC = 2.04f,
                    DBPL = 0.27f,
                    LPA = 1.80f,
                    VPA = 8.75f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 17.39f,
                    PVPA = 3.43f,
                    PFCO = 11.77f,
                    DY = 0.88f,
                    PSR = 3.41f,
                    EVEBIT = 13.14f,
                    ROE = 19.70f,
                    ROIC = 20.10f,
                    LC = 2.49f,
                    DBPL = 0.25f,
                    LPA = 1.80f,
                    VPA = 9.13f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 18.99f,
                    PVPA = 2.49f,
                    PFCO = 10.53f,
                    DY = 0.88f,
                    PSR = 3.28f,
                    EVEBIT = 12.34f,
                    ROE = 13.09f,
                    ROIC = 13.80f,
                    LC = 4.29f,
                    DBPL = 0.21f,
                    LPA = 1.58f,
                    VPA = 12.05f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 8.06f,
                    PVPA = 1.57f,
                    PFCO = 28.60f,
                    DY = 2.03f,
                    PSR = 1.59f,
                    EVEBIT = 6.62f,
                    ROE = 19.47f,
                    ROIC = 17.38f,
                    LC = 1.83f,
                    DBPL = 0.45f,
                    LPA = 1.31f,
                    VPA = 6.73f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.72f,
                    PVPA = 1.73f,
                    PFCO = 13.78f,
                    DY = 1.72f,
                    PSR = 1.76f,
                    EVEBIT = 6.95f,
                    ROE = 19.79f,
                    ROIC = 18.22f,
                    LC = 2.09f,
                    DBPL = 0.41f,
                    LPA = 1.43f,
                    VPA = 7.22f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 10.65f,
                    PVPA = 2.27f,
                    PFCO = 10.93f,
                    DY = 1.07f,
                    PSR = 2.25f,
                    EVEBIT = 8.05f,
                    ROE = 21.35f,
                    ROIC = 19.61f,
                    LC = 2.12f,
                    DBPL = 0.38f,
                    LPA = 1.62f,
                    VPA = 7.61f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 10.15f,
                    PVPA = 2.46f,
                    PFCO = 8.12f,
                    DY = 0.99f,
                    PSR = 2.30f,
                    EVEBIT = 7.70f,
                    ROE = 24.25f,
                    ROIC = 22.44f,
                    LC = 1.92f,
                    DBPL = 0.37f,
                    LPA = 1.84f,
                    VPA = 7.59f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_SEER3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 18.28m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 17.47m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 13.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 14.85m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 13.96m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 17.81m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 21.27m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 27.23m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 27.32m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 9.02m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 10.67m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 14.78m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 15.96m));

            #endregion

            return ativos;
        }
    }
}
