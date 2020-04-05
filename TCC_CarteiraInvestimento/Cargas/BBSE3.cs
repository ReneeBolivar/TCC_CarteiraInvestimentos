using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> BBSE3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "BBSE3",
                Nome = "BB SEGURIDADE PARTICIPAÇÕES S.A.",
                Setor = Setor.PrevidenciaSeguros
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 12.46f,
                    PVPA = 5.01f,
                    PFCO = 27.95f,
                    DY = 5.98f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 47.06f,
                    ROIC = null,
                    LC = 3.30f,
                    DBPL = 0.31f,
                    LPA = 1.83f,
                    VPA = 3.90f,
                    DPA = 2.81f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 19.38f,
                    PVPA = 10.02f,
                    PFCO = 41.53f,
                    DY = 4.18f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 51.73f,
                    ROIC = null,
                    LC = 1.57f,
                    DBPL = 0.39f,
                    LPA = 1.84f,
                    VPA = 3.56f,
                    DPA = 2.92f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.12f,
                    PVPA = 7.13f,
                    PFCO = 104.60f,
                    DY = 3.79f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 58.76f,
                    ROIC = null,
                    LC = 2.99f,
                    DBPL = 0.42f,
                    LPA = 3.11f,
                    VPA = 5.29f,
                    DPA = 2.48f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.56f,
                    PVPA = 12.16f,
                    PFCO = 68.84f,
                    DY = 2.38f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 126.86f,
                    ROIC = null,
                    LC = 1.06f,
                    DBPL = 0.61f,
                    LPA = 3.33f,
                    VPA = 2.62f,
                    DPA = 2.78f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 14.46f,
                    PVPA = 6.29f,
                    PFCO = 41.20f,
                    DY = 5.74f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 43.59f,
                    ROIC = null,
                    LC = 2.67f,
                    DBPL = 0.23f,
                    LPA = 2.02f,
                    VPA = 4.64f,
                    DPA = 1.65f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 13.91f,
                    PVPA = 6.28f,
                    PFCO = 57.43f,
                    DY = 8.83f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 45.13f,
                    ROIC = null,
                    LC = 1.30f,
                    DBPL = 0.27f,
                    LPA = 1.96f,
                    VPA = 4.34f,
                    DPA = 1.61f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 13.83f,
                    PVPA = 5.77f,
                    PFCO = 39.08f,
                    DY = 5.74f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 41.69f,
                    ROIC = null,
                    LC = 2.69f,
                    DBPL = 0.27f,
                    LPA = 2.06f,
                    VPA = 4.94f,
                    DPA = 2.21f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.94f,
                    PVPA = 6.33f,
                    PFCO = 33.69f,
                    DY = 5.77f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 45.50f,
                    ROIC = null,
                    LC = 1.52f,
                    DBPL = 0.29f,
                    LPA = 2.02f,
                    VPA = 4.45f,
                    DPA = 1.72f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 14.08f,
                    PVPA = 6.97f,
                    PFCO = 60.87f,
                    DY = 5.66f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 49.45f,
                    ROIC = null,
                    LC = 2.18f,
                    DBPL = 0.25f,
                    LPA = 2.11f,
                    VPA = 4.26f,
                    DPA = 1.68f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 13.78f,
                    PVPA = 7.05f,
                    PFCO = 34.37f,
                    DY = 6.13f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 51.8f,
                    ROIC = null,
                    LC = 1.10f,
                    DBPL = 0.30f,
                    LPA = 2.04f,
                    VPA = 3.99f,
                    DPA = 1.64f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 14.79f,
                    PVPA = 6.65f,
                    PFCO = 37.14f,
                    DY = 5.50f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 45.05f,
                    ROIC = null,
                    LC = 1.82f,
                    DBPL = 0.29f,
                    LPA = 2.02f,
                    VPA = 4.49f,
                    DPA = 1.63f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 14.08f,
                    PVPA = 6.84f,
                    PFCO = 33.94f,
                    DY = 5.90f,
                    PSR = null,
                    EVEBIT = null,
                    ROE = 48.42f,
                    ROIC = null,
                    LC = 1.04f,
                    DBPL = 0.31f,
                    LPA = 2.01f,
                    VPA = 4.14f,
                    DPA = 1.65f
                }));

            #endregion

            return localList;
        }
    }
}
