using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {

        public static List<Cromossomo> BRAP3()
        {
            var localList = new List<Cromossomo>();

            var empresa = new Empresa
            {
                Codigo = "BRAP3",
                Nome = "BRADESPAR S/A.",
                Setor = Setor.HoldingsDiversificadas
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.35f,
                    PVPA = 1.02f,
                    PFCO = 52.99f,
                    DY = 4.64f,
                    PSR = 0.00f,
                    EVEBIT = 4.63f,
                    ROE = 19.07f,
                    ROIC = 16.48f,
                    LC = 0.73f,
                    DBPL = 0.20f,
                    LPA = 4.64f,
                    VPA = 24.33f,
                    DPA = 2.16f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 10.10f,
                    PVPA = 1.30f,
                    PFCO = -241.14f,
                    DY = 8.04f,
                    PSR = 0.00f,
                    EVEBIT = 9.36f,
                    ROE = 12.88f,
                    ROIC = 11.58f,
                    LC = 0.41f,
                    DBPL = 0.16f,
                    LPA = 3.20f,
                    VPA = 24.87f,
                    DPA = 2.16f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 17.57f,
                    PVPA = 1.07f,
                    PFCO = -9.17f,
                    DY = 6.30f,
                    PSR = 0.00f,
                    EVEBIT = 12.16f,
                    ROE = 6.07f,
                    ROIC = 5.92f,
                    LC = 0.62f,
                    DBPL = 0.08f,
                    LPA = 1.59f,
                    VPA = 26.20f,
                    DPA = 2.16f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.96f,
                    PVPA = 0.95f,
                    PFCO = -12.12f,
                    DY = 5.99f,
                    PSR = 0.00f,
                    EVEBIT = 7.48f,
                    ROE = 11.95f,
                    ROIC = 12.06f,
                    LC = 1.23f,
                    DBPL = 0.02f,
                    LPA = 3.41f,
                    VPA = 28.49f,
                    DPA = 1.19f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.27f,
                    PVPA = 0.81f,
                    PFCO = 92.50f,
                    DY = 0.53f,
                    PSR = 0.00f,
                    EVEBIT = 7.36f,
                    ROE = 8.71f,
                    ROIC = 8.66f,
                    LC = 2.41f,
                    DBPL = 0.19f,
                    LPA = 2.05f,
                    VPA = 23.59f,
                    DPA = 0.56f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 17.38f,
                    PVPA = 0.88f,
                    PFCO = 26.09f,
                    DY = 2.97f,
                    PSR = 0.00f,
                    EVEBIT = 11.82f,
                    ROE = 5.05f,
                    ROIC = 5.51f,
                    LC = 3.00f,
                    DBPL = 0.20f,
                    LPA = 1.20f,
                    VPA = 23.78f,
                    DPA = 0.56f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.27f,
                    PVPA = 0.97f,
                    PFCO = 31.62f,
                    DY = 2.55f,
                    PSR = 0.00f,
                    EVEBIT = 6.98f,
                    ROE = 11.74f,
                    ROIC = 11.00f,
                    LC = 0.84f,
                    DBPL = 0.19f,
                    LPA = 2.99f,
                    VPA = 25.51f,
                    DPA = 0.56f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 4.12f,
                    PVPA = 1.09f,
                    PFCO = -171.51f,
                    DY = 5.25f,
                    PSR = 0.00f,
                    EVEBIT = 3.69f,
                    ROE = 26.44f,
                    ROIC = 23.08f,
                    LC = 0.72f,
                    DBPL = 0.19f,
                    LPA = 6.66f,
                    VPA = 25.19f,
                    DPA = 2.16f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -1.09f,
                    PVPA = 0.23f,
                    PFCO = 4.76f,
                    DY = 16.96f,
                    PSR = 0.00f,
                    EVEBIT = -1.83f,
                    ROE = -21.06f,
                    ROIC = -16.77f,
                    LC = 11.25f,
                    DBPL = 0.17f,
                    LPA = -4.83f,
                    VPA = 22.91f,
                    DPA = 1.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -1.45f,
                    PVPA = 0.33f,
                    PFCO = 13.48f,
                    DY = 5.01f,
                    PSR = 0.00f,
                    EVEBIT = -2.23f,
                    ROE = -22.47f,
                    ROIC = -17.62f,
                    LC = 11.03f,
                    DBPL = 0.19f,
                    LPA = -5.00f,
                    VPA = 22.24f,
                    DPA = 0.39f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -2.07f,
                    PVPA = 0.36f,
                    PFCO = 15.08f,
                    DY = 4.44f,
                    PSR = 0.00f,
                    EVEBIT = -3.19f,
                    ROE = -17.57f,
                    ROIC = -13.46f,
                    LC = 10.30f,
                    DBPL = 0.19f,
                    LPA = -4.02f,
                    VPA = 22.90f,
                    DPA = 0.39f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 6.99f,
                    PVPA = 0.56f,
                    PFCO = 71.99f,
                    DY = 0.80f,
                    PSR = 0.0f,
                    EVEBIT = 5.31f,
                    ROE = 7.96f,
                    ROIC = 8.05f,
                    LC = 7.88f,
                    DBPL = 0.20f,
                    LPA = 1.80f,
                    VPA = 22.63f,
                    DPA = 0.56f
                }));

            #endregion

            return localList;
        }
    }
}
