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
        public static List<Cromossomo> DTEX3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "DTEX3",
                Nome = "DURATEX S.A.",
                Setor = Setor.MadeiraPapel
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 24.88f,
                    PVPA = 1.15f,
                    PFCO = 16.22f,
                    DY = 0.74f,
                    PSR = 1.90f,
                    EVEBIT = 16.94f,
                    ROE = 4.68f,
                    ROIC = 5.26f,
                    LC = 1.98f,
                    DBPL = 0.63f,
                    LPA = 0.32f,
                    VPA = 6.90f,
                    DPA = 0.09f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 17.04f,
                    PVPA = 1.25f,
                    PFCO = 17.53f,
                    DY = 1.01f,
                    PSR = 2.05f,
                    EVEBIT = 12.67f,
                    ROE = 7.30f,
                    ROIC = 6.78f,
                    LC = 2.86f,
                    DBPL = 0.60f,
                    LPA = 0.53f,
                    VPA = 7.22f,
                    DPA = 0.09f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.21f,
                    PVPA = 1.49f,
                    PFCO = 26.48f,
                    DY = 0.98f,
                    PSR = 2.15f,
                    EVEBIT = 9.02f,
                    ROE = 12.21f,
                    ROIC = 9.93f,
                    LC = 2.51f,
                    DBPL = 0.55f,
                    LPA = 0.95f,
                    VPA = 7.79f,
                    DPA = 0.09f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 17.69f,
                    PVPA = 1.64f,
                    PFCO = 19.82f,
                    DY = 6.70f,
                    PSR = 1.97f,
                    EVEBIT = 12.68f,
                    ROE = 9.31f,
                    ROIC = 7.76f,
                    LC = 1.76f,
                    DBPL = 0.62f,
                    LPA = 0.62f,
                    VPA = 6.70f,
                    DPA = 0.41f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 131.42f,
                    PVPA = 1.39f,
                    PFCO = 11.79f,
                    DY = 0.09f,
                    PSR = 2.27f,
                    EVEBIT = 24.29f,
                    ROE = 1.03f,
                    ROIC = 4.37f,
                    LC = 2.59f,
                    DBPL = 0.71f,
                    LPA = 0.07f,
                    VPA = 6.60f,
                    DPA = 0.01f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 81.70f,
                    PVPA = 1.23f,
                    PFCO = 16.33f,
                    DY = 0.11f,
                    PSR = 2.10f,
                    EVEBIT = 21.81f,
                    ROE = 1.57f,
                    ROIC = 4.47f,
                    LC = 2.30f,
                    DBPL = 0.68f,
                    LPA = 0.10f,
                    VPA = 6.65f,
                    DPA = 0.01f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 51.11f,
                    PVPA = 1.36f,
                    PFCO = 13.55f,
                    DY = 0.09f,
                    PSR = 2.19f,
                    EVEBIT = 21.49f,
                    ROE = 2.68f,
                    ROIC = 4.62f,
                    LC = 2.08f,
                    DBPL = 0.65f,
                    LPA = 0.18f,
                    VPA = 6.76f,
                    DPA = 0.01f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 40.70f,
                    PVPA = 1.61f,
                    PFCO = 18.79f,
                    DY = 1.05f,
                    PSR = 2.51f,
                    EVEBIT = 23.03f,
                    ROE = 3.92f,
                    ROIC = 4.96f,
                    LC = 1.95f,
                    DBPL = 0.67f,
                    LPA = 0.27f,
                    VPA = 6.82f,
                    DPA = 0.09f
                }));

            #endregion

            return localList;
        }
    }
}
