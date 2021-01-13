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
        public static List<Cromossomo> GUAR3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "GUAR3",
                Nome = "GUARARAPES CONFECÇÕES SA.",
                Setor = Setor.Comercio,
                PrecoAtivoNoPeriodo = ObterAtivos_GUAR3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 11.36f,
                    PVPA = 1.43f,
                    PFCO = 16.43f,
                    DY = 1.18f,
                    PSR = 0.93f,
                    EVEBIT = 8.24f,
                    ROE = 12.62f,
                    ROIC = 11.28f,
                    LC = 1.68f,
                    DBPL = 0.31f,
                    LPA = 8.19f,
                    VPA = 64.88f,
                    DPA = 1.96f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 12.53f,
                    PVPA = 1.60f,
                    PFCO = 60.99f,
                    DY = 1.98f,
                    PSR = 1.11f,
                    EVEBIT = 9.44f,
                    ROE = 12.76f,
                    ROIC = 10.13f,
                    LC = 1.93f,
                    DBPL = 0.45f,
                    LPA = 8.30f,
                    VPA = 65.03f,
                    DPA = 1.97f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 18.13f,
                    PVPA = 2.43f,
                    PFCO = 76.22f,
                    DY = 1.88f,
                    PSR = 1.59f,
                    EVEBIT = 13.16f,
                    ROE = 13.39f,
                    ROIC = 10.21f,
                    LC = 1.78f,
                    DBPL = 0.50f,
                    LPA = 8.82f,
                    VPA = 65.88f,
                    DPA = 2.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.21f,
                    PVPA = 2.06f,
                    PFCO = 36.40f,
                    DY = 2.47f,
                    PSR = 1.61f,
                    EVEBIT = 7.89f,
                    ROE = 25.07f,
                    ROIC = 12.11f,
                    LC = 1.66f,
                    DBPL = 0.43f,
                    LPA = 19.80f,
                    VPA = 78.99f,
                    DPA = 4.45f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 11.11f,
                    PVPA = 1.26f,
                    PFCO = 13.16f,
                    DY = 1.13f,
                    PSR = 0.93f,
                    EVEBIT = 9.24f,
                    ROE = 11.39f,
                    ROIC = 10.80f,
                    LC = 1.88f,
                    DBPL = 0.43f,
                    LPA = 6.68f,
                    VPA = 58.68f,
                    DPA = 0.89f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 21.06f,
                    PVPA = 2.62f,
                    PFCO = 22.11f,
                    DY = 0.83f,
                    PSR = 1.73f,
                    EVEBIT = 15.48f,
                    ROE = 12.46f,
                    ROIC = 11.71f,
                    LC = 1.83f,
                    DBPL = 0.38f,
                    LPA = 7.42f,
                    VPA = 59.55f,
                    DPA = 0.82f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 18.90f,
                    PVPA = 2.50f,
                    PFCO = 17.48f,
                    DY = 0.78f,
                    PSR = 1.60f,
                    EVEBIT = 13.71f,
                    ROE = 13.25f,
                    ROIC = 11.92f,
                    LC = 1.76f,
                    DBPL = 0.37f,
                    LPA = 7.94f,
                    VPA = 59.95f,
                    DPA = 1.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 17.23f,
                    PVPA = 2.44f,
                    PFCO = 21.76f,
                    DY = 1.16f,
                    PSR = 1.64f,
                    EVEBIT = 11.64f,
                    ROE = 14.17f,
                    ROIC = 12.83f,
                    LC = 1.78f,
                    DBPL = 0.32f,
                    LPA = 9.14f,
                    VPA = 64.50f,
                    DPA = 1.93f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 12.84f,
                    PVPA = 1.06f,
                    PFCO = 6.74f,
                    DY = 4.18f,
                    PSR = 0.69f,
                    EVEBIT = 11.58f,
                    ROE = 8.27f,
                    ROIC = 7.94f,
                    LC = 1.39f,
                    DBPL = 0.45f,
                    LPA = 4.43f,
                    VPA = 53.53f,
                    DPA = 2.49f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 14.70f,
                    PVPA = 1.04f,
                    PFCO = 6.51f,
                    DY = 3.84f,
                    PSR = 0.68f,
                    EVEBIT = 13.88f,
                    ROE = 7.11f,
                    ROIC = 7.29f,
                    LC = 1.40f,
                    DBPL = 0.49f,
                    LPA = 3.81f,
                    VPA = 53.63f,
                    DPA = 2.25f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 18.94f,
                    PVPA = 1.26f,
                    PFCO = 10.15f,
                    DY = 1.99f,
                    PSR = 0.85f,
                    EVEBIT = 16.75f,
                    ROE = 6.65f,
                    ROIC = 7.05f,
                    LC = 1.57f,
                    DBPL = 0.47f,
                    LPA = 3.59f,
                    VPA = 53.91f,
                    DPA = 1.46f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 11.94f,
                    PVPA = 1.05f,
                    PFCO = 9.09f,
                    DY = 2.29f,
                    PSR = 0.75f,
                    EVEBIT = 10.98f,
                    ROE = 8.78f,
                    ROIC = 8.56f,
                    LC = 1.57f,
                    DBPL = 0.44f,
                    LPA = 5.09f,
                    VPA = 57.95f,
                    DPA = 1.46f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_GUAR3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 17.62m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 18.01m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 11.34m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 12.55m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 19.88m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 8.72m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 11.18m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 17.84m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 17.85m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 6.62m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 6.57m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 7.97m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 7.13m));

            #endregion

            return ativos;
        }
    }
}
