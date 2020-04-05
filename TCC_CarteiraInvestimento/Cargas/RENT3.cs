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
        public static List<Cromossomo> RENT3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "RENT3",
                Nome = "LOCALIZA RENT A CAR SA.",
                Setor = Setor.Diversos
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 25.55f,
                    PVPA = 5.25f,
                    PFCO = -6.86f,
                    DY = 1.72f,
                    PSR = 3.12f,
                    EVEBIT = 17.08f,
                    ROE = 20.62f,
                    ROIC = 9.51f,
                    LC = 1.78f,
                    DBPL = 2.44f,
                    LPA = 0.88f,
                    VPA = 4.28f,
                    DPA = 0.26f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 25.28f,
                    PVPA = 5.09f,
                    PFCO = -5.32f,
                    DY = 1.60f,
                    PSR = 2.94f,
                    EVEBIT = 17.18f,
                    ROE = 20.20f,
                    ROIC = 10.11f,
                    LC = 1.42f,
                    DBPL = 2.22f,
                    LPA = 0.90f,
                    VPA = 4.47f,
                    DPA = 0.27f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 30.21f,
                    PVPA = 6.22f,
                    PFCO = -9.45f,
                    DY = 1.15f,
                    PSR = 3.38f,
                    EVEBIT = 19.83f,
                    ROE = 20.64f,
                    ROIC = 9.31f,
                    LC = 1.37f,
                    DBPL = 2.51f,
                    LPA = 0.96f,
                    VPA = 4.66f,
                    DPA = 0.27f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 31.79f,
                    PVPA = 6.79f,
                    PFCO = -311.55f,
                    DY = 0.91f,
                    PSR = 3.55f,
                    EVEBIT = 20.89f,
                    ROE = 21.30f,
                    ROIC = 9.57f,
                    LC = 1.11f,
                    DBPL = 2.47f,
                    LPA = 1.04f,
                    VPA = 4.87f,
                    DPA = 0.28f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 20.73f,
                    PVPA = 3.83f,
                    PFCO = -38.63f,
                    DY = 5.70f,
                    PSR = 2.53f,
                    EVEBIT = 13.60f,
                    ROE = 18.52f,
                    ROIC = 11.63f,
                    LC = 1.42f,
                    DBPL = 1.53f,
                    LPA = 2.01f,
                    VPA = 10.87f,
                    DPA = 0.74f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 26.62f,
                    PVPA = 5.06f,
                    PFCO = -55.96f,
                    DY = 3.89f,
                    PSR = 3.17f,
                    EVEBIT = 16.76f,
                    ROE = 19.03f,
                    ROIC = 10.57f,
                    LC = 1.41f,
                    DBPL = 1.86f,
                    LPA = 2.16f,
                    VPA = 11.36f,
                    DPA = 0.75f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 29.41f,
                    PVPA = 5.58f,
                    PFCO = -21.61f,
                    DY = 4.06f,
                    PSR = 3.36f,
                    EVEBIT = 18.97f,
                    ROE = 18.99f,
                    ROIC = 10.03f,
                    LC = 1.08f,
                    DBPL = 2.06f,
                    LPA = 0.75f,
                    VPA = 3.95f,
                    DPA = 0.26f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 34.62f,
                    PVPA = 6.77f,
                    PFCO = -7.20f,
                    DY = 2.82f,
                    PSR = 3.89f,
                    EVEBIT = 22.15f,
                    ROE = 19.44f,
                    ROIC = 9.04f,
                    LC = 1.54f,
                    DBPL = 2.49f,
                    LPA = 0.80f,
                    VPA = 4.09f,
                    DPA = 0.26f
                }));

            #endregion


            return localList;
        }
    }
}
