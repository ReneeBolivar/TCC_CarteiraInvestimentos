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
        public static List<Cromossomo> GGBR3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "GGBR3",
                Nome = "GERDAU S.A.",
                Setor = Setor.SiderurgiaMetalurgia
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = -25.68f,
                    PVPA = 0.79f,
                    PFCO = 10.32f,
                    DY = 0.61f,
                    PSR = 0.86f,
                    EVEBIT = 37.84f,
                    ROE = -3.04f,
                    ROIC = 2.02f,
                    LC = 2.39f,
                    DBPL = 0.69f,
                    LPA = -0.43f,
                    VPA = 14.03f,
                    DPA = 0.03f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = -190.74f,
                    PVPA = 0.89f,
                    PFCO = 9.95f,
                    DY = 1.49f,
                    PSR = 0.93f,
                    EVEBIT = 24.49f,
                    ROE = -0.44f,
                    ROIC = 3.78f,
                    LC = 2.36f,
                    DBPL = 0.71f,
                    LPA = -0.07f,
                    VPA = 14.93f,
                    DPA = 0.11f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 38.03f,
                    PVPA = 0.76f,
                    PFCO = 7.88f,
                    DY = 2.10f,
                    PSR = 0.81f,
                    EVEBIT = 15.57f,
                    ROE = 2.00f,
                    ROIC = 5.54f,
                    LC = 2.42f,
                    DBPL = 0.68f,
                    LPA = 0.31f,
                    VPA = 15.56f,
                    DPA = 0.25f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.10f,
                    PVPA = 0.81f,
                    PFCO = 10.49f,
                    DY = 3.10f,
                    PSR = 0.74f,
                    EVEBIT = 8.04f,
                    ROE = 8.88f,
                    ROIC = 10.32f,
                    LC = 2.06f,
                    DBPL = 0.57f,
                    LPA = 1.34f,
                    VPA = 15.08f,
                    DPA = 0.25f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -8.72f,
                    PVPA = 0.73f,
                    PFCO = 6.91f,
                    DY = 0.48f,
                    PSR = 0.93f,
                    EVEBIT = -51.36f,
                    ROE = -8.36f,
                    ROIC = -2.57f,
                    LC = 2.06f,
                    DBPL = 0.79f,
                    LPA = -1.21f,
                    VPA = 14.49f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -8.85f,
                    PVPA = 0.73f,
                    PFCO = 8.94f,
                    DY = 0.50f,
                    PSR = 0.98f,
                    EVEBIT = -56.87f,
                    ROE = -8.22f,
                    ROIC = -1.47f,
                    LC = 2.08f,
                    DBPL = 0.79f,
                    LPA = -1.21f,
                    VPA = 14.74f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -8.71f,
                    PVPA = 0.72f,
                    PFCO = 12.17f,
                    DY = 0.36f,
                    PSR = 0.90f,
                    EVEBIT = -53.08f,
                    ROE = -8.19f,
                    ROIC = -1.97f,
                    LC = 1.89f,
                    DBPL = 0.75f,
                    LPA = -1.19f,
                    VPA = 14.48f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = -61.67f,
                    PVPA = 0.93f,
                    PFCO = 10.73f,
                    DY = 0.48f,
                    PSR = 1.00f,
                    EVEBIT = 32.18f,
                    ROE = -1.50f,
                    ROIC = 1.99f,
                    LC = 2.33f,
                    DBPL = 0.69f,
                    LPA = -0.21f,
                    VPA = 13.89f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }
    }
}
