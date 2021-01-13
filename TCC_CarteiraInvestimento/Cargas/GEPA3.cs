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
        public static List<Cromossomo> GEPA3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "GEPA3",
                Nome = "DUKE ENERGY INT, GERAÇÃO PARANAPANEMA SA.",
                Setor = Setor.EnergiaEletrica,
                PrecoAtivoNoPeriodo = ObterAtivos_GEPA3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 15.02f,
                    PVPA = 1.71f,
                    PFCO = 6.48f,
                    DY = 10.25f,
                    PSR = 3.01f,
                    EVEBIT = 10.84f,
                    ROE = 11.33f,
                    ROIC = 8.69f,
                    LC = 0.77f,
                    DBPL = 0.84f,
                    LPA = 2.14f,
                    VPA = 18.84f,
                    DPA = 3.35f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 22.79f,
                    PVPA = 1.75f,
                    PFCO = 5.79f,
                    DY = 10.16f,
                    PSR = 3.45f,
                    EVEBIT = 12.90f,
                    ROE = 7.71f,
                    ROIC = 7.46f,
                    LC = 0.95f,
                    DBPL = 0.96f,
                    LPA = 1.49f,
                    VPA = 19.36f,
                    DPA = 3.35f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 19.82f,
                    PVPA = 1.70f,
                    PFCO = 9.00f,
                    DY = 9.88f,
                    PSR = 3.31f,
                    EVEBIT = 10.45f,
                    ROE = 8.55f,
                    ROIC = 9.53f,
                    LC = 0.85f,
                    DBPL = 0.82f,
                    LPA = 1.65f,
                    VPA = 19.29f,
                    DPA = 3.35f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.10f,
                    PVPA = 2.05f,
                    PFCO = 9.02f,
                    DY = 7.91f,
                    PSR = 3.53f,
                    EVEBIT = 7.93f,
                    ROE = 15.65f,
                    ROIC = 12.72f,
                    LC = 0.86f,
                    DBPL = 0.93f,
                    LPA = 2.71f,
                    VPA = 17.32f,
                    DPA = 3.33f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 7.92f,
                    PVPA = 1.74f,
                    PFCO = 4.49f,
                    DY = 11.25f,
                    PSR = 3.11f,
                    EVEBIT = 5.68f,
                    ROE = 21.98f,
                    ROIC = 16.01f,
                    LC = 0.87f,
                    DBPL = 0.77f,
                    LPA = 4.42f,
                    VPA = 20.12f,
                    DPA = 4.39f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.39f,
                    PVPA = 1.86f,
                    PFCO = 5.53f,
                    DY = 14.69f,
                    PSR = 3.24f,
                    EVEBIT = 6.16f,
                    ROE = 22.13f,
                    ROIC = 16.96f,
                    LC = 0.86f,
                    DBPL = 0.57f,
                    LPA = 4.71f,
                    VPA = 21.28f,
                    DPA = 4.39f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 10.67f,
                    PVPA = 1.83f,
                    PFCO = 5.40f,
                    DY = 10.99f,
                    PSR = 3.29f,
                    EVEBIT = 7.58f,
                    ROE = 17.11f,
                    ROIC = 11.98f,
                    LC = 0.99f,
                    DBPL = 0.74f,
                    LPA = 3.59f,
                    VPA = 20.98f,
                    DPA = 4.39f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 14.77f,
                    PVPA = 2.12f,
                    PFCO = 6.45f,
                    DY = 10.17f,
                    PSR = 3.25f,
                    EVEBIT = 10.38f,
                    ROE = 14.40f,
                    ROIC = 10.09f,
                    LC = 0.73f,
                    DBPL = 0.88f,
                    LPA = 2.58f,
                    VPA = 17.94f,
                    DPA = 3.35f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 17.84f,
                    PVPA = 2.38f,
                    PFCO = 7.10f,
                    DY = 3.86f,
                    PSR = 3.73f,
                    EVEBIT = 9.22f,
                    ROE = 13.35f,
                    ROIC = 14.68f,
                    LC = 0.95f,
                    DBPL = 0.74f,
                    LPA = 2.69f,
                    VPA = 20.13f,
                    DPA = 2.60f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 10.97f,
                    PVPA = 1.77f,
                    PFCO = 4.80f,
                    DY = 7.00f,
                    PSR = 2.80f,
                    EVEBIT = 6.36f,
                    ROE = 16.11f,
                    ROIC = 16.08f,
                    LC = 0.78f,
                    DBPL = 0.72f,
                    LPA = 3.38f,
                    VPA = 20.96f,
                    DPA = 2.60f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 11.77f,
                    PVPA = 1.92f,
                    PFCO = 5.23f,
                    DY = 6.18f,
                    PSR = 3.07f,
                    EVEBIT = 6.62f,
                    ROE = 16.36f,
                    ROIC = 15.46f,
                    LC = 0.99f,
                    DBPL = 0.73f,
                    LPA = 3.57f,
                    VPA = 21.85f,
                    DPA = 2.60f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.16f,
                    PVPA = 1.87f,
                    PFCO = 4.29f,
                    DY = 11.25f,
                    PSR = 3.24f,
                    EVEBIT = 6.17f,
                    ROE = 20.37f,
                    ROIC = 15.41f,
                    LC = 0.76f,
                    DBPL = 0.86f,
                    LPA = 3.82f,
                    VPA = 18.76f,
                    DPA = 4.39f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_GEPA3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 32.44m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 31.59m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 28.39m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 29.2m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 29.09m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 26.16m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 23.62m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 31.6m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 31.83m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 26.17m));

            #endregion

            return ativos;
        }
    }
}
