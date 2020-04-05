using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> BRML3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "BRML3",
                Nome = "BR MALLS PARTICIPAÇÕES SA.",
                Setor = Setor.ExploracaoImoveis
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = -7.45f,
                    PVPA = 0.52f,
                    PFCO = 7.24f,
                    DY = 0.57f,
                    PSR = 6.49f,
                    EVEBIT = -7.64f,
                    ROE = -7.02f,
                    ROIC = -3.87f,
                    LC = 3.08f,
                    DBPL = 0.28f,
                    LPA = -1.22f,
                    VPA = 17.40f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = -12.83f,
                    PVPA = 0.56f,
                    PFCO = 8.37f,
                    DY = 0.00f,
                    PSR = 6.81f,
                    EVEBIT = -14.50f,
                    ROE = -4.41f,
                    ROIC = -1.88f,
                    LC = 2.47f,
                    DBPL = 0.28f,
                    LPA = -0.75f,
                    VPA = 17.07f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = -21.47f,
                    PVPA = 0.75f,
                    PFCO = 11.87f,
                    DY = 0.00f,
                    PSR = 8.41f,
                    EVEBIT = -25.12f,
                    ROE = -3.53f,
                    ROIC = -1.30f,
                    LC = 1.54f,
                    DBPL = 0.28f,
                    LPA = -0.60f,
                    VPA = 17.06f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.53f,
                    PVPA = 0.70f,
                    PFCO = 10.59f,
                    DY = 0.73f,
                    PSR = 8.36f,
                    EVEBIT = 5.78f,
                    ROE = 9.28f,
                    ROIC = 9.57f,
                    LC = 1.38f,
                    DBPL = 0.25f,
                    LPA = 1.67f,
                    VPA = 17.99f,
                    DPA = 0.13f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 80.50f,
                    PVPA = 0.86f,
                    PFCO = 11.09f,
                    DY = 0.00f,
                    PSR = 9.85f,
                    EVEBIT = 58.61f,
                    ROE = 1.09f,
                    ROIC = 3.31f,
                    LC = 1.00f,
                    DBPL = 0.45f,
                    LPA = 0.18f,
                    VPA = 16.88f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -30.24f,
                    PVPA = 0.66f,
                    PFCO = 9.35f,
                    DY = 0.57f,
                    PSR = 8.00f,
                    EVEBIT = -28.11f,
                    ROE = -2.20f,
                    ROIC = 0.84f,
                    LC = 1.20f,
                    DBPL = 0.39f,
                    LPA = -0.42f,
                    VPA = 19.27f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -26.54f,
                    PVPA = 0.69f,
                    PFCO = 9.27f,
                    DY = 0.47f,
                    PSR = 8.00f,
                    EVEBIT = -20.17f,
                    ROE = -2.60f,
                    ROIC = 0.35f,
                    LC = 1.43f,
                    DBPL = 0.29f,
                    LPA = -0.48f,
                    VPA = 18.45f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = -8.57f,
                    PVPA = 0.65f,
                    PFCO = 8.61f,
                    DY = 0.52f,
                    PSR = 7.54f,
                    EVEBIT = -9.21f,
                    ROE = -7.60f,
                    ROIC = -4.12f,
                    LC = 2.74f,
                    DBPL = 0.32f,
                    LPA = -1.31f,
                    VPA = 17.26f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 33.52f,
                    PVPA = 0.89f,
                    PFCO = 9.60f,
                    DY = 3.01f,
                    PSR = 9.96f,
                    EVEBIT = 11.35f,
                    ROE = 2.67f,
                    ROIC = 6.85f,
                    LC = 1.15f,
                    DBPL = 0.54f,
                    LPA = 0.44f,
                    VPA = 16.57f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 85.67f,
                    PVPA = 0.76f,
                    PFCO = 8.68f,
                    DY = 0.00f,
                    PSR = 9.24f,
                    EVEBIT = 11.35f,
                    ROE = 0.89f,
                    ROIC = 5.18f,
                    LC = 1.42f,
                    DBPL = 0.49f,
                    LPA = 0.15f,
                    VPA = 16.87f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 21.58f,
                    PVPA = 0.73f,
                    PFCO = 9.22f,
                    DY = 0.00f,
                    PSR = 9.19f,
                    EVEBIT = 11.46f,
                    ROE = 3.36f,
                    ROIC = 4.95f,
                    LC = 1.55f,
                    DBPL = 0.48f,
                    LPA = 0.57f,
                    VPA = 16.94f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 42.68f,
                    PVPA = 0.72f,
                    PFCO = 9.22f,
                    DY = 0.00f,
                    PSR = 8.90f,
                    EVEBIT = 49.03f,
                    ROE = 1.69f,
                    ROIC = 3.49f,
                    LC = 1.17f,
                    DBPL = 0.47f,
                    LPA = 0.28f,
                    VPA = 16.65f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }
    }
}
