using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> TRPN3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Nome = "TARPON INVESTIMENTOS S/A.",
                Codigo = "TRPN3",
                Setor = Setor.HoldingsDiversificadas
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 12.14f,
                    PVPA = 2.28f,
                    PFCO = 13.12f,
                    DY = 0.00f,
                    PSR = 2.53f,
                    EVEBIT = 5.00f,
                    ROE = 18.37f,
                    ROIC = 15.20f,
                    LC = 3.33f,
                    DBPL = 0.00f,
                    LPA = 0.21f,
                    VPA = 1.12f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 27.88f,
                    PVPA = 0.00f,
                    PFCO = 16.32f,
                    DY = 2.14f,
                    PSR = 2.94f,
                    EVEBIT = 17.51f,
                    ROE = 6341.08f,
                    ROIC = 4135.31f,
                    LC = 7.00f,
                    DBPL = 0.0f,
                    LPA = 0.08f,
                    VPA = 0.00f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 53.25f,
                    PVPA = 1.57f,
                    PFCO = 42.33f,
                    DY = 2.40f,
                    PSR = 3.19f,
                    EVEBIT = 10.60f,
                    ROE = 3.29f,
                    ROIC = 0.47f,
                    LC = 6.70f,
                    DBPL = 0.0f,
                    LPA = 0.04f,
                    VPA = 1.36f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 0.86f,
                    PVPA = 0.82f,
                    PFCO = 0.60f,
                    DY = 53.36f,
                    PSR = 0.38f,
                    EVEBIT = -0.56f,
                    ROE = 95.84f,
                    ROIC = 83.92f,
                    LC = 1.76f,
                    DBPL = 0.0f,
                    LPA = 1.27f,
                    VPA = 1.33f,
                    DPA = 1.18f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 16.55f,
                    PVPA = 5.16f,
                    PFCO = 13.08f,
                    DY = 2.41f,
                    PSR = 4.04f,
                    EVEBIT = 9.10f,
                    ROE = 31.48f,
                    ROIC = 28.28f,
                    LC = 3.24f,
                    DBPL = 0.0f,
                    LPA = 0.29f,
                    VPA = 0.93f,
                    DPA = 0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 12.76f,
                    PVPA = 3.43f,
                    PFCO = 8.47f,
                    DY = 3.86f,
                    PSR = 3.26f,
                    EVEBIT = 7.28f,
                    ROE = 26.65f,
                    ROIC = 22.99f,
                    LC = 5.22f,
                    DBPL = 0.0f,
                    LPA = 0.29f,
                    VPA = 1.08f,
                    DPA = 0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.00f,
                    PVPA = 2.65f,
                    PFCO = 6.87f,
                    DY = 2.84f,
                    PSR = 2.71f,
                    EVEBIT = 6.06f,
                    ROE = 21.79f,
                    ROIC = 17.96f,
                    LC = 5.71f,
                    DBPL = 0.0f,
                    LPA = 0.25f,
                    VPA = 1.13f,
                    DPA = 0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 11.43f,
                    PVPA = 2.00f,
                    PFCO = 7.48f,
                    DY = 3.81f,
                    PSR = 2.25f,
                    EVEBIT = 3.68f,
                    ROE = 17.87f,
                    ROIC = 15.05f,
                    LC = 5.54f,
                    DBPL = 0.0f,
                    LPA = 0.21f,
                    VPA = 1.20f,
                    DPA = 0.05f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 27.92f,
                    PVPA = 7.44f,
                    PFCO = 17.62f,
                    DY = 1.54f,
                    PSR = 4.18f,
                    EVEBIT = 10.41f,
                    ROE = 26.73f,
                    ROIC = 42.64f,
                    LC = 3.42f,
                    DBPL = 0.0f,
                    LPA = 0.24f,
                    VPA = 0.90f,
                    DPA = 0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 31.43f,
                    PVPA = 7.67f,
                    PFCO = 22.55f,
                    DY = 1.58f,
                    PSR = 4.47f,
                    EVEBIT = 11.85f,
                    ROE = 24.77f,
                    ROIC = 39.98f,
                    LC = 11.16f,
                    DBPL = 0.0f,
                    LPA = 0.21f,
                    VPA = 0.86f,
                    DPA = 0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 54.17f,
                    PVPA = 6.57f,
                    PFCO = 30.21f,
                    DY = 0.66f,
                    PSR = 4.83f,
                    EVEBIT = 14.99f,
                    ROE = 12.30f,
                    ROIC = 25.54f,
                    LC = 3.42f,
                    DBPL = 0.0f,
                    LPA = 0.24f,
                    VPA = 0.90f,
                    DPA = 0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 42.86f,
                    PVPA = 5.50f,
                    PFCO = 32.70f,
                    DY = 0.71f,
                    PSR = 4.81f,
                    EVEBIT = 16.55f,
                    ROE = 13.11f,
                    ROIC = 17.28f,
                    LC = 8.42f,
                    DBPL = 0.0f,
                    LPA = 0.14f,
                    VPA = 1.09f,
                    DPA = 0.04f
                }));

            #endregion

            return localList;
        }
    }
}
