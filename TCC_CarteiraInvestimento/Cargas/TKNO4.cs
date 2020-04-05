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
        public static List<Cromossomo> TKNO4()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa 
            {
                Codigo = "TKNO4",
                Nome = "TEKNO S.A. INDÚSTRIA E COMÉRCIO",
                Setor = Setor.SiderurgiaMetalurgia
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL =  -6.99f,
                    PVPA = 0.56f,
                    PFCO = -9.65f,
                    DY = 0.00f,
                    PSR = 0.76f,
                    EVEBIT = -5.22f,
                    ROE = -7.96f,
                    ROIC = -8.66f,
                    LC = 3.45f,
                    DBPL = 0.03f,
                    LPA = -4.61f,
                    VPA = 57.95f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = -6.15f,
                    PVPA = 0.57f,
                    PFCO = -10.29f,
                    DY = 0.00f,
                    PSR = 0.77f,
                    EVEBIT = -4.66f,
                    ROE = -9.34f,
                    ROIC = -9.69f,
                    LC = 3.55f,
                    DBPL = 0.04f,
                    LPA = -5.24f,
                    VPA = 56.15f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = -7.92f,
                    PVPA = 0.63f,
                    PFCO = -22.48f,
                    DY = 0.00f,
                    PSR = 0.81f,
                    EVEBIT = -6.21f,
                    ROE = -7.91f,
                    ROIC = -8.13f,
                    LC = 3.14f,
                    DBPL = 0.04f,
                    LPA = -4.42f,
                    VPA = 55.85f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 146.58f,
                    PVPA = 0.60f,
                    PFCO = -186.52f,
                    DY = 0.00f,
                    PSR = 0.77f,
                    EVEBIT = -30.62f,
                    ROE = 0.41f,
                    ROIC = -4.46f,
                    LC = 3.25f,
                    DBPL = 0.04f,
                    LPA = 0.24f,
                    VPA = 58.81f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -15.61f,
                    PVPA = 1.42f,
                    PFCO = -15.14f,
                    DY = 0.00f,
                    PSR = 2.26f,
                    EVEBIT = -10.07f,
                    ROE = -9.10f,
                    ROIC = -11.52f,
                    LC = 5.17f,
                    DBPL = 0.04f,
                    LPA = -5.67f,
                    VPA = 62.34f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -16.92f,
                    PVPA = 1.45f,
                    PFCO = -16.58f,
                    DY = 0.00f,
                    PSR = 2.20f,
                    EVEBIT = -11.38f,
                    ROE = -8.55f,
                    ROIC = -10.71f,
                    LC = 4.36f,
                    DBPL = 0.04f,
                    LPA = -5.23f,
                    VPA = 61.18f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -14.30f,
                    PVPA = 1.47f,
                    PFCO = -16.28f,
                    DY = 0.00f,
                    PSR = 2.24f,
                    EVEBIT = -10.35f,
                    ROE = -10.31f,
                    ROIC = -11.89f,
                    LC = 4.17f,
                    DBPL = 0.03f,
                    LPA = -6.19f,
                    VPA = 60.06f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = -14.30f,
                    PVPA = 1.47f,
                    PFCO = -16.28f,
                    DY = 0.00f,
                    PSR = 2.24f,
                    EVEBIT = -10.35f,
                    ROE = -10.31f,
                    ROIC = -11.89f,
                    LC = 4.17f,
                    DBPL = 0.03f,
                    LPA = -6.19f,
                    VPA = 60.06f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = -18.33f,
                    PVPA = 1.30f,
                    PFCO = -55.66f,
                    DY = 1.27f,
                    PSR = 2.43f,
                    EVEBIT = -9.17f,
                    ROE = -7.10f,
                    ROIC = -10.83f,
                    LC = 6.11f,
                    DBPL = 0.00f,
                    LPA = -4.83f,
                    VPA = 67.98f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = -17.63f,
                    PVPA = 1.33f,
                    PFCO = -100.89f,
                    DY = 0.00f,
                    PSR = 2.53f,
                    EVEBIT = -8.98f,
                    ROE = -7.56f,
                    ROIC = -11.04f,
                    LC = 5.53f,
                    DBPL = 0.00f,
                    LPA = -5.02f,
                    VPA = 66.38f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = -20.78f,
                    PVPA = 1.34f,
                    PFCO = -32.32f,
                    DY = 0.00f,
                    PSR = 2.35f,
                    EVEBIT = -10.86f,
                    ROE = -6.43f,
                    ROIC = -9.40f,
                    LC = 5.02f,
                    DBPL = 0.00f,
                    LPA = -4.26f,
                    VPA = 66.21f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = -15.50f,
                    PVPA = 1.39f,
                    PFCO = -17.65f,
                    DY = 0.00f,
                    PSR = 2.40f,
                    EVEBIT = -9.06f,
                    ROE = -8.94f,
                    ROIC = -11.34f,
                    LC = 4.76f,
                    DBPL = 0.03f,
                    LPA = -5.71f,
                    VPA = 63.80f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }
    }
}
