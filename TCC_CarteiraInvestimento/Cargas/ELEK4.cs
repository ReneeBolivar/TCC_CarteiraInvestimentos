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
        public static List<Cromossomo> ELEK4()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "ELEK4",
                Nome = "ELEKEIROZ S/A.",
                Setor = Setor.Quimicos
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 4.02f,
                    PVPA = 1.52f,
                    PFCO = 3.26f,
                    DY = 2.15f,
                    PSR = 0.31f,
                    EVEBIT = 4.88f,
                    ROE = 37.99f,
                    ROIC = 23.67f,
                    LC = 1.54f,
                    DBPL = 1.02f,
                    LPA = 1.99f,
                    VPA = 5.25f,
                    DPA = 0.25f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 3.02f,
                    PVPA = 1.26f,
                    PFCO = 5.16f,
                    DY = 3.08f,
                    PSR = 0.46f,
                    EVEBIT = 3.98f,
                    ROE = 41.82f,
                    ROIC = 17.61f,
                    LC = 2.56f,
                    DBPL = 1.80f,
                    LPA = 2.55f,
                    VPA = 6.10f,
                    DPA = 0.25f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 4.41f,
                    PVPA = 1.98f,
                    PFCO = -46.56f,
                    DY = 3.20f,
                    PSR = 0.48f,
                    EVEBIT = 5.21f,
                    ROE = 44.88f,
                    ROIC = 24.61f,
                    LC = 2.10f,
                    DBPL = 1.12f,
                    LPA = 2.73f,
                    VPA = 6.09f,
                    DPA = 0.92f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 6.14f,
                    PVPA = 2.19f,
                    PFCO = 6.52f,
                    DY = 10.41f,
                    PSR = 0.48f,
                    EVEBIT = 5.81f,
                    ROE = 35.66f,
                    ROIC = 20.30f,
                    LC = 1.95f,
                    DBPL = 1.24f,
                    LPA = 2.10f,
                    VPA = 5.90f,
                    DPA = 1.01f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -0.58f,
                    PVPA = 1.74f,
                    PFCO = 6.67f,
                    DY = 0.00f,
                    PSR = 0.40f,
                    EVEBIT = -1.35f,
                    ROE = -298.23f,
                    ROIC = -99.53f,
                    LC = 1.74f,
                    DBPL = 1.83f,
                    LPA = -10.44f,
                    VPA = 3.50f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -0.59f,
                    PVPA = 1.53f,
                    PFCO = 6.80f,
                    DY = 0.00f,
                    PSR = 0.36f,
                    EVEBIT = -1.43f,
                    ROE = -257.18f,
                    ROIC = -91.07f,
                    LC = 1.81f,
                    DBPL = 1.65f,
                    LPA = -9.77f,
                    VPA = 3.80f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -0.79f,
                    PVPA = 1.64f,
                    PFCO = 4.87f,
                    DY = 0.00f,
                    PSR = 0.35f,
                    EVEBIT = -1.68f,
                    ROE = -207.88f,
                    ROIC = -78.33f,
                    LC = 1.54f,
                    DBPL = 1.47f,
                    LPA = -8.89f,
                    VPA = 4.28f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.62f,
                    PVPA = 2.40f,
                    PFCO = 3.45f,
                    DY = 0.00f,
                    PSR = 0.46f,
                    EVEBIT = 7.11f,
                    ROE = 31.51f,
                    ROIC = 20.61f,
                    LC = 1.66f,
                    DBPL = 1.12f,
                    LPA = 1.51f,
                    VPA = 4.80f,
                    DPA = 0.25f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -9.46f,
                    PVPA = 0.50f,
                    PFCO = -410.42f,
                    DY = 0.00f,
                    PSR = 0.33f,
                    EVEBIT = -19.68f,
                    ROE = -5.29f,
                    ROIC = -1.38f,
                    LC = 1.70f,
                    DBPL = 0.43f,
                    LPA = -0.74f,
                    VPA = 13.94f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -6.12f,
                    PVPA = 0.38f,
                    PFCO = 49.03f,
                    DY = 0.00f,
                    PSR = 0.29f,
                    EVEBIT = -14.02f,
                    ROE = -6.32f,
                    ROIC = -1.61f,
                    LC = 1.61f,
                    DBPL = 0.42f,
                    LPA = -0.85f,
                    VPA = 13.56f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -3.21f,
                    PVPA = 0.40f,
                    PFCO = 2.94f,
                    DY = 0.00f,
                    PSR = 0.39f,
                    EVEBIT = -5.06f,
                    ROE = -12.47f,
                    ROIC = -5.78f,
                    LC = 2.33f,
                    DBPL = 0.50f,
                    LPA = -1.64f,
                    VPA = 13.17f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = -0.39f,
                    PVPA = 1.20f,
                    PFCO = 23.08f,
                    DY = 0.00f,
                    PSR = 0.37f,
                    EVEBIT = -1.06f,
                    ROE = -308.56f,
                    ROIC = -99.41f,
                    LC = 1.79f,
                    DBPL = 1.95f,
                    LPA = -10.92f,
                    VPA = 3.54f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }
    }
}
