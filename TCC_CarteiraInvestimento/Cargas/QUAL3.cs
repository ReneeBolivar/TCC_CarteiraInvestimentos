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
        public static List<Cromossomo> QUAL3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "QUAL3",
                Nome = "QUALICORP SA.",
                Setor = Setor.Saude
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 12.81f,
                    PVPA = 2.07f,
                    PFCO = 8.34f,
                    DY = 6.14f,
                    PSR = 2.60f,
                    EVEBIT = 7.66f,
                    ROE = 16.11f,
                    ROIC = 14.01f,
                    LC = 2.02f,
                    DBPL = 0.27f,
                    LPA = 1.32f,
                    VPA = 8.18f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 11.77f,
                    PVPA = 2.11f,
                    PFCO = 7.62f,
                    DY = 8.76f,
                    PSR = 2.58f,
                    EVEBIT = 7.33f,
                    ROE = 17.94f,
                    ROIC = 15.35f,
                    LC = 2.10f,
                    DBPL = 0.28f,
                    LPA = 1.40f,
                    VPA = 7.81f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.94f,
                    PVPA = 1.53f,
                    PFCO = 5.36f,
                    DY = 7.58f,
                    PSR = 2.10f,
                    EVEBIT = 5.53f,
                    ROE = 17.15f,
                    ROIC = 14.29f,
                    LC = 1.64f,
                    DBPL = 0.27f,
                    LPA = 1.41f,
                    VPA = 8.21f,
                    DPA = 0.02f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 11.04f,
                    PVPA = 1.86f,
                    PFCO = 5.61f,
                    DY = 5.62f,
                    PSR = 2.26f,
                    EVEBIT = 6.85f,
                    ROE = 16.86f,
                    ROIC = 14.31f,
                    LC = 0.94f,
                    DBPL = 0.26f,
                    LPA = 1.42f,
                    VPA = 8.45f,
                    DPA = 0.02f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 18.27f,
                    PVPA = 2.63f,
                    PFCO = 7.31f,
                    DY = 8.32f,
                    PSR = 3.16f,
                    EVEBIT = 10.59f,
                    ROE = 14.47f,
                    ROIC = 12.67f,
                    LC = 1.45f,
                    DBPL = 0.29f,
                    LPA = 1.13f,
                    VPA = 7.84f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 30.71f,
                    PVPA = 4.35f,
                    PFCO = 13.55f,
                    DY = 4.85f,
                    PSR = 5.00f,
                    EVEBIT = 17.75f,
                    ROE = 14.19f,
                    ROIC = 12.48f,
                    LC = 1.67f,
                    DBPL = 0.28f,
                    LPA = 1.13f,
                    VPA = 7.98f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 24.41f,
                    PVPA = 3.79f,
                    PFCO = 11.96f,
                    DY = 4.59f,
                    PSR = 4.44f,
                    EVEBIT = 14.09f,
                    ROE = 15.49f,
                    ROIC = 13.76f,
                    LC = 1.71f,
                    DBPL = 0.28f,
                    LPA = 1.27f,
                    VPA = 8.18f,
                    DPA = -0.17f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 16.54f,
                    PVPA = 2.59f,
                    PFCO = 11.47f,
                    DY = 4.41f,
                    PSR = 3.25f,
                    EVEBIT = 10.16f,
                    ROE = 15.66f,
                    ROIC = 13.79f,
                    LC = 2.54f,
                    DBPL = 0.26f,
                    LPA = 1.33f,
                    VPA = 8.49f,
                    DPA = -0.17f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 10.93f,
                    PVPA = 1.90f,
                    PFCO = 7.53f,
                    DY = 12.99f,
                    PSR = 2.45f,
                    EVEBIT = 9.45f,
                    ROE = 17.39f,
                    ROIC = 15.67f,
                    LC = 1.05f,
                    DBPL = 0.24f,
                    LPA = 1.36f,
                    VPA = 7.83f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 13.68f,
                    PVPA = 2.48f,
                    PFCO = 9.52f,
                    DY = 12.53f,
                    PSR = 2.92f,
                    EVEBIT = 12.25f,
                    ROE = 18.13f,
                    ROIC = 16.26f,
                    LC = 0.99f,
                    DBPL = 0.26f,
                    LPA = 1.36f,
                    VPA = 7.49f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 13.80f,
                    PVPA = 2.39f,
                    PFCO = 9.36f,
                    DY = 4.27f,
                    PSR = 2.86f,
                    EVEBIT = 11.71f,
                    ROE = 17.39f,
                    ROIC = 16.27f,
                    LC = 0.87f,
                    DBPL = 0.24f,
                    LPA = 1.39f,
                    VPA = 8.01f,
                    DPA = 1.23f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.28f,
                    PVPA = 2.59f,
                    PFCO = 8.64f,
                    DY = 8.80f,
                    PSR = 3.04f,
                    EVEBIT = 11.12f,
                    ROE = 19.57f,
                    ROIC = 16.90f,
                    LC = 1.23f,
                    DBPL = 0.30f,
                    LPA = 1.45f,
                    VPA = 7.42f,
                    DPA = 1.23f
                }));

            #endregion

            return localList;
        }
    }
}
