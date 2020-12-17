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
        public static List<Cromossomo> IGTA3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "IGTA3",
                Nome = "IGUATEMI EMPRESA DE SHOPPING CENTERS S/A.",
                Setor = Setor.ExploracaoImoveis,
                PrecoAtivoNoPeriodo = ObterAtivos_IGTA3()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 31.16f,
                    PVPA = 2.47f,
                    PFCO = 18.95f,
                    DY = 0.00f,
                    PSR = 12.51f,
                    EVEBIT = 19.73f,
                    ROE = 7.95f,
                    ROIC = 7.99f,
                    LC = 1.55f,
                    DBPL = 0.70f,
                    LPA = 1.26f,
                    VPA = 15.89f,
                    DPA = 0.29f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 23.36f,
                    PVPA = 1.95f,
                    PFCO = 16.57f,
                    DY = 0.00f,
                    PSR = 10.63f,
                    EVEBIT = 16.28f,
                    ROE = 8.33f,
                    ROIC = 7.52f,
                    LC = 2.11f,
                    DBPL = 0.80f,
                    LPA = 1.32f,
                    VPA = 15.80f,
                    DPA = 0.20f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 22.50f,
                    PVPA = 1.94f,
                    PFCO = 13.91f,
                    DY = 0.00f,
                    PSR = 10.56f,
                    EVEBIT = 16.16f,
                    ROE = 8.64f,
                    ROIC = 7.51f,
                    LC = 2.44f,
                    DBPL = 0.78f,
                    LPA = 1.38f,
                    VPA = 16.01f,
                    DPA = 0.29f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 28.69f,
                    PVPA = 2.58f,
                    PFCO = 18.02f,
                    DY = 0.00f,
                    PSR = 13.15f,
                    EVEBIT = 19.91f,
                    ROE = 9.01f,
                    ROIC = 7.46f,
                    LC = 3.38f,
                    DBPL = 0.79f,
                    LPA = 1.45f,
                    VPA = 16.12f,
                    DPA = 0.34f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 33.47f,
                    PVPA = 2.09f,
                    PFCO = 13.01f,
                    DY = 0.00f,
                    PSR = 11.18f,
                    EVEBIT = 18.19f,
                    ROE = 6.24f,
                    ROIC = 7.88f,
                    LC = 1.40f,
                    DBPL = 0.73f,
                    LPA = 0.98f,
                    VPA = 15.72f,
                    DPA = 0.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 30.77f,
                    PVPA = 2.11f,
                    PFCO = 12.33f,
                    DY = 0.00f,
                    PSR = 11.08f,
                    EVEBIT = 17.84f,
                    ROE = 6.88f,
                    ROIC = 8.05f,
                    LC = 1.21f,
                    DBPL = 0.73f,
                    LPA = 1.07f,
                    VPA = 15.57f,
                    DPA = 0.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 34.44f,
                    PVPA = 2.48f,
                    PFCO = 17.28f,
                    DY = 0.00f,
                    PSR = 12.93f,
                    EVEBIT = 20.26f,
                    ROE = 7.21f,
                    ROIC = 7.65f,
                    LC = 2.15f,
                    DBPL = 0.80f,
                    LPA = 1.14f,
                    VPA = 15.84f,
                    DPA = 0.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 32.29f,
                    PVPA = 2.48f,
                    PFCO = 20.34f,
                    DY = 0.00f,
                    PSR = 12.79f,
                    EVEBIT = 19.80f,
                    ROE = 7.69f,
                    ROIC = 7.97f,
                    LC = 2.05f,
                    DBPL = 0.75f,
                    LPA = 1.22f,
                    VPA = 15.89f,
                    DPA = 0.29f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_IGTA3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 37.87m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 37.49m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 30.01m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 30.22m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 40.48m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 30.69m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 31.45m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 37.49m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 37.62m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 22.8m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 26.38m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 27.29m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 24.97m));

            #endregion

            return null;
        }
    }
}
