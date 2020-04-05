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
        public static List<Cromossomo> POMO3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "POMO3",
                Nome = "MARCOPOLO SA.",
                Setor = Setor.MaterialTransporte
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 23.73f,
                    PVPA = 1.21f,
                    PFCO = 5.99f,
                    DY = 1.25f,
                    PSR = 1.16f,
                    EVEBIT = 23.69f,
                    ROE = 5.24f,
                    ROIC = 2.93f,
                    LC = 1.87f,
                    DBPL = 0.98f,
                    LPA = 0.11f,
                    VPA = 2.15f,
                    DPA = 0.02f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 23.18f,
                    PVPA = 1.13f,
                    PFCO = 5.63f,
                    DY = 1.58f,
                    PSR = 0.97f,
                    EVEBIT = 17.30f,
                    ROE = 5.06f,
                    ROIC = 4.52f,
                    LC = 1.56f,
                    DBPL = 1.00f,
                    LPA = 0.11f,
                    VPA = 2.25f,
                    DPA = 0.02f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 17.65f,
                    PVPA = 1.29f,
                    PFCO = 8.28f,
                    DY = 1.55f,
                    PSR = 0.98f,
                    EVEBIT = 13.55f,
                    ROE = 7.22f,
                    ROIC = 6.87f,
                    LC = 1.62f,
                    DBPL = 0.88f,
                    LPA = 0.17f,
                    VPA = 2.33f,
                    DPA = 0.02f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 17.00f,
                    PVPA = 1.52f,
                    PFCO = 14.41f,
                    DY = 3.40f,
                    PSR = 1.04f,
                    EVEBIT = 14.02f,
                    ROE = 8.75f,
                    ROIC = 6.95f,
                    LC = 1.67f,
                    DBPL = 0.91f,
                    LPA = 0.21f,
                    VPA = 2.35f,
                    DPA = 0.09f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.74f,
                    PVPA = 1.09f,
                    PFCO = -39.11f,
                    DY = 5.78f,
                    PSR = 1.24f,
                    EVEBIT = 9.70f,
                    ROE = 11.29f,
                    ROIC = 3.99f,
                    LC = 1.90f,
                    DBPL = 1.17f,
                    LPA = 0.23f,
                    VPA = 2.05f,
                    DPA = 0.13f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 15.29f,
                    PVPA = 1.54f,
                    PFCO = 28.84f,
                    DY = 6.09f,
                    PSR = 1.48f,
                    EVEBIT = 12.58f,
                    ROE = 9.99f,
                    ROIC = 4.24f,
                    LC = 1.86f,
                    DBPL = 1.13f,
                    LPA = 0.21f,
                    VPA = 2.09f,
                    DPA = 0.13f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 107.34f,
                    PVPA = 1.55f,
                    PFCO = -17.41f,
                    DY = 3.76f,
                    PSR = 1.44f,
                    EVEBIT = 103.24f,
                    ROE = 1.41f,
                    ROIC = 0.08f,
                    LC = 1.86f,
                    DBPL = 1.07f,
                    LPA = 0.03f,
                    VPA = 2.08f,
                    DPA = 0.13f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 40.38f,
                    PVPA = 1.52f,
                    PFCO = 9.96f,
                    DY = 0.57f,
                    PSR = 1.41f,
                    EVEBIT = 50.27f,
                    ROE = 3.74f,
                    ROIC = 1.64f,
                    LC = 1.74f,
                    DBPL = 1.01f,
                    LPA = 0.08f,
                    VPA = 2.12f,
                    DPA = 0.02f
                }));


            #endregion

            return localList;
        }
    }
}
