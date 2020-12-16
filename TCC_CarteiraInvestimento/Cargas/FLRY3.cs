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
        public static List<Cromossomo> FLRY3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "FLRY3",
                Nome = "FLEURY SA.",
                Setor = Setor.Saude,
                PrecoAtivoNoPeriodo = ObterAtivos_FLRY3()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 21.78f,
                    PVPA = 4.56f,
                    PFCO = 13.31f,
                    DY = 3.56f,
                    PSR = 3.21f,
                    EVEBIT = 16.06f,
                    ROE = 20.96f,
                    ROIC = 15.30f,
                    LC = 1.37f,
                    DBPL = 0.55f,
                    LPA = 1.09f,
                    VPA = 5.21f,
                    DPA = 0.33f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 19.54f,
                    PVPA = 3.87f,
                    PFCO = 10.93f,
                    DY = 3.65f,
                    PSR = 3.01f,
                    EVEBIT = 14.18f,
                    ROE = 19.78f,
                    ROIC = 12.40f,
                    LC = 2.35f,
                    DBPL = 0.81f,
                    LPA = 1.09f,
                    VPA = 5.50f,
                    DPA = 0.33f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 17.69f,
                    PVPA = 3.46f,
                    PFCO = 9.94f,
                    DY = 4.51f,
                    PSR = 2.71f,
                    EVEBIT = 12.85f,
                    ROE = 19.57f,
                    ROIC = 12.34f,
                    LC = 2.30f,
                    DBPL = 0.80f,
                    LPA = 1.10f,
                    VPA = 5.63f,
                    DPA = 0.32f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 18.89f,
                    PVPA = 3.58f,
                    PFCO = 8.93f,
                    DY = 4.84f,
                    PSR = 2.74f,
                    EVEBIT = 13.34f,
                    ROE = 18.95f,
                    ROIC = 12.75f,
                    LC = 2.30f,
                    DBPL = 0.72f,
                    LPA = 1.08f,
                    VPA = 5.70f,
                    DPA = 0.32f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 24.88f,
                    PVPA = 4.27f,
                    PFCO = 12.57f,
                    DY = 13.76f,
                    PSR = 3.28f,
                    EVEBIT = 18.08f,
                    ROE = 17.16f,
                    ROIC = 13.23f,
                    LC = 1.67f,
                    DBPL = 0.53f,
                    LPA = 1.70f,
                    VPA = 9.91f,
                    DPA = 1.46f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 26.80f,
                    PVPA = 5.00f,
                    PFCO = 15.68f,
                    DY = 10.39f,
                    PSR = 3.89f,
                    EVEBIT = 20.34f,
                    ROE = 18.67f,
                    ROIC = 14.23f,
                    LC = 1.76f,
                    DBPL = 0.50f,
                    LPA = 1.00f,
                    VPA = 5.36f,
                    DPA = 0.75f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 27.42f,
                    PVPA = 5.42f,
                    PFCO = 16.75f,
                    DY = 9.33f,
                    PSR = 4.14f,
                    EVEBIT = 21.06f,
                    ROE = 19.74f,
                    ROIC = 14.97f,
                    LC = 1.82f,
                    DBPL = 0.51f,
                    LPA = 1.08f,
                    VPA = 5.46f,
                    DPA = 0.83f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 26.42f,
                    PVPA = 4.94f,
                    PFCO = 15.93f,
                    DY = 2.60f,
                    PSR = 3.85f,
                    EVEBIT = 18.49f,
                    ROE = 18.79f,
                    ROIC = 13.39f,
                    LC = 1.98f,
                    DBPL = 0.62f,
                    LPA = 1.04f,
                    VPA = 5.56f,
                    DPA = 0.33f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_FLRY3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 19.75m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 25.24m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 24.6m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 19.8m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 18.4m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 19.04m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 24.12m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 26.67m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 26.8m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 8.99m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 11.52m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 16.18m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 15.87m));

            #endregion

            return null;
        }
    }
}
