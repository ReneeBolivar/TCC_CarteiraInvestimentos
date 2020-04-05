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
        public static List<Cromossomo> VULC3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "VULC3",
                Nome = "VULCABRAS|AZALEIA S.A.",
                Setor = Setor.TecidosVestuarioCalcados
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 6.02f,
                    PVPA = 1.44f,
                    PFCO = 4.27f,
                    DY = 0.00f,
                    PSR = 0.94f,
                    EVEBIT = 4.83f,
                    ROE = 23.98f,
                    ROIC = 25.30f,
                    LC = 2.46f,
                    DBPL = 0.11f,
                    LPA = 1.06f,
                    VPA = 4.42f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 5.26f,
                    PVPA = 1.10f,
                    PFCO = 3.92f,
                    DY = 0.00f,
                    PSR = 0.76f,
                    EVEBIT = 4.70f,
                    ROE = 20.81f,
                    ROIC = 21.97f,
                    LC = 3.26f,
                    DBPL = 0.01f,
                    LPA = 0.96f,
                    VPA = 4.61f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 8.11f,
                    PVPA = 1.37f,
                    PFCO = 7.84f,
                    DY = 0.00f,
                    PSR = 1.02f,
                    EVEBIT = 7.45f,
                    ROE = 16.89f,
                    ROIC = 17.83f,
                    LC = 3.14f,
                    DBPL = 0.01f,
                    LPA = 0.82f,
                    VPA = 4.84f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 8.23f,
                    PVPA = 1.33f,
                    PFCO = 9.96f,
                    DY = 0.00f,
                    PSR = 1.03f,
                    EVEBIT = 7.77f,
                    ROE = 16.16f,
                    ROIC = 15.81f,
                    LC = 2.91f,
                    DBPL = 0.06f,
                    LPA = 0.82f,
                    VPA = 5.08f,
                    DPA = 0.00f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 13.38f,
                    PVPA = 10.19f,
                    PFCO = 4.36f,
                    DY = 0.00f,
                    PSR = 0.87f,
                    EVEBIT = 8.62f,
                    ROE = 77.23f,
                    ROIC = 26.34f,
                    LC = 1.42f,
                    DBPL = 5.89f,
                    LPA = 0.32f,
                    VPA = 0.42f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 15.76f,
                    PVPA = 13.29f,
                    PFCO = 8.82f,
                    DY = 0.00f,
                    PSR = 2.01f,
                    EVEBIT = 12.64f,
                    ROE = 83.94f,
                    ROIC = 29.16f,
                    LC = 1.48f,
                    DBPL = 3.46f,
                    LPA = 0.59f,
                    VPA = 0.70f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 10.83f,
                    PVPA = 8.67f,
                    PFCO = 6.25f,
                    DY = 0.00f,
                    PSR = 1.88f,
                    EVEBIT = 10.30f,
                    ROE = 79.50f,
                    ROIC = 35.53f,
                    LC = 1.68f,
                    DBPL = 1.79f,
                    LPA = 0.84f,
                    VPA = 1.05f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 10.29f,
                    PVPA = 2.48f,
                    PFCO = 6.49f,
                    DY = 0.00f,
                    PSR = 1.55f,
                    EVEBIT = 8.05f,
                    ROE = 24.08f,
                    ROIC = 27.13f,
                    LC = 2.51f,
                    DBPL = 0.12f,
                    LPA = 1.02f,
                    VPA = 4.24f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }
    }
}
