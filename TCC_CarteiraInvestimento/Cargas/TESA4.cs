using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> TESA4()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "TESA4",
                Nome = "CIA FERRO LIGAS BAHIA FERBASA",
                Setor = Setor.SiderurgiaMetalurgia
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 6.20f,
                    PVPA = 0.99f,
                    PFCO = 5.05f,
                    DY = 5.89f,
                    PSR = 1.41f,
                    EVEBIT = 4.56f,
                    ROE = 15.96f,
                    ROIC = 12.41f,
                    LC = 5.74f,
                    DBPL = 0.04f,
                    LPA = 2.87f,
                    VPA = 17.96f,
                    DPA = 1.02f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 6.43f,
                    PVPA = 1.05f,
                    PFCO = 6.16f,
                    DY = 7.63f,
                    PSR = 1.79f,
                    EVEBIT = 7.50f,
                    ROE = 16.36f,
                    ROIC = 10.83f,
                    LC = 2.72f,
                    DBPL = 0.35f,
                    LPA = 3.01f,
                    VPA = 18.41f,
                    DPA = 1.30f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 5.12f,
                    PVPA = 1.03f,
                    PFCO = 5.86f,
                    DY = 6.19f,
                    PSR = 1.61f,
                    EVEBIT = 4.49f,
                    ROE = 20.06f,
                    ROIC = 16.44f,
                    LC = 3.15f,
                    DBPL = 0.24f,
                    LPA = 3.97f,
                    VPA = 19.80f,
                    DPA = 1.12f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 6.20f,
                    PVPA = 1.10f,
                    PFCO = 6.26f,
                    DY = 5.73f,
                    PSR = 1.64f,
                    EVEBIT = 5.38f,
                    ROE = 17.65f,
                    ROIC = 15.60f,
                    LC = 3.12f,
                    DBPL = 0.23f,
                    LPA = 3.50f,
                    VPA = 19.80f,
                    DPA = 1.10f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 6.86f,
                    PVPA = 0.65f,
                    PFCO = 2.59f,
                    DY = 7.70f,
                    PSR = 0.90f,
                    EVEBIT = 12.05f,
                    ROE = 9.57f,
                    ROIC = 4.33f,
                    LC = 5.96f,
                    DBPL = 0.03f,
                    LPA = 1.55f,
                    VPA = 16.23f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 4.35f,
                    PVPA = 0.65f,
                    PFCO = 2.43f,
                    DY = 8.93f,
                    PSR = 0.93f,
                    EVEBIT = 3.89f,
                    ROE = 14.92f,
                    ROIC = 8.84f,
                    LC = 6.30f,
                    DBPL = 0.04f,
                    LPA = 2.52f,
                    VPA = 16.87f,
                    DPA = 0.15f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.46f,
                    PVPA = 1.20f,
                    PFCO = 4.25f,
                    DY = 10.10f,
                    PSR = 1.65f,
                    EVEBIT = 6.39f,
                    ROE = 18.57f,
                    ROIC = 12.76f,
                    LC = 5.94f,
                    DBPL = 0.04f,
                    LPA = 3.17f,
                    VPA = 17.08f,
                    DPA = 0.68f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.14f,
                    PVPA = 1.27f,
                    PFCO = 4.92f,
                    DY = 6.11f,
                    PSR = 1.79f,
                    EVEBIT = 6.02f,
                    ROE = 17.72f,
                    ROIC = 13.05f,
                    LC = 5.25f,
                    DBPL = 0.04f,
                    LPA = 3.06f,
                    VPA = 17.24f,
                    DPA = 1.02f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 3.57f,
                    PVPA = 0.48f,
                    PFCO = 5.85f,
                    DY = 11.88f,
                    PSR = 0.55f,
                    EVEBIT = 2.19f,
                    ROE = 13.51f,
                    ROIC = 16.14f,
                    LC = 4.75f,
                    DBPL = 0.01f,
                    LPA = 2.10f,
                    VPA = 15.57f,
                    DPA = 0.85f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 7.92f,
                    PVPA = 0.49f,
                    PFCO = 5.34f,
                    DY = 12.13f,
                    PSR = 0.55f,
                    EVEBIT = 3.60f,
                    ROE = 6.20f,
                    ROIC = 9.70f,
                    LC = 6.16f,
                    DBPL = 0.02f,
                    LPA = 0.96f,
                    VPA = 15.53f,
                    DPA = 0.85f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.84f,
                    PVPA = 0.46f,
                    PFCO = 3.88f,
                    DY = 4.90f,
                    PSR = 0.52f,
                    EVEBIT = 9.85f,
                    ROE = 3.63f,
                    ROIC = 3.53f,
                    LC = 6.36f,
                    DBPL = 0.02f,
                    LPA = 0.56f,
                    VPA = 15.55f,
                    DPA = 0.33f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.82f,
                    PVPA = 0.50f,
                    PFCO = 2.28f,
                    DY = 10.27f,
                    PSR = 0.66f,
                    EVEBIT = 93.08f,
                    ROE = 5.13f,
                    ROIC = 2.37f,
                    LC = 3.79f,
                    DBPL = 0.03f,
                    LPA = 0.79f,
                    VPA = 15.37f,
                    DPA = 0.15f
                }));

            #endregion

            return localList;
        }
    }
}
