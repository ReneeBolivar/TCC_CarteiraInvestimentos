using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> TEND3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "TEND3",
                Nome = "CONSTRUTORA TENDA S/A.",
                Setor = Setor.ConstrucaoEngenharia
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.92f,
                    PVPA = 1.02f,
                    PFCO = 5.83f,
                    DY = 0.00f,
                    PSR = 1.14f,
                    EVEBIT = 6.78f,
                    ROE = 10.25f,
                    ROIC = 7.57f,
                    LC = 3.93f,
                    DBPL = 0.31f,
                    LPA = 2.30f,
                    VPA = 22.39f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.27f,
                    PVPA = 1.20f,
                    PFCO = 8.08f,
                    DY = 0.00f,
                    PSR = 1.22f,
                    EVEBIT = 6.72f,
                    ROE = 13.00f,
                    ROIC = 9.44f,
                    LC = 3.91f,
                    DBPL = 0.32f,
                    LPA = 2.86f,
                    VPA = 22.03f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.81f,
                    PVPA = 1.36f,
                    PFCO = 8.52f,
                    DY = 0.00f,
                    PSR = 1.39f,
                    EVEBIT = 6.38f,
                    ROE = 15.48f,
                    ROIC = 10.32f,
                    LC = 4.18f,
                    DBPL = 0.44f,
                    LPA = 3.49f,
                    VPA = 22.54f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 4.55f,
                    PVPA = 0.76f,
                    PFCO = 3.22f,
                    DY = 1.59f,
                    PSR = 0.86f,
                    EVEBIT = 2.73f,
                    ROE = 16.64f,
                    ROIC = 11.04f,
                    LC = 3.94f,
                    DBPL = 0.45f,
                    LPA = 3.71f,
                    VPA = 22.28f,
                    DPA = 0.71f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 3.79f,
                    PVPA = 0.24f,
                    PFCO = 2.54f,
                    DY = 0.00f,
                    PSR = 0.33f,
                    EVEBIT = 1.61f,
                    ROE = 6.43f,
                    ROIC = 6.20f,
                    LC = 3.76f,
                    DBPL = 0.16f,
                    LPA = 1.31f,
                    VPA = 20.37f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.55f,
                    PVPA = 0.73f,
                    PFCO = 3.97f,
                    DY = 0.00f,
                    PSR = 0.75f,
                    EVEBIT = 5.79f,
                    ROE = 7.58f,
                    ROIC = 7.02f,
                    LC = 3.55f,
                    DBPL = 0.16f,
                    LPA = 1.54f,
                    VPA = 20.26f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 13.61f,
                    PVPA = 1.10f,
                    PFCO = 4.98f,
                    DY = 0.00f,
                    PSR = 1.02f,
                    EVEBIT = 9.14f,
                    ROE = 8.05f,
                    ROIC = 7.35f,
                    LC = 3.66f,
                    DBPL = 0.12f,
                    LPA = 1.68f,
                    VPA = 20.85f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 12.77f,
                    PVPA = 1.17f,
                    PFCO = 7.21f,
                    DY = 0.00f,
                    PSR = 1.18f,
                    EVEBIT = 9.16f,
                    ROE = 9.17f,
                    ROIC = 7.36f,
                    LC = 3.48f,
                    DBPL = 0.23f,
                    LPA = 1.97f,
                    VPA = 21.54f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 11.30f,
                    PVPA = 0.24f,
                    PFCO = 14.41f,
                    DY = 0.00f,
                    PSR = 0.38f,
                    EVEBIT = 7.68f,
                    ROE = 2.09f,
                    ROIC = 1.48f,
                    LC = 2.80f,
                    DBPL = 0.26f,
                    LPA = 0.44f,
                    VPA = 20.95f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 21.61f,
                    PVPA = 0.24f,
                    PFCO = 3.98f,
                    DY = 0.00f,
                    PSR = 0.38f,
                    EVEBIT = 6.04f,
                    ROE = 1.07f,
                    ROIC = 1.33f,
                    LC = 2.89f,
                    DBPL = 0.23f,
                    LPA = 0.23f,
                    VPA = 21.13f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 11.56f,
                    PVPA = 0.23f,
                    PFCO = 3.35f,
                    DY = 0.00f,
                    PSR = 0.36f,
                    EVEBIT = 4.15f,
                    ROE = 2.03f,
                    ROIC = 2.41f,
                    LC = 3.09f,
                    DBPL = 0.17f,
                    LPA = 0.43f,
                    VPA = 21.43f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 4.73f,
                    PVPA = 0.25f,
                    PFCO = 1.96f,
                    DY = 0.00f,
                    PSR = 0.34f,
                    EVEBIT = 2.04f,
                    ROE = 5.27f,
                    ROIC = 5.56f,
                    LC = 3.44f,
                    DBPL = 0.13f,
                    LPA = 1.05f,
                    VPA = 19.91f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }
    }
}
