using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> ABCB4()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "ABCB4",
                Nome = "BANCO ABC BRASIL S/A.",
                Setor = Setor.Financeiros
            };

            #region Compreende todo o ano de 2018

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 6.29f,
                    PVPA = 0.79f,
                    PFCO = -0.91f,
                    DY = 5.98f,
                    PSR = 1.19f,
                    EVEBIT = null,
                    ROE = 12.59f,
                    ROIC = null,
                    LC = 1.20f,
                    DBPL = null,
                    LPA = 2.36f,
                    VPA = 18.77f,
                    DPA = 1.14f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 5.84f,
                    PVPA = 0.74f,
                    PFCO = -0.83f,
                    DY = 7.11f,
                    PSR = 0.86f,
                    EVEBIT = null,
                    ROE = 12.62f,
                    ROIC = null,
                    LC = 1.17f,
                    DBPL = null,
                    LPA = 2.39f,
                    VPA = 18.91f,
                    DPA = 1.16f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.84f,
                    PVPA = 0.84f,
                    PFCO = -3.27f,
                    DY = 7.68f,
                    PSR = 0.87f,
                    EVEBIT = null,
                    ROE = 12.35f,
                    ROIC = null,
                    LC = 1.17f,
                    DBPL = null,
                    LPA = 2.45f,
                    VPA = 19.86f,
                    DPA = 1.17f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.62f,
                    PVPA = 1.10f,
                    PFCO = 48.14f,
                    DY = 6.39f,
                    PSR = 1.34f,
                    EVEBIT = null,
                    ROE = 11.41f,
                    ROIC = null,
                    LC = 1.20f,
                    DBPL = null,
                    LPA = 1.98f,
                    VPA = 17.36f,
                    DPA = 1.04f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 8.29f,
                    PVPA = 1.13f,
                    PFCO = -0.90f,
                    DY = 5.84f,
                    PSR = 1.83f,
                    EVEBIT = null,
                    ROE = 13.60f,
                    ROIC = null,
                    LC = 1.28f,
                    DBPL = null,
                    LPA = 2.26f,
                    VPA = 16.64f,
                    DPA = 1.07f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 7.36f,
                    PVPA = 0.99f,
                    PFCO = -0.62f,
                    DY = 6.53f,
                    PSR = 1.31f,
                    EVEBIT = null,
                    ROE = 13.44f,
                    ROIC = null,
                    LC = 1.27f,
                    DBPL = null,
                    LPA = 2.28f,
                    VPA = 16.96f,
                    DPA = 1.09f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 7.50f,
                    PVPA = 0.97f,
                    PFCO = -1.03f,
                    DY = 6.20f,
                    PSR = 1.43f,
                    EVEBIT = null,
                    ROE = 12.91f,
                    ROIC = null,
                    LC = 1.27f,
                    DBPL = null,
                    LPA = 2.29f,
                    VPA = 17.72f,
                    DPA = 1.11f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.00f,
                    PVPA = 1.02f,
                    PFCO = -0.94f,
                    DY = 6.32f,
                    PSR = 1.43f,
                    EVEBIT = null,
                    ROE = 12.75f,
                    ROIC = null,
                    LC = 1.18f,
                    DBPL = null,
                    LPA = 2.30f,
                    VPA = 18.02f,
                    DPA = 1.13f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.86f,
                    PVPA = 0.85f,
                    PFCO = 3.34f,
                    DY = 7.09f,
                    PSR = 0.83f,
                    EVEBIT = null,
                    ROE = 14.52f,
                    ROIC = null,
                    LC = 1.18f,
                    DBPL = null,
                    LPA = 2.10f,
                    VPA = 14.43f,
                    DPA = 0.83f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 6.02f,
                    PVPA = 0.89f,
                    PFCO = 3.01f,
                    DY = 7.83f,
                    PSR = 1.00f,
                    EVEBIT = null,
                    ROE = 14.72f,
                    ROIC = null,
                    LC = 1.22f,
                    DBPL = null,
                    LPA = 2.17f,
                    VPA = 14.76f,
                    DPA = 0.91f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 6.11f,
                    PVPA = 0.87f,
                    PFCO = -3.29f,
                    DY = 7.57f,
                    PSR = 1.56f,
                    EVEBIT = null,
                    ROE = 14.25f,
                    ROIC = null,
                    LC = 1.20f,
                    DBPL = null,
                    LPA = 2.21f,
                    VPA = 15.54f,
                    DPA = 0.98f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 6.25f,
                    PVPA = 0.88f,
                    PFCO = -1.17f,
                    DY = 7.80f,
                    PSR = 1.54f,
                    EVEBIT = null,
                    ROE = 14.05f,
                    ROIC = null,
                    LC = 1.26f,
                    DBPL = null,
                    LPA = 2.23f,
                    VPA = 15.88f,
                    DPA = 1.03f
                }));

            #endregion

            return localList;
        }
    }
}
