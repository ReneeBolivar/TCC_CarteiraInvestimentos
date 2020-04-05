using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> LCAM3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa 
            { 
                Codigo = "LCAM3",
                Nome = "COMPANHIA DE LOCAÇÃO DAS AMERICAS",
                Setor = Setor.Diversos
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 18.20f,
                    PVPA = 0.93f,
                    PFCO = 9.24f,
                    DY = 1.62f,
                    PSR = 3.01f,
                    EVEBIT = 14.01f,
                    ROE = 5.14f,
                    ROIC = 5.11f,
                    LC = 1.16f,
                    DBPL = 2.48f,
                    LPA = 1.21f,
                    VPA = 23.56f,
                    DPA = 0.46f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 2.72f,
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

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 20.42f,
                    PVPA = 1.46f,
                    PFCO = 14.37f,
                    DY = 2.93f,
                    PSR = 3.38f,
                    EVEBIT = 15.12f,
                    ROE = 7.15f,
                    ROIC = 5.46f,
                    LC = 1.00f,
                    DBPL = 2.48f,
                    LPA = 1.76f,
                    VPA = 24.60f,
                    DPA = 0.98f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.40f,
                    PVPA = 0.99f,
                    PFCO = 11.33f,
                    DY = 2.43f,
                    PSR = 2.10f,
                    EVEBIT = 8.17f,
                    ROE = 7.37f,
                    ROIC = 7.64f,
                    LC = 1.15f,
                    DBPL = 1.52f,
                    LPA = 2.91f,
                    VPA = 39.42f,
                    DPA = 1.61f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 14.45f,
                    PVPA = 1.71f,
                    PFCO = 1.83f,
                    DY = 8.82f,
                    PSR = 1.50f,
                    EVEBIT = 7.16f,
                    ROE = 11.81f,
                    ROIC = 13.33f,
                    LC = 1.10f,
                    DBPL = 2.61f,
                    LPA = 0.55f,
                    VPA = 4.66f,
                    DPA = 0.27f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 61.13f,
                    PVPA = 1.31f,
                    PFCO = 3.95f,
                    DY = 7.15f,
                    PSR = 6.30f,
                    EVEBIT = 31.67f,
                    ROE = 2.17f,
                    ROIC = 2.67f,
                    LC = 1.05f,
                    DBPL = 2.77f,
                    LPA = 0.15f,
                    VPA = 6.98f,
                    DPA = 0.17f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 49.23f,
                    PVPA = 2.71f,
                    PFCO = 7.38f,
                    DY = 4.72f,
                    PSR = 4.05f,
                    EVEBIT = 19.07f,
                    ROE = 5.44f,
                    ROIC = 6.34f,
                    LC = 0.95f,
                    DBPL = 2.67f,
                    LPA = 0.39f,
                    VPA = 7.09f,
                    DPA = 0.25f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 34.87f,
                    PVPA = 4.36f,
                    PFCO = 14.28f,
                    DY = 1.51f,
                    PSR = 3.04f,
                    EVEBIT = 13.94f,
                    ROE = 12.54f,
                    ROIC = 10.62f,
                    LC = 1.09f,
                    DBPL = 2.97f,
                    LPA = 0.93f,
                    VPA = 7.43f,
                    DPA = 0.34f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 14.96f,
                    PVPA = 0.83f,
                    PFCO = 1.75f,
                    DY = 4.86f,
                    PSR = 1.41f,
                    EVEBIT = 7.43f,
                    ROE = 5.56f,
                    ROIC = 9.58f,
                    LC = 1.20f,
                    DBPL = 3.15f,
                    LPA = 0.27f,
                    VPA = 4.89f,
                    DPA = 0.18f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 16.67f,
                    PVPA = 1.02f,
                    PFCO = 0.98f,
                    DY = 4.20f,
                    PSR = 1.27f,
                    EVEBIT = 6.82f,
                    ROE = 6.22f,
                    ROIC = 11.69f,
                    LC = 0.98f,
                    DBPL = 2.59f,
                    LPA = 0.30f,
                    VPA = 4.89f,
                    DPA = 0.20f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 14.72f,
                    PVPA = 1.08f,
                    PFCO = 1.07f,
                    DY = 4.53f,
                    PSR = 1.46f,
                    EVEBIT = 6.68f,
                    ROE = 7.36f,
                    ROIC = 12.05f,
                    LC = 1.74f,
                    DBPL = 2.65f,
                    LPA = 0.36f,
                    VPA = 4.90f,
                    DPA = 0.24f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.57f,
                    PVPA = 1.29f,
                    PFCO = 1.55f,
                    DY = 10.79f,
                    PSR = 1.45f,
                    EVEBIT = 6.72f,
                    ROE = 9.61f,
                    ROIC = 12.75f,
                    LC = 1.28f,
                    DBPL = 2.74f,
                    LPA = 0.44f,
                    VPA = 4.62f,
                    DPA = 0.25f
                }));

            #endregion

            return localList;
        }
    }
}
