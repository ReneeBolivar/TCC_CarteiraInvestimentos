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
        public static List<Cromossomo> VIVT4()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "VIVT4",
                Nome = "TELEFÔNICA BRASIL S.A.",
                Setor = Setor.TelefoniaFixa,
                PrecoAtivoNoPeriodo =ObterAtivos_VIVT4()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 16.48f,
                    PVPA = 1.10f,
                    PFCO = 5.59f,
                    DY = 4.61f,
                    PSR = 1.91f,
                    EVEBIT = 11.87f,
                    ROE = 6.69f,
                    ROIC = 7.01f,
                    LC = 1.01f,
                    DBPL = 0.11f,
                    LPA = 2.79f,
                    VPA = 41.65f,
                    DPA = 1.43f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.47f,
                    PVPA = 0.93f,
                    PFCO = 5.34f,
                    DY = 5.85f,
                    PSR = 1.64f,
                    EVEBIT = 8.06f,
                    ROE = 9.85f,
                    ROIC = 7.80f,
                    LC = 0.90f,
                    DBPL = 0.09f,
                    LPA = 4.14f,
                    VPA = 42.04f,
                    DPA = 1.43f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.60f,
                    PVPA = 1.08f,
                    PFCO = 7.03f,
                    DY = 10.72f,
                    PSR = 1.89f,
                    EVEBIT = 8.38f,
                    ROE = 12.54f,
                    ROIC = 9.24f,
                    LC = 0.91f,
                    DBPL = 0.09f,
                    LPA = 5.30f,
                    VPA = 42.26f,
                    DPA = 1.43f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.00f,
                    PVPA = 1.12f,
                    PFCO = 6.73f,
                    DY = 8.91f,
                    PSR = 1.96f,
                    EVEBIT = 8.79f,
                    ROE = 12.47f,
                    ROIC = 9.13f,
                    LC = 1.07f,
                    DBPL = 0.09f,
                    LPA = 5.28f,
                    VPA = 42.35f,
                    DPA = 2.69f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 20.50f,
                    PVPA = 1.13f,
                    PFCO = 7.15f,
                    DY = 4.50f,
                    PSR = 2.00f,
                    EVEBIT = 13.78f,
                    ROE = 5.54f,
                    ROIC = 6.29f,
                    LC = 1.06f,
                    DBPL = 0.16f,
                    LPA = 2.28f,
                    VPA = 41.27f,
                    DPA = 1.28f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 18.79f,
                    PVPA = 1.11f,
                    PFCO = 6.58f,
                    DY = 5.16f,
                    PSR = 1.89f,
                    EVEBIT = 12.35f,
                    ROE = 5.88f,
                    ROIC = 6.58f,
                    LC = 0.96f,
                    DBPL = 0.15f,
                    LPA = 2.39f,
                    VPA = 40.60f,
                    DPA = 1.28f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 19.07f,
                    PVPA = 1.18f,
                    PFCO = 6.66f,
                    DY = 4.17f,
                    PSR = 2.02f,
                    EVEBIT = 12.71f,
                    ROE = 6.20f,
                    ROIC = 6.89f,
                    LC = 0.96f,
                    DBPL = 0.12f,
                    LPA = 2.55f,
                    VPA = 41.11f,
                    DPA = 1.28f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 18.09f,
                    PVPA = 1.20f,
                    PFCO = 6.61f,
                    DY = 5.44f,
                    PSR = 2.06f,
                    EVEBIT = 13.25f,
                    ROE = 6.64f,
                    ROIC = 7.07f,
                    LC = 0.94f,
                    DBPL = 0.12f,
                    LPA = 2.73f,
                    VPA = 41.08f,
                    DPA = 1.43f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_VIVT4()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 42.44m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 41.06m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 38.82m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 34.22m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 40.97m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 36.31m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 35.85m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 40.38m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 39.62m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 33.64m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 33.6m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 35.9m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 33.97m));

            #endregion

            return ativos;
        }
    }
}
