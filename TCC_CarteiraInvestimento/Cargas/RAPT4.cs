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
        public static List<Cromossomo> RAPT4()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "RAPT4",
                Nome = "RANDON S.A. IMPLEMENTOS E PARTICIPAÇÕES",
                Setor = Setor.MaterialTransporte,
                PrecoAtivoNoPeriodo = ObterAtivos_RAPT4()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 22.00f,
                    PVPA = 0.99f,
                    PFCO = 3.54f,
                    DY = 0.51f,
                    PSR = 0.95f,
                    EVEBIT = 9.11f,
                    ROE = 4.43f,
                    ROIC = 5.43f,
                    LC = 1.81f,
                    DBPL = 1.04f,
                    LPA = 0.26f,
                    VPA = 5.76f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 21.59f,
                    PVPA = 1.09f,
                    PFCO = 6.46f,
                    DY = 1.46f,
                    PSR = 1.04f,
                    EVEBIT = 8.80f,
                    ROE = 5.08f,
                    ROIC = 5.49f,
                    LC = 2.06f,
                    DBPL = 1.25f,
                    LPA = 0.29f,
                    VPA = 5.73f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 26.09f,
                    PVPA = 1.55f,
                    PFCO = 29.84f,
                    DY = 1.63f,
                    PSR = 1.36f,
                    EVEBIT = 10.39f,
                    ROE = 5.88f,
                    ROIC = 5.79f,
                    LC = 2.57f,
                    DBPL = 1.47f,
                    LPA = 0.35f,
                    VPA = 5.90f,
                    DPA = 0.10f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 22.05f,
                    PVPA = 1.64f,
                    PFCO = 8.92f,
                    DY = 1.10f,
                    PSR = 1.25f,
                    EVEBIT = 10.21f,
                    ROE = 7.42f,
                    ROIC = 7.07f,
                    LC = 2.20f,
                    DBPL = 1.39f,
                    LPA = 0.44f,
                    VPA = 5.91f,
                    DPA = 0.12f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -30.00f,
                    PVPA = 0.86f,
                    PFCO = 4.83f,
                    DY = 0.00f,
                    PSR = 1.29f,
                    EVEBIT = 86.64f,
                    ROE = -2.92f,
                    ROIC = 0.10f,
                    LC = 2.34f,
                    DBPL = 1.19f,
                    LPA = -0.16f,
                    VPA = 5.55f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -54.15f,
                    PVPA = 1.27f,
                    PFCO = 7.04f,
                    DY = 0.00f,
                    PSR = 1.56f,
                    EVEBIT = 76.28f,
                    ROE = -2.29f,
                    ROIC = 0.50f,
                    LC = 2.37f,
                    DBPL = 1.13f,
                    LPA = -0.13f,
                    VPA = 5.56f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -358.50f,
                    PVPA = 1.26f,
                    PFCO = 7.30f,
                    DY = 0.63f,
                    PSR = 1.42f,
                    EVEBIT = 26.07f,
                    ROE = -0.27f,
                    ROIC = 1.88f,
                    LC = 2.30f,
                    DBPL = 1.05f,
                    LPA = -0.03f,
                    VPA = 5.67f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 65.07f,
                    PVPA = 1.65f,
                    PFCO = 6.91f,
                    DY = 0.61f,
                    PSR = 1.54f,
                    EVEBIT = 19.41f,
                    ROE = 2.45f,
                    ROIC = 3.44f,
                    LC = 1.96f,
                    DBPL = 1.16f,
                    LPA = 0.14f,
                    VPA = 5.52f,
                    DPA = 0.05f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_RAPT4()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 9.42m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 8.25m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 5.94m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 6.02m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 8.9m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 4.55m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 4.35m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 6.62m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 6.86m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 2.82m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 3.11m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 4.4m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 3.27m));

            #endregion

            return null;
        }
    }
}
