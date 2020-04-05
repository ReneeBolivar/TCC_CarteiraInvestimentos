using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> CMIG3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa 
            {
                Codigo = "CMIG3",
                Nome = "CIA ENERG MINAS GERAIS",
                Setor = Setor.EnergiaEletrica
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 6.88f,
                    PVPA = 0.52f,
                    PFCO = -23.96f,
                    DY = 0.00f,
                    PSR = 0.86f,
                    EVEBIT = 8.10f,
                    ROE = 7.62f,
                    ROIC = 6.63f,
                    LC = 0.92f,
                    DBPL = 0.93f,
                    LPA = 0.89f,
                    VPA = 11.71f,
                    DPA = 0.40f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.97f,
                    PVPA = 0.56f,
                    PFCO = -6.10f,
                    DY = 0.46f,
                    PSR = 0.91f,
                    EVEBIT = 8.32f,
                    ROE = 6.30f,
                    ROIC = 6.90f,
                    LC = 0.92f,
                    DBPL = 0.99f,
                    LPA = 0.73f,
                    VPA = 11.66f,
                    DPA = 0.40f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 14.05f,
                    PVPA = 1.22f,
                    PFCO = -23.15f,
                    DY = 0.47f,
                    PSR = 1.34f,
                    EVEBIT = 9.13f,
                    ROE = 8.70f,
                    ROIC = 8.99f,
                    LC = 1.21f,
                    DBPL = 1.03f,
                    LPA = 1.03f,
                    VPA = 11.89f,
                    DPA = 0.40f
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
                    PL = 22.45f,
                    PVPA = 1.13f,
                    PFCO = 13.12f,
                    DY = 5.47f,
                    PSR = 1.29f,
                    EVEBIT = 12.40f,
                    ROE = 5.05f,
                    ROIC = 7.46f,
                    LC = 0.69f,
                    DBPL = 1.11f,
                    LPA = 0.53f,
                    VPA = 10.56f,
                    DPA = 0.16f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 14.29f,
                    PVPA = 0.65f,
                    PFCO = 5.57f,
                    DY = 3.67f,
                    PSR = 0.92f,
                    EVEBIT = 9.16f,
                    ROE = 4.55f,
                    ROIC = 7.70f,
                    LC = 0.67f,
                    DBPL = 1.09f,
                    LPA = 0.48f,
                    VPA = 10.62f,
                    DPA = 0.16f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 91.57f,
                    PVPA = 0.61f,
                    PFCO = 2.58f,
                    DY = 3.77f,
                    PSR = 0.85f,
                    EVEBIT = 17.15f,
                    ROE = 0.68f,
                    ROIC = 4.40f,
                    LC = 0.64f,
                    DBPL = 1.06f,
                    LPA = 0.07f,
                    VPA = 10.56f,
                    DPA = 0.16f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
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

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.87f,
                    PVPA = 0.76f,
                    PFCO = 3.00f,
                    DY = 7.46f,
                    PSR = 1.02f,
                    EVEBIT = 10.47f,
                    ROE = 7.63f,
                    ROIC = 6.59f,
                    LC = 0.62f,
                    DBPL = 1.18f,
                    LPA = 0.79f,
                    VPA = 10.30f,
                    DPA = 1.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 13.65f,
                    PVPA = 0.65f,
                    PFCO = 2.47f,
                    DY = 7.26f,
                    PSR = 1.03f,
                    EVEBIT = 13.42f,
                    ROE = 4.76f,
                    ROIC = 5.10f,
                    LC = 0.72f,
                    DBPL = 1.12f,
                    LPA = 0.52f,
                    VPA = 10.96f,
                    DPA = 1.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 11.73f,
                    PVPA = 0.76f,
                    PFCO = 12.72f,
                    DY = 5.66f,
                    PSR = 1.09f,
                    EVEBIT = 11.21f,
                    ROE = 6.48f,
                    ROIC = 6.23f,
                    LC = 0.73f,
                    DBPL = 1.14f,
                    LPA = 0.73f,
                    VPA = 11.32f,
                    DPA = 1.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 29.19f,
                    PVPA = 0.77f,
                    PFCO = 8.18f,
                    DY = 8.21f,
                    PSR = 1.08f,
                    EVEBIT = 12.79f,
                    ROE = 2.58f,
                    ROIC = 6.30f,
                    LC = 0.72f,
                    DBPL = 1.17f,
                    LPA = 0.27f,
                    VPA = 10.27f,
                    DPA = 0.16f
                }));

            #endregion

            return localList;
        }
    }
}
