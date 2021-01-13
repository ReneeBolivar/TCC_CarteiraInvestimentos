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
        public static List<Cromossomo> HYPE3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "HYPE3",
                Nome = "HYPERMARCAS S/A.",
                Setor = Setor.Comercio,
                PrecoAtivoNoPeriodo = ObterAtivos_HYPE3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 15.46f,
                    PVPA = 2.11f,
                    PFCO = 17.72f,
                    DY = 0.00f,
                    PSR = 4.68f,
                    EVEBIT = 13.86f,
                    ROE = 13.67f,
                    ROIC = 13.35f,
                    LC = 3.28f,
                    DBPL = 0.06f,
                    LPA = 1.71f,
                    VPA = 12.51f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 15.50f,
                    PVPA = 2.24f,
                    PFCO = 18.38f,
                    DY = 1.51f,
                    PSR = 4.95f,
                    EVEBIT = 14.55f,
                    ROE = 14.44f,
                    ROIC = 14.00f,
                    LC = 3.40f,
                    DBPL = 0.05f,
                    LPA = 1.84f,
                    VPA = 12.75f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 15.44f,
                    PVPA = 2.32f,
                    PFCO = 17.09f,
                    DY = 1.46f,
                    PSR = 5.22f,
                    EVEBIT = 15.21f,
                    ROE = 15.04f,
                    ROIC = 14.05f,
                    LC = 3.22f,
                    DBPL = 0.06f,
                    LPA = 1.94f,
                    VPA = 12.93f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 14.47f,
                    PVPA = 1.98f,
                    PFCO = 15.35f,
                    DY = 3.21f,
                    PSR = 4.52f,
                    EVEBIT = 12.44f,
                    ROE = 13.66f,
                    ROIC = 12.85f,
                    LC = 3.04f,
                    DBPL = 0.07f,
                    LPA = 1.79f,
                    VPA = 13.08f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 52.73f,
                    PVPA = 2.15f,
                    PFCO = 21.12f,
                    DY = 0.00f,
                    PSR = 5.52f,
                    EVEBIT = 15.37f,
                    ROE = 4.11f,
                    ROIC = 8.95f,
                    LC = 3.41f,
                    DBPL = 0.10f,
                    LPA = 0.55f,
                    VPA = 13.48f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 47.93f,
                    PVPA = 2.24f,
                    PFCO = 18.50f,
                    DY = 0.00f,
                    PSR = 5.21f,
                    EVEBIT = 14.42f,
                    ROE = 4.69f,
                    ROIC = 9.70f,
                    LC = 2.35f,
                    DBPL = 0.08f,
                    LPA = 0.58f,
                    VPA = 12.42f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 66.67f,
                    PVPA = 2.83f,
                    PFCO = 25.20f,
                    DY = 0.00f,
                    PSR = 6.45f,
                    EVEBIT = 19.13f,
                    ROE = 4.27f,
                    ROIC = 9.81f,
                    LC = 3.52f,
                    DBPL = 0.08f,
                    LPA = 0.54f,
                    VPA = 12.71f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 24.58f,
                    PVPA = 3.07f,
                    PFCO = 25.49f,
                    DY = 0.00f,
                    PSR = 6.62f,
                    EVEBIT = 19.75f,
                    ROE = 12.47f,
                    ROIC = 12.61f,
                    LC = 2.30f,
                    DBPL = 0.08f,
                    LPA = 1.53f,
                    VPA = 12.24f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 12.02f,
                    PVPA = 1.97f,
                    PFCO = 34.35f,
                    DY = 0.00f,
                    PSR = 7.35f,
                    EVEBIT = 18.79f,
                    ROE = 16.34f,
                    ROIC = 8.09f,
                    LC = 3.08f,
                    DBPL = 0.23f,
                    LPA = 2.34f,
                    VPA = 14.30f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.57f,
                    PVPA = 1.63f,
                    PFCO = 21.62f,
                    DY = 0.00f,
                    PSR = 7.53f,
                    EVEBIT = 14.71f,
                    ROE = 17.02f,
                    ROIC = 8.31f,
                    LC = 3.82f,
                    DBPL = 0.21f,
                    LPA = 2.44f,
                    VPA = 14.34f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 10.56f,
                    PVPA = 1.95f,
                    PFCO = 21.29f,
                    DY = 0.00f,
                    PSR = 11.42f,
                    EVEBIT = 17.53f,
                    ROE = 18.49f,
                    ROIC = 8.27f,
                    LC = 4.09f,
                    DBPL = 0.15f,
                    LPA = 2.64f,
                    VPA = 14.29f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 14.05f,
                    PVPA = 1.87f,
                    PFCO = 18.74f,
                    DY = 0.00f,
                    PSR = 5.23f,
                    EVEBIT = 15.00f,
                    ROE = 13.33f,
                    ROIC = 8.96f,
                    LC = 3.07f,
                    DBPL = 0.10f,
                    LPA = 1.86f,
                    VPA = 13.94f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_HYPE3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 24.55m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 33.55m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 25.74m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 26.75m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 28.63m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 25.06m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 25.21m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 29.2m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 32.65m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 24.08m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 20.16m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 24.07m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 22.55m));

            #endregion

            return ativos;
        }
    }
}
