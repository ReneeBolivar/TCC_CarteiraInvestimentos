using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> ABEV3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "ABEV3",
                Nome = "AMBEV S.A.",
                Setor = Setor.Bebidas
            };

            #region Compreende todo o ano de 2018

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 37.84f,
                    PVPA = 5.85f,
                    PFCO = 17.47f,
                    DY = 2.24f,
                    PSR = 6.06f,
                    EVEBIT = 17.26f,
                    ROE = 15.37f,
                    ROIC = 20.88f,
                    LC = 0.94f,
                    DBPL = 0.09f,
                    LPA = 0.49f,
                    VPA = 3.17f,
                    DPA = 0.37f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 35.96f,
                    PVPA = 5.39f,
                    PFCO = 16.63f,
                    DY = 3.00f,
                    PSR = 5.84f,
                    EVEBIT = 16.34f,
                    ROE = 14.88f,
                    ROIC = 20.54f,
                    LC = 0.97f,
                    DBPL = 0.09f,
                    LPA = 0.51f,
                    VPA = 3.40f,
                    DPA = 0.37f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 21.88f,
                    PVPA = 3.95f,
                    PFCO = 13.17f,
                    DY = 2.94f,
                    PSR = 4.85f,
                    EVEBIT = 13.49f,
                    ROE = 17.97f,
                    ROIC = 22.58f,
                    LC = 1.03f,
                    DBPL = 0.08f,
                    LPA = 0.69f,
                    VPA = 3.82f,
                    DPA = 0.37f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 24.04f,
                    PVPA = 4.60f,
                    PFCO = 14.77f,
                    DY = 3.12f,
                    PSR = 5.28f,
                    EVEBIT = 15.04f,
                    ROE = 19.16f,
                    ROIC = 25.35f,
                    LC = 1.02f,
                    DBPL = 0.04f,
                    LPA = 0.70f,
                    VPA = 3.66f,
                    DPA = 0.48f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 24.00f,
                    PVPA = 5.88f,
                    PFCO = 17.33f,
                    DY = 3.17f,
                    PSR = 6.37f,
                    EVEBIT = 17.57f,
                    ROE = 24.61f,
                    ROIC = 29.51f,
                    LC = 0.89f,
                    DBPL = 0.11f,
                    LPA = 0.76f,
                    VPA = 3.10f,
                    DPA = 0.58f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 24.09f,
                    PVPA = 5.79f,
                    PFCO = 17.04f,
                    DY = 3.34f,
                    PSR = 6.40f,
                    EVEBIT = 17.81f,
                    ROE = 24.02f,
                    ROIC = 28.61f,
                    LC = 0.89f,
                    DBPL = 0.10f,
                    LPA = 0.76f,
                    VPA = 3.16f,
                    DPA = 0.61f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 37.33f,
                    PVPA = 6.84f,
                    PFCO = 19.78f,
                    DY = 2.90f,
                    PSR = 7.29f,
                    EVEBIT = 20.06f,
                    ROE = 18.15f,
                    ROIC = 23.99f,
                    LC = 0.95f,
                    DBPL = 0.07f,
                    LPA = 0.57f,
                    VPA = 3.11f,
                    DPA = 0.61f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 50.23f,
                    PVPA = 7.74f,
                    PFCO = 20.76f,
                    DY = 2.54f,
                    PSR = 7.77f,
                    EVEBIT = 22.12f,
                    ROE = 15.28f,
                    ROIC = 22.45f,
                    LC = 0.86f,
                    DBPL = 0.05f,
                    LPA = 0.47f,
                    VPA = 3.05f,
                    DPA = 0.37f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 23.82f,
                    PVPA = 6.03f,
                    PFCO = 16.31f,
                    DY = 2.77f,
                    PSR = 6.27f,
                    EVEBIT = 15.62f,
                    ROE = 25.25f,
                    ROIC = 29.76f,
                    LC = 0.87f,
                    DBPL = 0.08f,
                    LPA = 0.79f,
                    VPA = 3.12f,
                    DPA = 0.40f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 25.07f,
                    PVPA = 6.50f,
                    PFCO = 18.32f,
                    DY = 2.94f,
                    PSR = 6.28f,
                    EVEBIT = 15.67f,
                    ROE = 25.87f,
                    ROIC = 31.97f,
                    LC = 0.85f,
                    DBPL = 0.08f,
                    LPA = 0.76f,
                    VPA = 2.93f,
                    DPA = 0.43f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 25.74f,
                    PVPA = 6.33f,
                    PFCO = 20.23f,
                    DY = 2.08f,
                    PSR = 6.56f,
                    EVEBIT = 17.24f,
                    ROE = 24.47f,
                    ROIC = 30.74f,
                    LC = 0.91f,
                    DBPL = 0.09f,
                    LPA = 0.77f,
                    VPA = 3.13f,
                    DPA = 0.28f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 20.50f,
                    PVPA = 5.52f,
                    PFCO = 20.88f,
                    DY = 4.33f,
                    PSR = 5.69f,
                    EVEBIT = 14.91f,
                    ROE = 26.89f,
                    ROIC = 32.25f,
                    LC = 0.83f,
                    DBPL = 0.12f,
                    LPA = 0.80f,
                    VPA = 2.97f,
                    DPA = 0.58f
                }));

            #endregion

            return localList;
        }
    }
}
