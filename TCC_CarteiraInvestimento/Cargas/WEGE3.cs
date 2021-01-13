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
        public static List<Cromossomo> WEGE3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "WEGE3",
                Nome = "WEG SA.",
                Setor = Setor.MaquinasEquipamentos,
                PrecoAtivoNoPeriodo = ObterAtivos_WEGE3()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 21.21f,
                    PVPA = 3.54f,
                    PFCO = 18.07f,
                    DY = 1.61f,
                    PSR = 2.73f,
                    EVEBIT = 19.82f,
                    ROE = 16.79f,
                    ROIC = 10.03f,
                    LC = 2.30f,
                    DBPL = 0.60f,
                    LPA = 0.72f,
                    VPA = 4.31f,
                    DPA = 0.36f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 25.99f,
                    PVPA = 4.23f,
                    PFCO = 24.33f,
                    DY = 2.10f,
                    PSR = 3.18f,
                    EVEBIT = 24.17f,
                    ROE = 16.35f,
                    ROIC = 10.21f,
                    LC = 2.01f,
                    DBPL = 0.55f,
                    LPA = 0.76f,
                    VPA = 4.67f,
                    DPA = 0.35f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 21.15f,
                    PVPA = 3.56f,
                    PFCO = 22.57f,
                    DY = 1.78f,
                    PSR = 2.58f,
                    EVEBIT = 20.24f,
                    ROE = 16.77f,
                    ROIC = 10.21f,
                    LC = 1.81f,
                    DBPL = 0.61f,
                    LPA = 0.81f,
                    VPA = 4.81f,
                    DPA = 0.40f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 21.69f,
                    PVPA = 3.70f,
                    PFCO = 22.36f,
                    DY = 1.98f,
                    PSR = 2.57f,
                    EVEBIT = 19.44f,
                    ROE = 17.04f,
                    ROIC = 11.64f,
                    LC = 1.87f,
                    DBPL = 0.48f,
                    LPA = 0.83f,
                    VPA = 4.86f,
                    DPA = 0.44f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 25.59f,
                    PVPA = 4.60f,
                    PFCO = 12.97f,
                    DY = 2.11f,
                    PSR = 3.47f,
                    EVEBIT = 25.89f,
                    ROE = 17.90f,
                    ROIC = 8.72f,
                    LC = 2.92f,
                    DBPL = 0.72f,
                    LPA = 0.68f,
                    VPA = 3.78f,
                    DPA = 0.37f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 25.65f,
                    PVPA = 4.43f,
                    PFCO = 17.27f,
                    DY = 2.07f,
                    PSR = 3.50f,
                    EVEBIT = 24.96f,
                    ROE = 17.17f,
                    ROIC = 8.66f,
                    LC = 2.46f,
                    DBPL = 0.72f,
                    LPA = 0.69f,
                    VPA = 4.00f,
                    DPA = 0.36f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 29.72f,
                    PVPA = 5.31f,
                    PFCO = 22.78f,
                    DY = 1.77f,
                    PSR = 4.03f,
                    EVEBIT = 28.73f,
                    ROE = 17.89f,
                    ROIC = 9.69f,
                    LC = 2.37f,
                    DBPL = 0.67f,
                    LPA = 0.72f,
                    VPA = 4.03f,
                    DPA = 0.38f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 32.68f,
                    PVPA = 5.47f,
                    PFCO = 29.03f,
                    DY = 1.48f,
                    PSR = 4.15f,
                    EVEBIT = 31.24f,
                    ROE = 16.69f,
                    ROIC = 9.94f,
                    LC = 2.18f,
                    DBPL = 0.59f,
                    LPA = 0.71f,
                    VPA = 4.24f,
                    DPA = 0.38f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_WEGE3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 17.74m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 16.83m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 15.73m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 19.29m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 17.2m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 12.74m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 12.95m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 15.76m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 17.85m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 10.02m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 9.86m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 12.78m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 11.27m));

            #endregion

            return ativos;
        }
    }
}
