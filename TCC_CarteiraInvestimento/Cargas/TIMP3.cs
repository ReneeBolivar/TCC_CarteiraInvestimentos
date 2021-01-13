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
        public static List<Cromossomo> TIMP3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "TIMP3",
                Nome = "TIM PARTICIPAÇÕES SA.",
                Setor = Setor.TelefoniaMovel,
                PrecoAtivoNoPeriodo = ObterAtivos_TIMP3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 22.55f,
                    PVPA = 1.67f,
                    PFCO = 4.51f,
                    DY = 0.97f,
                    PSR = 2.03f,
                    EVEBIT = 14.52f,
                    ROE = 7.35f,
                    ROIC = 8.59f,
                    LC = 1.06f,
                    DBPL = 0.21f,
                    LPA = 0.56f,
                    VPA = 7.57f,
                    DPA = 0.11f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 19.55f,
                    PVPA = 1.54f,
                    PFCO = 4.36f,
                    DY = 1.64f,
                    PSR = 1.86f,
                    EVEBIT = 13.02f,
                    ROE = 7.93f,
                    ROIC = 9.41f,
                    LC = 1.05f,
                    DBPL = 0.20f,
                    LPA = 0.60f,
                    VPA = 7.62f,
                    DPA = 0.20f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 11.19f,
                    PVPA = 1.44f,
                    PFCO = 4.39f,
                    DY = 2.69f,
                    PSR = 1.77f,
                    EVEBIT = 12.49f,
                    ROE = 12.88f,
                    ROIC = 14.24f,
                    LC = 0.93f,
                    DBPL = 0.12f,
                    LPA = 1.04f,
                    VPA = 8.07f,
                    DPA = 0.11f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 11.23f,
                    PVPA = 1.44f,
                    PFCO = 4.66f,
                    DY = 3.32f,
                    PSR = 0.74f,
                    EVEBIT = 11.73f,
                    ROE = 12.86f,
                    ROIC = 14.37f,
                    LC = 0.85f,
                    DBPL = 0.08f,
                    LPA = 1.05f,
                    VPA = 8.18f,
                    DPA = 0.35f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 32.58f,
                    PVPA = 1.41f,
                    PFCO = 4.82f,
                    DY = 1.92f,
                    PSR = 1.90f,
                    EVEBIT = 18.28f,
                    ROE = 4.36f,
                    ROIC = 4.98f,
                    LC = 1.39f,
                    DBPL = 0.39f,
                    LPA = 0.31f,
                    VPA = 7.16f,
                    DPA = 0.06f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 32.19f,
                    PVPA = 1.64f,
                    PFCO = 5.79f,
                    DY = 0.63f,
                    PSR = 2.11f,
                    EVEBIT = 19.81f,
                    ROE = 5.12f,
                    ROIC = 5.51f,
                    LC = 1.33f,
                    DBPL = 0.35f,
                    LPA = 0.37f,
                    VPA = 7.25f,
                    DPA = 0.06f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 31.95f,
                    PVPA = 1.78f,
                    PFCO = 6.49f,
                    DY = 0.53f,
                    PSR = 2.25f,
                    EVEBIT = 18.89f,
                    ROE = 5.58f,
                    ROIC = 6.62f,
                    LC = 1.31f,
                    DBPL = 0.33f,
                    LPA = 0.41f,
                    VPA = 7.36f,
                    DPA = 0.06f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 28.69f,
                    PVPA = 1.95f,
                    PFCO = 6.55f,
                    DY = 1.07f,
                    PSR = 2.39f,
                    EVEBIT = 18.82f,
                    ROE = 6.80f,
                    ROIC = 7.58f,
                    LC = 1.05f,
                    DBPL = 0.26f,
                    LPA = 0.51f,
                    VPA = 7.50f,
                    DPA = 0.11f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 10.26f,
                    PVPA = 1.16f,
                    PFCO = 4.61f,
                    DY = 1.84f,
                    PSR = 1.50f,
                    EVEBIT = 7.52f,
                    ROE = 11.30f,
                    ROIC = 9.03f,
                    LC = 1.41f,
                    DBPL = 0.42f,
                    LPA = 0.78f,
                    VPA = 6.89f,
                    DPA = 0.19f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 15.91f,
                    PVPA = 0.99f,
                    PFCO = 3.99f,
                    DY = 2.85f,
                    PSR = 1.38f,
                    EVEBIT = 10.20f,
                    ROE = 6.17f,
                    ROIC = 6.16f,
                    LC = 1.52f,
                    DBPL = 0.37f,
                    LPA = 0.43f,
                    VPA = 6.93f,
                    DPA = 0.19f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 21.94f,
                    PVPA = 1.13f,
                    PFCO = 4.09f,
                    DY = 2.43f,
                    PSR = 1.55f,
                    EVEBIT = 14.19f,
                    ROE = 5.08f,
                    ROIC = 4.99f,
                    LC = 1.47f,
                    DBPL = 0.36f,
                    LPA = 0.36f,
                    VPA = 7.01f,
                    DPA = 0.19f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 25.26f,
                    PVPA = 1.10f,
                    PFCO = 3.80f,
                    DY = 2.47f,
                    PSR = 1.57f,
                    EVEBIT = 14.09f,
                    ROE = 4.37f,
                    ROIC = 4.86f,
                    LC = 1.39f,
                    DBPL = 0.39f,
                    LPA = 0.31f,
                    VPA = 7.10f,
                    DPA = 0.06f
                }));

            #endregion


            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_TIMP3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 11.31m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 13.42m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 12.39m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 11.11m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 11.23m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 9.3m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 9.06m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 10.69m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 12.22m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 7.16m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 6.29m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 7.27m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 7.21m));

            #endregion

            return ativos;
        }
    }
}
