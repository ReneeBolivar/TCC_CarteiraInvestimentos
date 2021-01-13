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
        public static List<Cromossomo> WHRL3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "WHRL3",
                Nome = "WHIRLPOOL S.A.",
                Setor = Setor.UtilidadesDomesticas,
                PrecoAtivoNoPeriodo = ObterAtivos_WHRL3()
            };

            #region Compreende todo o ano d 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 13.97f,
                    PVPA = 2.90f,
                    PFCO = 8.01f,
                    DY = 9.55f,
                    PSR = 0.61f,
                    EVEBIT = 13.78f,
                    ROE = 20.81f,
                    ROIC = 12.37f,
                    LC = 1.22f,
                    DBPL = 0.10f,
                    LPA = 0.34f,
                    VPA = 1.64f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 15.48f,
                    PVPA = 3.12f,
                    PFCO = 11.29f,
                    DY = 9.49f,
                    PSR = 0.67f,
                    EVEBIT = 14.52f,
                    ROE = 19.78f,
                    ROIC = 14.61f,
                    LC = 1.30f,
                    DBPL = 0.02f,
                    LPA = 0.31f,
                    VPA = 1.54f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 15.00f,
                    PVPA = 2.87f,
                    PFCO = 9.83f,
                    DY = 4.37f,
                    PSR = 0.66f,
                    EVEBIT = 12.98f,
                    ROE = 19.07f,
                    ROIC = 15.38f,
                    LC = 1.29f,
                    DBPL = 0.01f,
                    LPA = 0.30f,
                    VPA = 1.57f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 36.67f,
                    PVPA = 3.01f,
                    PFCO = 5.04f,
                    DY = 13.15f,
                    PSR = 1.07f,
                    EVEBIT = 25.56f,
                    ROE = 8.25f,
                    ROIC = 6.74f,
                    LC = 1.22f,
                    DBPL = 0.21f,
                    LPA = 0.12f,
                    VPA = 1.46f,
                    DPA = 0.30f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 18.24f,
                    PVPA = 1.77f,
                    PFCO = 4.86f,
                    DY = 0.00f,
                    PSR = 0.68f,
                    EVEBIT = 16.19f,
                    ROE = 9.97f,
                    ROIC = 5.73f,
                    LC = 1.22f,
                    DBPL = 0.11f,
                    LPA = 0.17f,
                    VPA = 1.75f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 28.94f,
                    PVPA = 2.83f,
                    PFCO = 7.60f,
                    DY = 1.55f,
                    PSR = 1.13f,
                    EVEBIT = 32.27f,
                    ROE = 9.87f,
                    ROIC = 3.97f,
                    LC = 1.21f,
                    DBPL = 0.10f,
                    LPA = 0.18f,
                    VPA = 1.84f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 25.83f,
                    PVPA = 2.87f,
                    PFCO = 9.23f,
                    DY = 7.80f,
                    PSR = 1.02f,
                    EVEBIT = 56.86f,
                    ROE = 11.10f,
                    ROIC = 0.02f,
                    LC = 1.26f,
                    DBPL = 0.11f,
                    LPA = 0.18f,
                    VPA = 1.62f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 17.52f,
                    PVPA = 3.22f,
                    PFCO = 7.44f,
                    DY = 10.88f,
                    PSR = 0.81f,
                    EVEBIT = 17.31f,
                    ROE = 18.35f,
                    ROIC = 10.50f,
                    LC = 1.22f,
                    DBPL = 0.10f,
                    LPA = 0.29f,
                    VPA = 1.58f,
                    DPA = 0.05f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 13.68f,
                    PVPA = 1.59f,
                    PFCO = -385.25f,
                    DY = 5.29f,
                    PSR = 0.42f,
                    EVEBIT = 9.90f,
                    ROE = 11.59f,
                    ROIC = 5.95f,
                    LC = 1.19f,
                    DBPL = 0.06f,
                    LPA = 0.19f,
                    VPA = 1.64f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 20.42f,
                    PVPA = 1.51f,
                    PFCO = 6.23f,
                    DY = 5.16f,
                    PSR = 0.40f,
                    EVEBIT = 11.88f,
                    ROE = 7.59f,
                    ROIC = 4.41f,
                    LC = 1.18f,
                    DBPL = 0.06f,
                    LPA = 0.12f,
                    VPA = 1.62f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 16.15f,
                    PVPA = 1.92f,
                    PFCO = 3.41f,
                    DY = 3.87f,
                    PSR = 0.50f,
                    EVEBIT = 9.01f,
                    ROE = 11.78f,
                    ROIC = 13.69f,
                    LC = 1.22f,
                    DBPL = 0.06f,
                    LPA = 0.20f,
                    VPA = 1.68f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 14.33f,
                    PVPA = 1.78f,
                    PFCO = 3.74f,
                    DY = 0.00f,
                    PSR = 0.50f,
                    EVEBIT = 13.48f,
                    ROE = 12.25f,
                    ROIC = 6.52f,
                    LC = 1.19f,
                    DBPL = 0.13f,
                    LPA = 0.21f,
                    VPA = 1.69f,
                    DPA = 0.05f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_WHRL3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 3.51m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 4.1m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 3.72m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 3.72m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 3.43m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 2.3m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 2.41m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 2.82m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 3.6m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 1.94m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 1.82m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 2.4m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 2.24m));

            #endregion

            return ativos;
        }
    }
}
