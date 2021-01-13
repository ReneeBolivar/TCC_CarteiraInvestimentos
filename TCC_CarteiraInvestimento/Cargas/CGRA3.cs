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
        public static List<Cromossomo> CGRA3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "CGRA3",
                Nome = "GRAZZIOTIN SA.",
                Setor = Setor.Comercio,
                PrecoAtivoNoPeriodo = ObterAtivos_CGRA3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 8.14f,
                    PVPA = 0.98f,
                    PFCO = 12.06f,
                    DY = 5.05f,
                    PSR = 1.08f,
                    EVEBIT = 7.59f,
                    ROE = 12.02f,
                    ROIC = 5.73f,
                    LC = 2.80f,
                    DBPL = 0.00f,
                    LPA = 2.65f,
                    VPA = 22.05f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.59f,
                    PVPA = 0.96f,
                    PFCO = 10.91f,
                    DY = 5.48f,
                    PSR = 1.08f,
                    EVEBIT = 8.27f,
                    ROE = 11.20f,
                    ROIC = 5.54f,
                    LC = 3.23f,
                    DBPL = 0.00f,
                    LPA = 2.56f,
                    VPA = 22.87f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 9.42f,
                    PVPA = 1.01f,
                    PFCO = 10.82f,
                    DY = 5.86f,
                    PSR = 1.15f,
                    EVEBIT = 9.15f,
                    ROE = 10.75f,
                    ROIC = 5.24f,
                    LC = 3.44f,
                    DBPL = 0.00f,
                    LPA = 2.51f,
                    VPA = 23.32f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.86f,
                    PVPA = 1.06f,
                    PFCO = 12.04f,
                    DY = 4.85f,
                    PSR = 1.14f,
                    EVEBIT = 10.12f,
                    ROE = 10.80f,
                    ROIC = 4.79f,
                    LC = 2.32f,
                    DBPL = 0.00f,
                    LPA = 2.45f,
                    VPA = 22.71f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 6.44f,
                    PVPA = 0.90f,
                    PFCO = 6.82f,
                    DY = 6.22f,
                    PSR = 1.07f,
                    EVEBIT = 6.61f,
                    ROE = 13.98f,
                    ROIC = 4.83f,
                    LC = 2.94f,
                    DBPL = 0.00f,
                    LPA = 2.98f,
                    VPA = 21.32f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 7.21f,
                    PVPA = 0.98f,
                    PFCO = 8.81f,
                    DY = 5.50f,
                    PSR = 1.21f,
                    EVEBIT = 7.95f,
                    ROE = 13.53f,
                    ROIC = 4.86f,
                    LC = 3.50f,
                    DBPL = 0.00f,
                    LPA = 3.01f,
                    VPA = 22.35f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.98f,
                    PVPA = 1.22f,
                    PFCO = 11.19f,
                    DY = 4.66f,
                    PSR = 1.47f,
                    EVEBIT = 9.75f,
                    ROE = 13.60f,
                    ROIC = 5.71f,
                    LC = 13.47f,
                    DBPL = 0.00f,
                    LPA = 3.02f,
                    VPA = 22.22f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.22f,
                    PVPA = 1.18f,
                    PFCO = 13.15f,
                    DY = 4.75f,
                    PSR = 1.32f,
                    EVEBIT = 8.99f,
                    ROE = 12.84f,
                    ROIC = 6.08f,
                    LC = 2.54f,
                    DBPL = 0.00f,
                    LPA = 2.80f,
                    VPA = 21.82f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.15f,
                    PVPA = 0.55f,
                    PFCO = 2.49f,
                    DY = 6.49f,
                    PSR = 0.62f,
                    EVEBIT = 3.37f,
                    ROE = 10.73f,
                    ROIC = 4.13f,
                    LC = 3.49f,
                    DBPL = 0.00f,
                    LPA = 2.14f,
                    VPA = 19.99f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 5.91f,
                    PVPA = 0.66f,
                    PFCO = 3.48f,
                    DY = 5.12f,
                    PSR = 0.77f,
                    EVEBIT = 4.62f,
                    ROE = 11.14f,
                    ROIC = 4.35f,
                    LC = 4.05f,
                    DBPL = 0.00f,
                    LPA = 2.37f,
                    VPA = 21.27f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.73f,
                    PVPA = 0.76f,
                    PFCO = 5.05f,
                    DY = 4.35f,
                    PSR = 0.90f,
                    EVEBIT = 5.77f,
                    ROE = 11.29f,
                    ROIC = 3.79f,
                    LC = 4.13f,
                    DBPL = 0.00f,
                    LPA = 2.45f,
                    VPA = 21.72f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 5.82f,
                    PVPA = 0.81f,
                    PFCO = 4.59f,
                    DY = 6.91f,
                    PSR = 0.95f,
                    EVEBIT = 5.59f,
                    ROE = 13.94f,
                    ROIC = 4.76f,
                    LC = 2.61f,
                    DBPL = 0.00f,
                    LPA = 2.92f,
                    VPA = 20.95f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_CGRA3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 22.67m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 23.02m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 21.19m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 19.84m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 21.23m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 16.61m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 18.77m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 21.81m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 23.48m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 8.86m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 11.39m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 13.41m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 14.7m));

            #endregion

            return ativos;
        }
    }
}
