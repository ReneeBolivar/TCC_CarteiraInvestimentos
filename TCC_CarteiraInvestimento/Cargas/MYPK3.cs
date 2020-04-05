using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> MYPK3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "MYPK3",
                Nome = "IOCHPE-MAXION SA.",
                Setor = Setor.MaterialTransporte
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = -342.17f,
                    PVPA = 0.70f,
                    PFCO = 5.78f,
                    DY = 0.98f,
                    PSR = 0.48f,
                    EVEBIT = 7.92f,
                    ROE = -0.19f,
                    ROIC = 7.18f,
                    LC = 1.17f,
                    DBPL = 1.10f,
                    LPA = -0.06f,
                    VPA = 29.27f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 127.33f,
                    PVPA = 0.60f,
                    PFCO = 4.82f,
                    DY = 2.36f,
                    PSR = 0.43f,
                    EVEBIT = 7.28f,
                    ROE = 0.47f,
                    ROIC = 7.82f,
                    LC = 1.11f,
                    DBPL = 0.94f,
                    LPA = 0.15f,
                    VPA = 32.03f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 15.96f,
                    PVPA = 0.68f,
                    PFCO = 6.15f,
                    DY = 3.80f,
                    PSR = 0.44f,
                    EVEBIT = 7.11f,
                    ROE = 4.28f,
                    ROIC = 7.93f,
                    LC = 1.11f,
                    DBPL = 0.91f,
                    LPA = 1.44f,
                    VPA = 33.63f,
                    DPA = 0.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 10.12f,
                    PVPA = 0.64f,
                    PFCO = 3.31f,
                    DY = 4.13f,
                    PSR = 0.39f,
                    EVEBIT = 6.22f,
                    ROE = 6.29f,
                    ROIC = 8.76f,
                    LC = 1.08f,
                    DBPL = 0.88f,
                    LPA = 2.12f,
                    VPA = 33.72f,
                    DPA = 0.83f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 119.07f,
                    PVPA = 0.64f,
                    PFCO = 4.27f,
                    DY = 0.46f,
                    PSR = 0.54f,
                    EVEBIT = 8.39f,
                    ROE = 0.53f,
                    ROIC = 7.44f,
                    LC = 1.25f,
                    DBPL = 1.13f,
                    LPA = 0.14f,
                    VPA = 26.25f,
                    DPA = 0.11f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 46.00f,
                    PVPA = 0.79f,
                    PFCO = 9.91f,
                    DY = 0.45f,
                    PSR = 0.55f,
                    EVEBIT = 9.30f,
                    ROE = 1.74f,
                    ROIC = 7.01f,
                    LC = 1.08f,
                    DBPL = 1.14f,
                    LPA = 0.47f,
                    VPA = 27.32f,
                    DPA = 0.11f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 191.67f,
                    PVPA = 0.87f,
                    PFCO = 6.21f,
                    DY = 0.35f,
                    PSR = 0.53f,
                    EVEBIT = 9.08f,
                    ROE = 0.45f,
                    ROIC = 7.99f,
                    LC = 1.07f,
                    DBPL = 1.11f,
                    LPA = 0.12f,
                    VPA = 26.52f,
                    DPA = 0.11f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 370.54f,
                    PVPA = 0.94f,
                    PFCO = 8.11f,
                    DY = 0.33f,
                    PSR = 0.53f,
                    EVEBIT = 9.59f,
                    ROE = 0.24f,
                    ROIC = 7.81f,
                    LC = 1.00f,
                    DBPL = 1.08f,
                    LPA = 0.07f,
                    VPA = 27.73f,
                    DPA = 0.05f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 19.17f,
                    PVPA = 0.55f,
                    PFCO = 9.87f,
                    DY = 1.70f,
                    PSR = 0.40f,
                    EVEBIT = 7.54f,
                    ROE = 2.87f,
                    ROIC = 8.93f,
                    LC = 0.84f,
                    DBPL = 1.53f,
                    LPA = 0.66f,
                    VPA = 23.15f,
                    DPA = 0.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -91.33f,
                    PVPA = 0.65f,
                    PFCO = 7.72f,
                    DY = 1.62f,
                    PSR = 0.45f,
                    EVEBIT = 8.44f,
                    ROE = -0.72f,
                    ROIC = 8.21f,
                    LC = 0.96f,
                    DBPL = 1.54f,
                    LPA = -0.15f,
                    VPA = 21.10f,
                    DPA = 0.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -134.69f,
                    PVPA = 0.81f,
                    PFCO = 23.45f,
                    DY = 1.27f,
                    PSR = 0.52f,
                    EVEBIT = 9.87f,
                    ROE = -0.58f,
                    ROIC = 7.98f,
                    LC = 0.98f,
                    DBPL = 1.51f,
                    LPA = -0.13f,
                    VPA = 21.65f,
                    DPA = 0.22f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 50.70f,
                    PVPA = 0.55f,
                    PFCO = 4.36f,
                    DY = 1.89f,
                    PSR = 0.44f,
                    EVEBIT = 7.79f,
                    ROE = 1.07f,
                    ROIC = 8.54f,
                    LC = 0.94f,
                    DBPL = 1.52f,
                    LPA = 0.23f,
                    VPA = 21.26f,
                    DPA = 0.11f
                }));

            #endregion

            return localList;
        }
    }
}
