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
        public static List<Cromossomo> SSBR3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "SSBR3",
                Nome = "SONAE SIERRA BRASIL S/A.",
                Setor = Setor.ExploracaoImoveis,
                PrecoAtivoNoPeriodo = ObterAtivos_SSBR3()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.79f,
                    PVPA = 0.39f,
                    PFCO = 8.29f,
                    DY = 1.89f,
                    PSR = 5.54f,
                    EVEBIT = 4.95f,
                    ROE = 4.00f,
                    ROIC = 7.28f,
                    LC = 1.15f,
                    DBPL = 0.22f,
                    LPA = 1.91f,
                    VPA = 47.66f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 11.28f,
                    PVPA = 0.40f,
                    PFCO = 8.30f,
                    DY = 2.46f,
                    PSR = 5.69f,
                    EVEBIT = 5.00f,
                    ROE = 3.57f,
                    ROIC = 7.09f,
                    LC = 1.14f,
                    DBPL = 0.21f,
                    LPA = 1.74f,
                    VPA = 48.64f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 14.11f,
                    PVPA = 0.52f,
                    PFCO = 11.02f,
                    DY = 2.32f,
                    PSR = 6.78f,
                    EVEBIT = 5.93f,
                    ROE = 3.68f,
                    ROIC = 7.22f,
                    LC = 1.16f,
                    DBPL = 0.21f,
                    LPA = 1.80f,
                    VPA = 48.99f,
                    DPA = -1.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 11.57f,
                    PVPA = 0.56f,
                    PFCO = 11.70f,
                    DY = 1.77f,
                    PSR = 7.38f,
                    EVEBIT = 4.78f,
                    ROE = 4.84f,
                    ROIC = 8.91f,
                    LC = 1.35f,
                    DBPL = 0.20f,
                    LPA = 2.48f,
                    VPA = 51.12f,
                    DPA = -1.22f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 17.77f,
                    PVPA = 0.49f,
                    PFCO = 10.47f,
                    DY = 2.06f,
                    PSR = 6.45f,
                    EVEBIT = 5.85f,
                    ROE = 2.74f,
                    ROIC = 7.28f,
                    LC = 0.86f,
                    DBPL = 0.21f,
                    LPA = 1.25f,
                    VPA = 45.50f,
                    DPA = 0.17f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 14.13f,
                    PVPA = 0.58f,
                    PFCO = 12.16f,
                    DY = 2.38f,
                    PSR = 7.35f,
                    EVEBIT = 5.93f,
                    ROE = 4.10f,
                    ROIC = 8.15f,
                    LC = 0.85f,
                    DBPL = 0.21f,
                    LPA = 1.91f,
                    VPA = 46.61f,
                    DPA = 0.17f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.87f,
                    PVPA = 0.54f,
                    PFCO = 10.98f,
                    DY = 1.59f,
                    PSR = 7.61f,
                    EVEBIT = 5.55f,
                    ROE = 4.21f,
                    ROIC = 7.77f,
                    LC = 1.82f,
                    DBPL = 0.27f,
                    LPA = 1.97f,
                    VPA = 46.89f,
                    DPA = 0.88f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.26f,
                    PVPA = 0.51f,
                    PFCO = 10.73f,
                    DY = 1.79f,
                    PSR = 7.22f,
                    EVEBIT = 6.17f,
                    ROE = 3.83f,
                    ROIC = 6.87f,
                    LC = 1.61f,
                    DBPL = 0.27f,
                    LPA = 1.81f,
                    VPA = 47.30f,
                    DPA = 0.88f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_SSBR3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 28.7m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 24.12m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 18.5m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 19.63m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 25.77m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 22.21m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 19.24m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 28.6m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 25.35m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 15.87m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 17.28m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 18.5m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 17.23m));

            #endregion

            return null;
        }
    }
}
