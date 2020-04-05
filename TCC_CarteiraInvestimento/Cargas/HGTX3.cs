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
        public static List<Cromossomo> HGTX3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "HGTX3",
                Nome = "CIA HERING.",
                Setor = Setor.TecidosVestuarioCalcados
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.36f,
                    PVPA = 1.96f,
                    PFCO = 9.03f,
                    DY = 8.70f,
                    PSR = 1.54f,
                    EVEBIT = 10.94f,
                    ROE = 21.01f,
                    ROIC = 14.63f,
                    LC = 3.45f,
                    DBPL = 0.02f,
                    LPA = 1.61f,
                    VPA = 7.69f,
                    DPA = 1.33f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 12.51f,
                    PVPA = 2.27f,
                    PFCO = 10.08f,
                    DY = 9.20f,
                    PSR = 1.87f,
                    EVEBIT = 14.18f,
                    ROE = 18.21f,
                    ROIC = 14.23f,
                    LC = 3.60f,
                    DBPL = 0.02f,
                    LPA = 1.42f,
                    VPA = 7.82f,
                    DPA = 1.31f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 20.14f,
                    PVPA = 3.56f,
                    PFCO = 14.26f,
                    DY = 3.89f,
                    PSR = 3.01f,
                    EVEBIT = 23.00f,
                    ROE = 17.62f,
                    ROIC = 14.16f,
                    LC = 3.29f,
                    DBPL = 0.02f,
                    LPA = 1.43f,
                    VPA = 8.10f,
                    DPA = 0.69f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 20.06f,
                    PVPA = 3.65f,
                    PFCO = 13.28f,
                    DY = 3.17f,
                    PSR = 3.13f,
                    EVEBIT = 22.72f,
                    ROE = 18.14f,
                    ROIC = 15.33f,
                    LC = 3.26f,
                    DBPL = 0.00f,
                    LPA = 1.49f,
                    VPA = 8.19f,
                    DPA = 0.93f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 13.93f,
                    PVPA = 2.32f,
                    PFCO = 11.15f,
                    DY = 5.76f,
                    PSR = 1.96f,
                    EVEBIT = 16.95f,
                    ROE = 16.63f,
                    ROIC = 12.35f,
                    LC = 4.19f,
                    DBPL = 0.02f,
                    LPA = 1.29f,
                    VPA = 7.75f,
                    DPA = 0.77f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 13.62f,
                    PVPA = 2.60f,
                    PFCO = 14.06f,
                    DY = 6.31f,
                    PSR = 2.12f,
                    EVEBIT = 17.95f,
                    ROE = 19.09f,
                    ROIC = 12.62f,
                    LC = 3.87f,
                    DBPL = 0.02f,
                    LPA = 1.45f,
                    VPA = 7.61f,
                    DPA = 0.78f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 18.04f,
                    PVPA = 3.48f,
                    PFCO = 19.14f,
                    DY = 6.54f,
                    PSR = 2.70f,
                    EVEBIT = 21.83f,
                    ROE = 19.24f,
                    ROIC = 13.98f,
                    LC = 3.29f,
                    DBPL = 0.02f,
                    LPA = 1.42f,
                    VPA = 7.37f,
                    DPA = 1.40f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.49f,
                    PVPA = 2.89f,
                    PFCO = 14.22f,
                    DY = 6.29f,
                    PSR = 2.28f,
                    EVEBIT = 17.25f,
                    ROE = 21.39f,
                    ROIC = 14.65f,
                    LC = 3.56f,
                    DBPL = 0.02f,
                    LPA = 1.64f,
                    VPA = 7.65f,
                    DPA = 1.15f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 8.81f,
                    PVPA = 1.98f,
                    PFCO = 9.40f,
                    DY = 5.78f,
                    PSR = 1.52f,
                    EVEBIT = 10.68f,
                    ROE = 22.41f,
                    ROIC = 19.38f,
                    LC = 4.40f,
                    DBPL = 0.00f,
                    LPA = 1.67f,
                    VPA = 7.44f,
                    DPA = 0.82f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 8.78f,
                    PVPA = 2.04f,
                    PFCO = 8.01f,
                    DY = 6.20f,
                    PSR = 1.54f,
                    EVEBIT = 11.17f,
                    ROE = 23.11f,
                    ROIC = 19.72f,
                    LC = 3.84f,
                    DBPL = 0.00f,
                    LPA = 1.69f,
                    VPA = 7.29f,
                    DPA = 0.91f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 12.49f,
                    PVPA = 2.34f,
                    PFCO = 9.13f,
                    DY = 4.96f,
                    PSR = 1.87f,
                    EVEBIT = 14.07f,
                    ROE = 18.73f,
                    ROIC = 13.96f,
                    LC = 3.76f,
                    DBPL = 0.00f,
                    LPA = 1.44f,
                    VPA = 7.67f,
                    DPA = 0.91f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 12.19f,
                    PVPA = 2.02f,
                    PFCO = 8.47f,
                    DY = 6.74f,
                    PSR = 1.67f,
                    EVEBIT = 14.98f,
                    ROE = 16.49f,
                    ROIC = 12.35f,
                    LC = 3.66f,
                    DBPL = 0.02f,
                    LPA = 1.24f,
                    VPA = 7.50f,
                    DPA = 0.77f
                }));

            #endregion

            return localList;
        }
    }
}
