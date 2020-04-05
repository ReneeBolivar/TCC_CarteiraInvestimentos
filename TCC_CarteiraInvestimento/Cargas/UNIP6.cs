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
        public static List<Cromossomo> UNIP6()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "UNIP6",
                Nome = "UNIP CARBOCLORO SA.",
                Setor = Setor.Quimicos
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.65f,
                    PVPA = 1.98f,
                    PFCO = 4.34f,
                    DY = 17.47f,
                    PSR = 1.02f,
                    EVEBIT = 4.29f,
                    ROE = 35.01f,
                    ROIC = 20.69f,
                    LC = 1.44f,
                    DBPL = 1.17f,
                    LPA = 5.11f,
                    VPA = 14.59f,
                    DPA = 0.86f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 6.92f,
                    PVPA = 2.66f,
                    PFCO = 4.80f,
                    DY = 14.96f,
                    PSR = 1.20f,
                    EVEBIT = 4.61f,
                    ROE = 38.46f,
                    ROIC = 26.46f,
                    LC = 1.49f,
                    DBPL = 1.04f,
                    LPA = 5.65f,
                    VPA = 14.70f,
                    DPA = 0.86f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 7.04f,
                    PVPA = 2.48f,
                    PFCO = 4.07f,
                    DY = 2.86f,
                    PSR = 1.22f,
                    EVEBIT = 4.39f,
                    ROE = 35.24f,
                    ROIC = 27.81f,
                    LC = 1.64f,
                    DBPL = 0.81f,
                    LPA = 5.79f,
                    VPA = 16.44f,
                    DPA = 0.86f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 5.83f,
                    PVPA = 2.13f,
                    PFCO = 3.45f,
                    DY = 7.35f,
                    PSR = 1.05f,
                    EVEBIT = 3.91f,
                    ROE = 36.52f,
                    ROIC = 28.35f,
                    LC = 1.42f,
                    DBPL = 0.71f,
                    LPA = 6.32f,
                    VPA = 17.31f,
                    DPA = 1.68f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 1.99f,
                    PVPA = 0.49f,
                    PFCO = 1.66f,
                    DY = 4.21f,
                    PSR = 0.57f,
                    EVEBIT = 1.26f,
                    ROE = 24.51f,
                    ROIC = 23.65f,
                    LC = 1.14f,
                    DBPL = 0.40f,
                    LPA = 3.77f,
                    VPA = 15.40f,
                    DPA = 0.32f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 2.45f,
                    PVPA = 0.63f,
                    PFCO = 2.00f,
                    DY = 3.60f,
                    PSR = 0.49f,
                    EVEBIT = 1.32f,
                    ROE = 25.79f,
                    ROIC = 25.26f,
                    LC = 1.24f,
                    DBPL = 0.45f,
                    LPA = 4.08f,
                    VPA = 15.81f,
                    DPA = 0.32f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 2.10f,
                    PVPA = 0.92f,
                    PFCO = 1.89f,
                    DY = 42.37f,
                    PSR = 0.43f,
                    EVEBIT = 1.59f,
                    ROE = 43.90f,
                    ROIC = 32.68f,
                    LC = 0.93f,
                    DBPL = 0.76f,
                    LPA = 5.67f,
                    VPA = 12.91f,
                    DPA = 0.32f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 4.38f,
                    PVPA = 1.23f,
                    PFCO = 3.14f,
                    DY = 31.81f,
                    PSR = 0.57f,
                    EVEBIT = 4.09f,
                    ROE = 28.21f,
                    ROIC = 20.91f,
                    LC = 0.96f,
                    DBPL = 0.78f,
                    LPA = 3.62f,
                    VPA = 12.84f,
                    DPA = 0.86f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 4.74f,
                    PVPA = 0.59f,
                    PFCO = 1.99f,
                    DY = 4.18f,
                    PSR = 0.99f,
                    EVEBIT = 4.64f,
                    ROE = 12.36f,
                    ROIC = 11.23f,
                    LC = 1.07f,
                    DBPL = 0.69f,
                    LPA = 1.29f,
                    VPA = 10.40f,
                    DPA = 0.25f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 5.34f,
                    PVPA = 0.58f,
                    PFCO = 1.48f,
                    DY = 5.20f,
                    PSR = 0.92f,
                    EVEBIT = 4.39f,
                    ROE = 10.93f,
                    ROIC = 11.33f,
                    LC = 1.06f,
                    DBPL = 0.65f,
                    LPA = 1.16f,
                    VPA = 10.60f,
                    DPA = 0.25f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 5.57f,
                    PVPA = 0.63f,
                    PFCO = 1.57f,
                    DY = 4.67f,
                    PSR = 0.97f,
                    EVEBIT = 3.83f,
                    ROE = 11.23f,
                    ROIC = 11.60f,
                    LC = 1.16f,
                    DBPL = 0.58f,
                    LPA = 1.22f,
                    VPA = 10.83f,
                    DPA = 0.25f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 2.04f,
                    PVPA = 0.45f,
                    PFCO = 1.78f,
                    DY = 4.63f,
                    PSR = 0.95f,
                    EVEBIT = 1.22f,
                    ROE = 21.84f,
                    ROIC = 20.16f,
                    LC = 1.08f,
                    DBPL = 0.47f,
                    LPA = 3.36f,
                    VPA = 15.39f,
                    DPA = 0.32f
                }));

            #endregion

            return localList;
        }
    }
}
