using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> BRSR6()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa 
            {
                Nome = "BANCO DO ESTADO DO RIO GRANDE DO SUL SA.",
                Codigo = "BRSR6",
                Setor = Setor.Financeiros
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.85f,
                    PVPA = 0.95f,
                    PFCO = -31.07f,
                    DY = 5.07f,
                    PSR = 4.06f,
                    EVEBIT = null,
                    ROE = 16.24f,
                    ROIC = null,
                    LC = 1.65f,
                    DBPL = null,
                    LPA = 2.86f,
                    VPA = 17.59f,
                    DPA = 1.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 4.93f,
                    PVPA = 0.87f,
                    PFCO = 2.76f,
                    DY = 7.13f,
                    PSR = 4.09f,
                    EVEBIT = null,
                    ROE = 17.67f,
                    ROIC = null,
                    LC = 1.47f,
                    DBPL = null,
                    LPA = 3.04f,
                    VPA = 17.79f,
                    DPA = 1.12f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.73f,
                    PVPA = 1.22f,
                    PFCO = 2.60f,
                    DY = 7.11f,
                    PSR = 4.38f,
                    EVEBIT = null,
                    ROE = 18.11f,
                    ROIC = null,
                    LC = 1.41f,
                    DBPL = null,
                    LPA = 3.21f,
                    VPA = 17.72f,
                    DPA = 1.13f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.45f,
                    PVPA = 1.36f,
                    PFCO = 4.84f,
                    DY = 8.59f,
                    PSR = 4.54f,
                    EVEBIT = null,
                    ROE = 14.41f,
                    ROIC = null,
                    LC = 1.35f,
                    DBPL = null,
                    LPA = 2.56f,
                    VPA = 17.79f,
                    DPA = 1.03f
                }));

            #endregion

            #region Compreeende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 10.29f,
                    PVPA = 0.95f,
                    PFCO = 1.97f,
                    DY = 2.87f,
                    PSR = 3.35f,
                    EVEBIT = null,
                    ROE = 9.26f,
                    ROIC = null,
                    LC = 1.33f,
                    DBPL = null,
                    LPA = 1.47f,
                    VPA = 15.85f,
                    DPA = 0.66f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.19f,
                    PVPA = 0.81f,
                    PFCO = 2.55f,
                    DY = 5.24f,
                    PSR = 3.31f,
                    EVEBIT = null,
                    ROE = 8.88f,
                    ROIC = null,
                    LC = 1.34f,
                    DBPL = null,
                    LPA = 1.43f,
                    VPA = 16.14f,
                    DPA = 0.66f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 10.26f,
                    PVPA = 1.07f,
                    PFCO = 4.23f,
                    DY = 3.87f,
                    PSR = 3.77f,
                    EVEBIT = null,
                    ROE = 10.43f,
                    ROIC = null,
                    LC = 1.60f,
                    DBPL = null,
                    LPA = 1.72f,
                    VPA = 16.45f,
                    DPA = 0.67f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 5.80f,
                    PVPA = 0.87f,
                    PFCO = 4.61f,
                    DY = 6.84f,
                    PSR = 3.81f,
                    EVEBIT = null,
                    ROE = 14.98f,
                    ROIC = null,
                    LC = 1.56f,
                    DBPL = null,
                    LPA = 2.57f,
                    VPA = 17.19f,
                    DPA = 1.03f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 3.67f,
                    PVPA = 0.52f,
                    PFCO = 1.38f,
                    DY = 3.13f,
                    PSR = 2.70f,
                    EVEBIT = null,
                    ROE = 14.08f,
                    ROIC = null,
                    LC = 1.09f,
                    DBPL = null,
                    LPA = 2.18f,
                    VPA = 15.45f,
                    DPA = 0.87f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 3.88f,
                    PVPA = 0.54f,
                    PFCO = 1.32f,
                    DY = 2.69f,
                    PSR = 2.79f,
                    EVEBIT = null,
                    ROE = 13.95f,
                    ROIC = null,
                    LC = 1.07f,
                    DBPL = null,
                    LPA = 2.20f,
                    VPA = 15.75f,
                    DPA = 0.86f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.62f,
                    PVPA = 0.66f,
                    PFCO = 1.40f,
                    DY = 1.75f,
                    PSR = 3.05f,
                    EVEBIT = null,
                    ROE = 9.96f,
                    ROIC = null,
                    LC = 1.15f,
                    DBPL = null,
                    LPA = 1.58f,
                    VPA = 15.82f,
                    DPA = 0.82f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 6.41f,
                    PVPA = 0.66f,
                    PFCO = 1.08f,
                    DY = 2.25f,
                    PSR = 3.11f,
                    EVEBIT = null,
                    ROE = 10.24f,
                    ROIC = null,
                    LC = 1.18f,
                    DBPL = null,
                    LPA = 1.61f,
                    VPA = 15.75f,
                    DPA = 0.65f
                }));

            #endregion

            return localList;
        }
    }
}
