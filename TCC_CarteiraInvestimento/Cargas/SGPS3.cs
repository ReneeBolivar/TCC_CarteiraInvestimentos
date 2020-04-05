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
        public static List<Cromossomo> SGPS3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "SGPS3",
                Nome = "SPRINGS GLOBAL PARTICIPAÇÕES S/A.",
                Setor = Setor.TecidosVestuarioCalcados
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 12.43f,
                    PVPA = 0.29f,
                    PFCO = 34.06f,
                    DY = 0.00f,
                    PSR = 0.47f,
                    EVEBIT = 7.05f,
                    ROE = 2.31f,
                    ROIC = 9.06f,
                    LC = 1.92f,
                    DBPL = 0.99f,
                    LPA = 0.53f,
                    VPA = 22.79f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.48f,
                    PVPA = 0.26f,
                    PFCO = 6.50f,
                    DY = 0.00f,
                    PSR = 0.43f,
                    EVEBIT = 7.13f,
                    ROE = 2.76f,
                    ROIC = 10.16f,
                    LC = 1.68f,
                    DBPL = 0.97f,
                    LPA = 0.64f,
                    VPA = 23.30f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 44.13f,
                    PVPA = 0.29f,
                    PFCO = 9.41f,
                    DY = 0.00f,
                    PSR = 0.47f,
                    EVEBIT = 7.77f,
                    ROE = 0.64f,
                    ROIC = 9.60f,
                    LC = 1.73f,
                    DBPL = 1.02f,
                    LPA = 0.15f,
                    VPA = 23.21f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.00f,
                    PSR = 0.00f,
                    EVEBIT = 0.00f,
                    ROE = 0.00f,
                    ROIC = 0.00f,
                    LC = 0.00f,
                    DBPL = 0.00f,
                    LPA = 0.00f,
                    VPA = 0.00f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 156.00f,
                    PVPA = 0.46f,
                    PFCO = 20.27f,
                    DY = 0.00f,
                    PSR = 0.47f,
                    EVEBIT = 8.71f,
                    ROE = 0.28f,
                    ROIC = 10.58f,
                    LC = 1.71f,
                    DBPL = 1.06f,
                    LPA = 0.06f,
                    VPA = 20.22f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 38.97f,
                    PVPA = 0.58f,
                    PFCO = 8.38f,
                    DY = 0.00f,
                    PSR = 0.53f,
                    EVEBIT = 9.55f,
                    ROE = 1.46f,
                    ROIC = 10.81f,
                    LC = 1.71f,
                    DBPL = 1.07f,
                    LPA = 0.30f,
                    VPA = 20.25f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 17.16f,
                    PVPA = 0.53f,
                    PFCO = 7.02f,
                    DY = 0.00f,
                    PSR = 0.52f,
                    EVEBIT = 9.48f,
                    ROE = 3.12f,
                    ROIC = 10.70f,
                    LC = 1.72f,
                    DBPL = 1.06f,
                    LPA = 0.63f,
                    VPA = 20.33f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 25.05f,
                    PVPA = 0.46f,
                    PFCO = 9.74f,
                    DY = 0.00f,
                    PSR = 0.52f,
                    EVEBIT = 7.80f,
                    ROE = 1.83f,
                    ROIC = 9.30f,
                    LC = 1.76f,
                    DBPL = 0.94f,
                    LPA = 0.42f,
                    VPA = 22.99f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -25.46f,
                    PVPA = 0.16f,
                    PFCO = -1.23f,
                    DY = 0.00f,
                    PSR = 0.33f,
                    EVEBIT = 5.91f,
                    ROE = -0.64f,
                    ROIC = 7.35f,
                    LC = 1.90f,
                    DBPL = 1.04f,
                    LPA = -0.13f,
                    VPA = 20.78f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -9.14f,
                    PVPA = 0.16f,
                    PFCO = -1.87f,
                    DY = 0.00f,
                    PSR = 0.28f,
                    EVEBIT = 6.56f,
                    ROE = 1.75f,
                    ROIC = 7.38f,
                    LC = 1.57f,
                    DBPL = 1.02f,
                    LPA = -0.36f,
                    VPA = 20.40f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -5.98f,
                    PVPA = 0.19f,
                    PFCO = -1.94f,
                    DY = 0.00f,
                    PSR = 0.29f,
                    EVEBIT = 6.17f,
                    ROE = -3.23f,
                    ROIC = 7.96f,
                    LC = 1.56f,
                    DBPL = 1.07f,
                    LPA = -0.65f,
                    VPA = 20.26f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = -28.33f,
                    PVPA = 0.21f,
                    PFCO = 874.49f,
                    DY = 0.00f,
                    PSR = 0.34f,
                    EVEBIT = 6.71f,
                    ROE = -0.73f,
                    ROIC = 10.68f,
                    LC = 1.67f,
                    DBPL = 1.07f,
                    LPA = -0.15f,
                    VPA = 20.56f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }
    }
}
