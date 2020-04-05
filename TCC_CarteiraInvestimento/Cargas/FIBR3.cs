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
        public static List<Cromossomo> FIBR3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "FIBR3",
                Nome = "FIRBIA CELULOSE S.A.",
                Setor = Setor.MadeiraPapel
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 29.19f,
                    PVPA = 2.63f,
                    PFCO = 10.91f,
                    DY = 1.09f,
                    PSR = 4.34f,
                    EVEBIT = 16.36f,
                    ROE = 8.98f,
                    ROIC = 8.08f,
                    LC = 2.34f,
                    DBPL = 1.24f,
                    LPA = 2.48f,
                    VPA = 27.58f,
                    DPA = 0.477f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 29.39f,
                    PVPA = 2.77f,
                    PFCO = 7.96f,
                    DY = 0.64f,
                    PSR = 4.00f,
                    EVEBIT = 11.60f,
                    ROE = 9.43f,
                    ROIC = 11.81f,
                    LC = 2.39f,
                    DBPL = 1.39f,
                    LPA = 2.57f,
                    VPA = 27.22f,
                    DPA = 0.47f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 20.56f,
                    PVPA = 2.29f,
                    PFCO = 5.77f,
                    DY = 0.62f,
                    PSR = 3.07f,
                    EVEBIT = 7.53f,
                    ROE = 11.14f,
                    ROIC = 15.79f,
                    LC = 2.39f,
                    DBPL = 1.32f,
                    LPA = 3.26f,
                    VPA = 29.27f,
                    DPA = 0.47f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 12.03f,
                    PVPA = 2.58f,
                    PFCO = 5.34f,
                    DY = 8.13f,
                    PSR = 2.97f,
                    EVEBIT = 7.63f,
                    ROE = 21.46f,
                    ROIC = 17.10f,
                    LC = 1.46f,
                    DBPL = 1.45f,
                    LPA = 5.51f,
                    VPA = 25.68f,
                    DPA = 1.31f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 15.86f,
                    PVPA = 1.13f,
                    PFCO = 4.35f,
                    DY = 1.98f,
                    PSR = 3.54f,
                    EVEBIT = 32.01f,
                    ROE = 4.89f,
                    ROIC = -0.03f,
                    LC = 2.05f,
                    DBPL = 1.30f,
                    LPA = 1.82f,
                    VPA = 25.53f,
                    DPA = 0.71f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 1.35f,
                    PFCO = 5.25f,
                    DY = 2.07f,
                    PSR = 3.71f,
                    EVEBIT = 37.44f,
                    ROE = 0.01f,
                    ROIC = 2.66f,
                    LC = 1.98f,
                    DBPL = 1.35f,
                    LPA = 0.00f,
                    VPA = 25.05f,
                    DPA = 0.71f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 37.09f,
                    PVPA = 1.81f,
                    PFCO = 7.21f,
                    DY = 1.66f,
                    PSR = 4.30f,
                    EVEBIT = 30.55f,
                    ROE = 4.89f,
                    ROIC = 2.74f,
                    LC = 1.96f,
                    DBPL = 1.30f,
                    LPA = 1.29f,
                    VPA = 26.38f,
                    DPA = 0.71f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 32.78f,
                    PVPA = 2.43f,
                    PFCO = 8.67f,
                    DY = 1.48f,
                    PSR = 4.53f,
                    EVEBIT = 20.80f,
                    ROE = 7.41f,
                    ROIC = 5.53f,
                    LC = 1.82f,
                    DBPL = 1.32f,
                    LPA = 1.96f,
                    VPA = 26.45f,
                    DPA = 0.47f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 8.90f,
                    PVPA = 1.22f,
                    PFCO = 3.44f,
                    DY = 12.40f,
                    PSR = 2.63f,
                    EVEBIT = 7.07f,
                    ROE = 13.70f,
                    ROIC = 11.55f,
                    LC = 2.28f,
                    DBPL = 0.83f,
                    LPA = 3.41f,
                    VPA = 24.87f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 5.91f,
                    PVPA = 0.83f,
                    PFCO = 2.45f,
                    DY = 18.82f,
                    PSR = 2.24f,
                    EVEBIT = 6.38f,
                    ROE = 14.12f,
                    ROIC = 8.43f,
                    LC = 2.52f,
                    DBPL = 0.89f,
                    LPA = 3.64f,
                    VPA = 25.81f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 4.80f,
                    PVPA = 0.89f,
                    PFCO = 2.98f,
                    DY = 18.20f,
                    PSR = 2.53f,
                    EVEBIT = 8.99f,
                    ROE = 18.51f,
                    ROIC = 2.65f,
                    LC = 1.82f,
                    DBPL = 0.99f,
                    LPA = 4.79f,
                    VPA = 25.87f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 10.67f,
                    PVPA = 1.28f,
                    PFCO = 4.50f,
                    DY = 1.70f,
                    PSR = 3.40f,
                    EVEBIT = 20.40f,
                    ROE = 11.98f,
                    ROIC = 0.16f,
                    LC = 1.87f,
                    DBPL = 1.17f,
                    LPA = 2.99f,
                    VPA = 24.94f,
                    DPA = 0.71f
                }));

            #endregion

            return localList;
        }
    }
}
