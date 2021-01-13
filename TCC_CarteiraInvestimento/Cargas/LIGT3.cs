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
        public static List<Cromossomo> LITG3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "LITG3",
                Nome = "LIGHT SA.",
                Setor = Setor.EnergiaEletrica,
                PrecoAtivoNoPeriodo = ObterAtivos_LCAM3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 11.89f,
                    PVPA = 0.68f,
                    PFCO = -12.22f,
                    DY = 0.00f,
                    PSR = 0.62f,
                    EVEBIT = 8.30f,
                    ROE = 5.73f,
                    ROIC = 8.65f,
                    LC = 0.68f,
                    DBPL = 2.25f,
                    LPA = 0.94f,
                    VPA = 16.46f,
                    DPA = 0.14f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 11.93f,
                    PVPA = 0.78f,
                    PFCO = -19.36f,
                    DY = 1.29f,
                    PSR = 0.88f,
                    EVEBIT = 7.89f,
                    ROE = 6.55f,
                    ROIC = 8.20f,
                    LC = 1.20f,
                    DBPL = 3.01f,
                    LPA = 1.07f,
                    VPA = 16.33f,
                    DPA = 0.14f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 20.37f,
                    PVPA = 1.01f,
                    PFCO = -14.61f,
                    DY = 1.13f,
                    PSR = 0.88f,
                    EVEBIT = 10.09f,
                    ROE = 4.93f,
                    ROIC = 7.13f,
                    LC = 1.01f,
                    DBPL = 2.95f,
                    LPA = 0.81f,
                    VPA = 16.36f,
                    DPA = 0.14f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 25.37f,
                    PVPA = 1.24f,
                    PFCO = 101.02f,
                    DY = 0.88f,
                    PSR = 1.02f,
                    EVEBIT = 13.03f,
                    ROE = 4.89f,
                    ROIC = 6.09f,
                    LC = 1.07f,
                    DBPL = 2.96f,
                    LPA = 0.81f,
                    VPA = 16.62f,
                    DPA = 0.19f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -13.92f,
                    PVPA = 1.19f,
                    PFCO = 5.54f,
                    DY = 0.25f,
                    PSR = 0.93f,
                    EVEBIT = 14.73f,
                    ROE = -8.56f,
                    ROIC = 6.65f,
                    LC = 0.80f,
                    DBPL = 2.05f,
                    LPA = -1.42f,
                    VPA = 16.60f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -13.00f,
                    PVPA = 1.10f,
                    PFCO = 16.75f,
                    DY = 0.00f,
                    PSR = 0.80f,
                    EVEBIT = 13.46f,
                    ROE = -8.53f,
                    ROIC = 7.57f,
                    LC = 0.61f,
                    DBPL = 2.07f,
                    LPA = -1.38f,
                    VPA = 16.24f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -21.13f,
                    PVPA = 1.01f,
                    PFCO = -14.45f,
                    DY = 0.00f,
                    PSR = 0.75f,
                    EVEBIT = 10.72f,
                    ROE = -4.77f,
                    ROIC = 8.56f,
                    LC = 0.62f,
                    DBPL = 2.07f,
                    LPA = -0.79f,
                    VPA = 16.53f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 23.61f,
                    PVPA = 0.86f,
                    PFCO = 114.06f,
                    DY = 0.00f,
                    PSR = 0.70f,
                    EVEBIT = 8.52f,
                    ROE = 3.62f,
                    ROIC = 9.23f,
                    LC = 0.75f,
                    DBPL = 2.16f,
                    LPA = 0.61f,
                    VPA = 16.83f,
                    DPA = 0.14f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -22.55f,
                    PVPA = 0.55f,
                    PFCO = 1.45f,
                    DY = 7.59f,
                    PSR = 0.73f,
                    EVEBIT = 21.65f,
                    ROE = -2.44f,
                    ROIC = 3.14f,
                    LC = 0.88f,
                    DBPL = 1.99f,
                    LPA = -0.44f,
                    VPA = 17.94f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -25.61f,
                    PVPA = 0.64f,
                    PFCO = 1.10f,
                    DY = 0.45f,
                    PSR = 0.75f,
                    EVEBIT = 21.41f,
                    ROE = -2.51f,
                    ROIC = 3.41f,
                    LC = 0.78f,
                    DBPL = 1.88f,
                    LPA = -0.44f,
                    VPA = 17.69f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -17.08f,
                    PVPA = 0.91f,
                    PFCO = 1.46f,
                    DY = 0.31f,
                    PSR = 0.83f,
                    EVEBIT = 34.31f,
                    ROE = -5.36f,
                    ROIC = 2.22f,
                    LC = 0.71f,
                    DBPL = 1.92f,
                    LPA = -0.93f,
                    VPA = 17.40f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = -11.35f,
                    PVPA = 1.06f,
                    PFCO = 3.10f,
                    DY = 0.28f,
                    PSR = 0.89f,
                    EVEBIT = 19.05f,
                    ROE = -9.33f,
                    ROIC = 4.71f,
                    LC = 0.74f,
                    DBPL = 2.07f,
                    LPA = -1.53f,
                    VPA = 16.45f,
                    DPA = 0.05f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_LIGT3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 20.36m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 13.3m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 11.14m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 12.65m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 16.34m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 19.4m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 22.01m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 19.28m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 16.39m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 9.75m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 11.06m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 15.59m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 17.05m));

            #endregion

            return ativos;
        }
    }

}
