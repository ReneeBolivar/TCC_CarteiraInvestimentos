using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> SAPR4()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "SAPR4",
                Nome = "CIA. DE SABEANEBTI DO PARANÁ - SANEPAR",
                Setor = Setor.AguaSaneamento
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 6.02f,
                    PVPA = 0.81f,
                    PFCO = 3.26f,
                    DY = 6.11f,
                    PSR = 1.64f,
                    EVEBIT = 5.35f,
                    ROE = 13.35f,
                    ROIC = 11.89f,
                    LC = 1.02f,
                    DBPL = 0.51f,
                    LPA = 1.50f,
                    VPA = 11.20f,
                    DPA = 0.68f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 5.17f,
                    PVPA = 0.75f,
                    PFCO = 3.00f,
                    DY = 7.42f,
                    PSR = 1.57f,
                    EVEBIT = 5.00f,
                    ROE = 14.60f,
                    ROIC = 12.52f,
                    LC = 0.97f,
                    DBPL = 0.53f,
                    LPA = 1.61f,
                    VPA = 11.06f,
                    DPA = 0.68f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.84f,
                    PVPA = 0.92f,
                    PFCO = 3.75f,
                    DY = 8.01f,
                    PSR = 1.77f,
                    EVEBIT = 5.78f,
                    ROE = 13.45f,
                    ROIC = 12.31f,
                    LC = 0.82f,
                    DBPL = 0.51f,
                    LPA = 1.52f,
                    VPA = 11.34f,
                    DPA = 0.68f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.43f,
                    PVPA = 1.16f,
                    PFCO = 4.86f,
                    DY = 6.36f,
                    PSR = 2.14f,
                    EVEBIT = 6.62f,
                    ROE = 15.61f,
                    ROIC = 12.94f,
                    LC = 0.78f,
                    DBPL = 0.48f,
                    LPA = 1.87f,
                    VPA = 12.00f,
                    DPA = 0.89f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 8.15f,
                    PVPA = 1.06f,
                    PFCO = 4.33f,
                    DY = 5.99f,
                    PSR = 2.10f,
                    EVEBIT = 7.37f,
                    ROE = 12.93f,
                    ROIC = 10.57f,
                    LC = 1.40f,
                    DBPL = 0.54f,
                    LPA = 1.35f,
                    VPA = 10.42f,
                    DPA = 0.62f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.14f,
                    PVPA = 1.05f,
                    PFCO = 4.12f,
                    DY = 6.03f,
                    PSR = 2.00f,
                    EVEBIT = 7.64f,
                    ROE = 12.98f,
                    ROIC = 10.62f,
                    LC = 1.02f,
                    DBPL = 0.54f,
                    LPA = 1.32f,
                    VPA = 10.19f,
                    DPA = 0.66f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.07f,
                    PVPA = 1.11f,
                    PFCO = 4.23f,
                    DY = 5.94f,
                    PSR = 2.03f,
                    EVEBIT = 7.50f,
                    ROE = 13.73f,
                    ROIC = 10.85f,
                    LC = 0.98f,
                    DBPL = 0.52f,
                    LPA = 1.45f,
                    VPA = 10.56f,
                    DPA = 0.66f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.48f,
                    PVPA = 1.00f,
                    PFCO = 3.79f,
                    DY = 5.66f,
                    PSR = 1.88f,
                    EVEBIT = 6.44f,
                    ROE = 13.32f,
                    ROIC = 11.54f,
                    LC = 0.99f,
                    DBPL = 0.53f,
                    LPA = 1.44f,
                    VPA = 10.81f,
                    DPA = 0.68f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 3.74f,
                    PVPA = 0.43f,
                    PFCO = 2.01f,
                    DY = 13.20f,
                    PSR = 1.28f,
                    EVEBIT = 5.19f,
                    ROE = 11.50f,
                    ROIC = 9.66f,
                    LC = 1.01f,
                    DBPL = 0.55f,
                    LPA = 1.04f,
                    VPA = 9.06f,
                    DPA = 0.44f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 4.27f,
                    PVPA = 0.59f,
                    PFCO = 2.57f,
                    DY = 10.64f,
                    PSR = 1.40f,
                    EVEBIT = 5.37f,
                    ROE = 13.84f,
                    ROIC = 11.22f,
                    LC = 0.76f,
                    DBPL = 0.56f,
                    LPA = 1.24f,
                    VPA = 8.98f,
                    DPA = 0.53f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.75f,
                    PVPA = 0.93f,
                    PFCO = 3.84f,
                    DY = 6.40f,
                    PSR = 1.89f,
                    EVEBIT = 6.83f,
                    ROE = 13.82f,
                    ROIC = 10.92f,
                    LC = 1.04f,
                    DBPL = 0.61f,
                    LPA = 1.27f,
                    VPA = 9.22f,
                    DPA = 0.53f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.14f,
                    PVPA = 1.07f,
                    PFCO = 4.67f,
                    DY = 5.86f,
                    PSR = 2.14f,
                    EVEBIT = 7.55f,
                    ROE = 13.04f,
                    ROIC = 10.52f,
                    LC = 1.35f,
                    DBPL = 0.56f,
                    LPA = 1.32f,
                    VPA = 10.09f,
                    DPA = 0.62f
                }));

            #endregion

            return localList;
        }
    }
}
