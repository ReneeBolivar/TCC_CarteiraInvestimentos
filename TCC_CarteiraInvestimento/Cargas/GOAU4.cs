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
        public static List<Cromossomo> GOAU4()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "GOAU4",
                Nome = "METALURGICA GERDAU SA.",
                Setor = Setor.SiderurgiaMetalurgia,
                PrecoAtivoNoPeriodo = ObterAtivos_GOAU4()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = -17.08f,
                    PVPA = 0.24f,
                    PFCO = 2.93f,
                    DY = 0.28f,
                    PSR = 0.54f,
                    EVEBIT = 23.31f,
                    ROE = -1.41f,
                    ROIC = 1.99f,
                    LC = 2.40f,
                    DBPL = 0.74f,
                    LPA = -0.36f,
                    VPA = 25.77f,
                    DPA = 0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = -72.55f,
                    PVPA = 0.29f,
                    PFCO = 3.06f,
                    DY = 0.97f,
                    PSR = 0.56f,
                    EVEBIT = 15.01f,
                    ROE = -0.42f,
                    ROIC = 3.74f,
                    LC = 2.26f,
                    DBPL = 0.75f,
                    LPA = -0.11f,
                    VPA = 27.46f,
                    DPA = 0.17f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 44.93f,
                    PVPA = 0.24f,
                    PFCO = 2.36f,
                    DY = 1.63f,
                    PSR = 0.49f,
                    EVEBIT = 9.69f,
                    ROE = 0.53f,
                    ROIC = 5.47f,
                    LC = 2.26f,
                    DBPL = 0.72f,
                    LPA = 0.15f,
                    VPA = 28.65f,
                    DPA = 0.38f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.17f,
                    PVPA = 0.26f,
                    PFCO = 3.19f,
                    DY = 2.88f,
                    PSR = 0.42f,
                    EVEBIT = 4.65f,
                    ROE = 3.15f,
                    ROIC = 10.20f,
                    LC = 1.92f,
                    DBPL = 0.61f,
                    LPA = 0.87f,
                    VPA = 27.73f,
                    DPA = 0.38f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -4.38f,
                    PVPA = 0.19f,
                    PFCO = 1.92f,
                    DY = 0.00f,
                    PSR = 0.58f,
                    EVEBIT = -30.55f,
                    ROE = -4.26f,
                    ROIC = -2.59f,
                    LC = 2.05f,
                    DBPL = 0.84f,
                    LPA = -1.13f,
                    VPA = 26.65f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -4.81f,
                    PVPA = 0.19f,
                    PFCO = 2.63f,
                    DY = 0.00f,
                    PSR = 0.61f,
                    EVEBIT = -34.09f,
                    ROE = -3.94f,
                    ROIC = -1.48f,
                    LC = 2.08f,
                    DBPL = 0.84f,
                    LPA = -1.07f,
                    VPA = 27.11f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -5.85f,
                    PVPA = 0.22f,
                    PFCO = 4.06f,
                    DY = 0.00f,
                    PSR = 0.57f,
                    EVEBIT = -32.68f,
                    ROE = -3.72f,
                    ROIC = -1.98f,
                    LC = 1.89f,
                    DBPL = 0.80f,
                    LPA = -0.99f,
                    VPA = 26.63f,
                    DPA = 0.02f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = -33.59f,
                    PVPA = 0.29f,
                    PFCO = 3.30f,
                    DY = 0.35f,
                    PSR = 0.59f,
                    EVEBIT = 18.87f,
                    ROE = -0.87f,
                    ROIC = 1.96f,
                    LC = 2.33f,
                    DBPL = 0.74f,
                    LPA = -0.22f,
                    VPA = 25.51f,
                    DPA = 0.02f
                }));

            #endregion

            #region Compreendo todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -0.91f,
                    PVPA = 0.08f,
                    PFCO = 0.32f,
                    DY = 1.64f,
                    PSR = 0.57f,
                    EVEBIT = -6.01f,
                    ROE = -8.47f,
                    ROIC = -5.67f,
                    LC = 2.53f,
                    DBPL = 0.87f,
                    LPA = -2.66f,
                    VPA = 31.39f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -0.73f,
                    PVPA = 0.07f,
                    PFCO = 0.29f,
                    DY = 0.99f,
                    PSR = 0.50f,
                    EVEBIT = -5.06f,
                    ROE = -9.57f,
                    ROIC = -7.09f,
                    LC = 2.65f,
                    DBPL = 0.84f,
                    LPA = -2.73f,
                    VPA = 28.56f,
                    DPA = -0.70f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -2.07f,
                    PVPA = 0.12f,
                    PFCO = 0.86f,
                    DY = 0.00f,
                    PSR = 0.59f,
                    EVEBIT = -11.53f,
                    ROE = -5.80f,
                    ROIC = -4.37f,
                    LC = 2.85f,
                    DBPL = 0.86f,
                    LPA = -1.66f,
                    VPA = 28.64f,
                    DPA = -0.07f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = -3.18f,
                    PVPA = 0.19f,
                    PFCO = 1.32f,
                    DY = 0.00f,
                    PSR = 0.57f,
                    EVEBIT = -11.93f,
                    ROE = -5.90f,
                    ROIC = -4.37f,
                    LC = 1.98f,
                    DBPL = 0.92f,
                    LPA = -1.51f,
                    VPA = 25.53f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_GOAU4()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 6.93m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 6.74m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 5.86m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 7.63m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 6.72m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 4.66m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 4.68m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 4.98m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 5.46m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 2.26m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 1.87m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 3.23m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 4.52m));

            #endregion

            return null;
        }
    }
}
