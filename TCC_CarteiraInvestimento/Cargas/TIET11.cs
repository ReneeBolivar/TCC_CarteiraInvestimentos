using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> TIET11()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "TIET11",
                Nome = "AES TIETÊ ENERGIA S.A.",
                Setor = Setor.EnergiaEletrica
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 18.00f,
                    PVPA = 3.95f,
                    PFCO = 7.14f,
                    DY = 6.79f,
                    PSR = 4.72f,
                    EVEBIT = 10.40f,
                    ROE = 21.90f,
                    ROIC = 11.78f,
                    LC = 1.75f,
                    DBPL = 2.44f,
                    LPA = 0.54f,
                    VPA = 2.46f,
                    DPA = 0.43f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 17.59f,
                    PVPA = 3.93f,
                    PFCO = 6.29f,
                    DY = 7.19f,
                    PSR = 4.61f,
                    EVEBIT = 9.68f,
                    ROE = 22.37f,
                    ROIC = 12.16f,
                    LC = 1.66f,
                    DBPL = 2.59f,
                    LPA = 0.54f,
                    VPA = 2.42f,
                    DPA = 0.33f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 18.31f,
                    PVPA = 4.26f,
                    PFCO = 7.81f,
                    DY = 7.34f,
                    PSR = 4.51f,
                    EVEBIT = 10.52f,
                    ROE = 23.19f,
                    ROIC = 12.85f,
                    LC = 1.10f,
                    DBPL = 2.73f,
                    LPA = 0.54f,
                    VPA = 2.32f,
                    DPA = 0.33f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 25.18f,
                    PVPA = 4.78f,
                    PFCO = 10.51f,
                    DY = 7.78f,
                    PSR = 5.86f,
                    EVEBIT = 14.17f,
                    ROE = 18.90f,
                    ROIC = 10.67f,
                    LC = 1.11f,
                    DBPL = 2.71f,
                    LPA = 0.44f,
                    VPA = 2.32f,
                    DPA = 0.43f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 31.86f,
                    PVPA = 5.27f,
                    PFCO = 11.33f,
                    DY = 15.66f,
                    PSR = 8.56f,
                    EVEBIT = 54.51f,
                    ROE = 16.65f,
                    ROIC = 12.46f,
                    LC = 1.02f,
                    DBPL = 0.86f,
                    LPA = 0.43f,
                    VPA = 2.60f,
                    DPA = 0.51f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 33.29f,
                    PVPA = 5.50f,
                    PFCO = 11.95f,
                    DY = 8.42f,
                    PSR = 8.96f,
                    EVEBIT = 58.15f,
                    ROE = 16.70f,
                    ROIC = 9.10f,
                    LC = 1.25f,
                    DBPL = 1.48f,
                    LPA = 0.41f,
                    VPA = 2.48f,
                    DPA = 0.58f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 39.84f,
                    PVPA = 5.36f,
                    PFCO = 11.40f,
                    DY = 7.62f,
                    PSR = 8.94f,
                    EVEBIT = 68.63f,
                    ROE = 13.56f,
                    ROIC = 6.36f,
                    LC = 0.77f,
                    DBPL = 2.31f,
                    LPA = 0.32f,
                    VPA = 2.38f,
                    DPA = 0.56f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 28.13f,
                    PVPA = 5.32f,
                    PFCO = 10.11f,
                    DY = 6.47f,
                    PSR = 6.29f,
                    EVEBIT = 16.95f,
                    ROE = 19.15f,
                    ROIC = 9.75f,
                    LC = 0.79f,
                    DBPL = 2.30f,
                    LPA = 0.45f,
                    VPA = 2.38f,
                    DPA = 0.43f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 28.11f,
                    PVPA = 4.85f,
                    PFCO = 15.95f,
                    DY = 0.00f,
                    PSR = -18.56f,
                    EVEBIT = 34.96f,
                    ROE = 17.12f,
                    ROIC = 18.95f,
                    LC = 1.57f,
                    DBPL = 0.68f,
                    LPA = 0.55f,
                    VPA = 3.19f,
                    DPA = 0.58f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 25.95f,
                    PVPA = 5.78f,
                    PFCO = 12.36f,
                    DY = 10.12f,
                    PSR = -2.79f,
                    EVEBIT = 37.88f,
                    ROE = 22.34f,
                    ROIC = 20.06f,
                    LC = 0.79f,
                    DBPL = 0.84f,
                    LPA = 0.57f,
                    VPA = 2.56f,
                    DPA = 0.72f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 24.63f,
                    PVPA = 6.33f,
                    PFCO = 12.38f,
                    DY = 10.79f,
                    PSR = -1.65f,
                    EVEBIT = 43.48f,
                    ROE = 25.88f,
                    ROIC = 19.40f,
                    LC = 0.84f,
                    DBPL = 0.87f,
                    LPA = 0.65f,
                    VPA = 2.53f,
                    DPA = 0.90f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 25.45f,
                    PVPA = 5.81f,
                    PFCO = 14.56f,
                    DY = 15.45f,
                    PSR = 6.64f,
                    EVEBIT = 44.09f,
                    ROE = 22.72f,
                    ROIC = 16.34f,
                    LC = 0.94f,
                    DBPL = 0.92f,
                    LPA = 0.55f,
                    VPA = 2.41f,
                    DPA = 0.51f
                }));

            #endregion

            return localList;
        }
    }
}
