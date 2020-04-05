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
        public static List<Cromossomo> JBSS3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "JBSS3",
                Nome = "JBS SA.",
                Setor = Setor.Alimentos
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 40.59f,
                    PVPA = 0.94f,
                    PFCO = 5.45f,
                    DY = 0.35f,
                    PSR = 0.42f,
                    EVEBIT = 9.81f,
                    ROE = 2.29f,
                    ROIC = 8.90f,
                    LC = 1.26f,
                    DBPL = 2.09f,
                    LPA = 0.22f,
                    VPA = 9.45f,
                    DPA = -0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = -93.80f,
                    PVPA = 0.94f,
                    PFCO = 3.89f,
                    DY = 0.50f,
                    PSR = 0.41f,
                    EVEBIT = 7.60f,
                    ROE = -1.03f,
                    ROIC = 12.29f,
                    LC = 1.92f,
                    DBPL = 2.23f,
                    LPA = -0.10f,
                    VPA = 9.97f,
                    DPA = -0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = -43.46f,
                    PVPA = 1.11f,
                    PFCO = 4.71f,
                    DY = 0.50f,
                    PSR = 0.42f,
                    EVEBIT = 8.44f,
                    ROE = -2.58f,
                    ROIC = 12.94f,
                    LC = 1.88f,
                    DBPL = 2.13f,
                    LPA = -0.26f,
                    VPA = 10.15f,
                    DPA = -0.04f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 1592.00f,
                    PVPA = 1.63f,
                    PFCO = 6.11f,
                    DY = 0.40f,
                    PSR = 0.54f,
                    EVEBIT = 12.90f,
                    ROE = 0.09f,
                    ROIC = 10.10f,
                    LC = 1.71f,
                    DBPL = 2.01f,
                    LPA = 0.01f,
                    VPA = 9.78f,
                    DPA = 0.00f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 5.87f,
                    PVPA = 0.82f,
                    PFCO = 4.65f,
                    DY = 3.94f,
                    PSR = 0.37f,
                    EVEBIT = 9.98f,
                    ROE = 13.91f,
                    ROIC = 6.90f,
                    LC = 1.10f,
                    DBPL = 2.30f,
                    LPA = 1.24f,
                    VPA = 8.91f,
                    DPA = 0.03f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.52f,
                    PSR = 0.00f,
                    EVEBIT = 0.00f,
                    ROE = 0.00f,
                    ROIC = 0.00f,
                    LC = 0.00f,
                    DBPL = 0.00f,
                    LPA = 0.00f,
                    VPA = 0.00f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 19.62f,
                    PVPA = 1.03f,
                    PFCO = 4.07f,
                    DY = 0.39f,
                    PSR = 0.59f,
                    EVEBIT = 17.23f,
                    ROE = 5.28f,
                    ROIC = 4.55f,
                    LC = 1.23f,
                    DBPL = 2.19f,
                    LPA = 0.50f,
                    VPA = 9.54f,
                    DPA = 0.03f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.34f,
                    PSR = 0.00f,
                    EVEBIT = 0.00f,
                    ROE = 0.00f,
                    ROIC = 0.00f,
                    LC = 0.00f,
                    DBPL = 0.00f,
                    LPA = 0.00f,
                    VPA = 0.00f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }
    }
}
