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
        public static List<Cromossomo> CIEL3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "CIEL3",
                Nome = "CIELO S.A.",
                Setor = Setor.ServicosFinanceirosDiversos
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 8.41f,
                    PVPA = 2.25f,
                    PFCO = 7.44f,
                    DY = 4.82f,
                    PSR = 3.49f,
                    EVEBIT = 8.72f,
                    ROE = 26.79f,
                    ROIC = 10.47f,
                    LC = 1.16f,
                    DBPL = 0.60f,
                    LPA = 1.79f,
                    VPA = 6.70f,
                    DPA = 0.07f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 11.55f,
                    PVPA = 2.88f,
                    PFCO = 13.19f,
                    DY = 6.00f,
                    PSR = 4.43f,
                    EVEBIT = 11.75f,
                    ROE = 24.89f,
                    ROIC = 10.43f,
                    LC = 1.19f,
                    DBPL = 0.52f,
                    LPA = 1.43f,
                    VPA = 5.74f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 9.07f,
                    PVPA = 2.22f,
                    PFCO = 6.69f,
                    DY = 9.86f,
                    PSR = 3.43f,
                    EVEBIT = 9.28f,
                    ROE = 24.37f,
                    ROIC = 10.61f,
                    LC = 1.17f,
                    DBPL = 0.53f,
                    LPA = 1.35f,
                    VPA = 5.53f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.72f,
                    PVPA = 1.73f,
                    PFCO = 7.21f,
                    DY = 15.95f,
                    PSR = 2.79f,
                    EVEBIT = 8.31f,
                    ROE = 22.47f,
                    ROIC = 10.17f,
                    LC = 1.16f,
                    DBPL = 0.53f,
                    LPA = 1.23f,
                    VPA = 5.47f,
                    DPA = 0.15f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 15.99f,
                    PVPA = 4.66f,
                    PFCO = 10.07f,
                    DY = 2.34f,
                    PSR = 5.97f,
                    EVEBIT = 15.68f,
                    ROE = 29.18f,
                    ROIC = 10.95f,
                    LC = 1.94f,
                    DBPL = 0.78f,
                    LPA = 1.77f,
                    VPA = 6.07f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 13.90f,
                    PVPA = 3.89f,
                    PFCO = 8.79f,
                    DY = 2.69f,
                    PSR = 5.26f,
                    EVEBIT = 13.83f,
                    ROE = 28.03f,
                    ROIC = 11.53f,
                    LC = 1.11f,
                    DBPL = 0.58f,
                    LPA = 1.77f,
                    VPA = 6.33f,
                    DPA = 0.59f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 13.21f,
                    PVPA = 3.68f,
                    PFCO = 10.59f,
                    DY = 3.48f,
                    PSR = 5.10f,
                    EVEBIT = 13.16f,
                    ROE = 27.83f,
                    ROIC = 10.67f,
                    LC = 1.16f,
                    DBPL = 0.63f,
                    LPA = 1.78f,
                    VPA = 6.39f,
                    DPA = 0.66f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 12.39f,
                    PVPA = 3.27f,
                    PFCO = 9.09f,
                    DY = 3.29f,
                    PSR = 4.88f,
                    EVEBIT = 12.33f,
                    ROE = 26.41f,
                    ROIC = 10.20f,
                    LC = 1.15f,
                    DBPL = 0.60f,
                    LPA = 1.79f,
                    VPA = 6.78f,
                    DPA = 0.66f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 21.99f,
                    PVPA = 7.15f,
                    PFCO = 53.90f,
                    DY = 1.58f,
                    PSR = 7.52f,
                    EVEBIT = 20.72f,
                    ROE = 32.48f,
                    ROIC = 11.04f,
                    LC = 1.84f,
                    DBPL = 1.17f,
                    LPA = 1.59f,
                    VPA = 4.89f,
                    DPA = 0.47f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 20.65f,
                    PVPA = 6.64f,
                    PFCO = 25.27f,
                    DY = 1.67f,
                    PSR = 6.99f,
                    EVEBIT = 19.43f,
                    ROE = 32.17f,
                    ROIC = 11.79f,
                    LC = 1.66f,
                    DBPL = 0.94f,
                    LPA = 1.64f,
                    VPA = 5.10f,
                    DPA = 0.47f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 19.12f,
                    PVPA = 5.95f,
                    PFCO = 16.06f,
                    DY = 1.72f,
                    PSR = 6.65f,
                    EVEBIT = 18.36f,
                    ROE = 31.14f,
                    ROIC = 11.45f,
                    LC = 1.77f,
                    DBPL = 0.88f,
                    LPA = 1.70f,
                    VPA = 5.46f,
                    DPA = 0.47f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 15.76f,
                    PVPA = 4.89f,
                    PFCO = 12.31f,
                    DY = 2.88f,
                    PSR = 5.77f,
                    EVEBIT = 15.60f,
                    ROE = 31.04f,
                    ROIC = 11.53f,
                    LC = 1.75f,
                    DBPL = 0.84f,
                    LPA = 1.77f,
                    VPA = 5.70f,
                    DPA = 0.47f
                }));

            #endregion

            return localList;
        }
    }
}
