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
        public static List<Cromossomo> PNVL3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "PNVL3",
                Nome = "DIMED SA DISTRIBUIDORA DE MEDICAMENTOS",
                Setor = Setor.ComercioDistribuicao
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 28.47f,
                    PVPA = 3.82f,
                    PFCO = 58.53f,
                    DY = 0.95f,
                    PSR = 0.78f,
                    EVEBIT = 20.41f,
                    ROE = 13.42f,
                    ROIC = 13.38f,
                    LC = 1.93f,
                    DBPL = 0.33f,
                    LPA = 12.89f,
                    VPA = 96.04f,
                    DPA = 3.61f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 23.79f,
                    PVPA = 3.20f,
                    PFCO = 22.80f,
                    DY = 1.04f,
                    PSR = 0.65f,
                    EVEBIT = 17.74f,
                    ROE = 13.45f,
                    ROIC = 13.16f,
                    LC = 1.72f,
                    DBPL = 0.34f,
                    LPA = 13.03f,
                    VPA = 96.86f,
                    DPA = 3.84f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 21.68f,
                    PVPA = 3.09f,
                    PFCO = 31.27f,
                    DY = 1.26f,
                    PSR = 0.63f,
                    EVEBIT = 16.37f,
                    ROE = 14.26f,
                    ROIC = 13.72f,
                    LC = 1.69f,
                    DBPL = 0.34f,
                    LPA = 14.16f,
                    VPA = 99.30f,
                    DPA = 3.92f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 23.83f,
                    PVPA = 3.85f,
                    PFCO = 16.26f,
                    DY = 1.41f,
                    PSR = 0.76f,
                    EVEBIT = 16.92f,
                    ROE = 16.16f,
                    ROIC = 15.54f,
                    LC = 1.55f,
                    DBPL = 0.30f,
                    LPA = 16.45f,
                    VPA = 101.75f,
                    DPA = 4.39f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 50.32f,
                    PVPA = 7.20f,
                    PFCO = 27.24f,
                    DY = 0.59f,
                    PSR = 1.35f,
                    EVEBIT = 30.38f,
                    ROE = 14.30f,
                    ROIC = 15.46f,
                    LC = 1.68f,
                    DBPL = 0.23f,
                    LPA = 12.40f,
                    VPA = 86.72f,
                    DPA = 6.62f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 38.28f,
                    PVPA = 5.56f,
                    PFCO = 33.10f,
                    DY = 0.65f,
                    PSR = 1.05f,
                    EVEBIT = 23.76f,
                    ROE = 14.51f,
                    ROIC = 15.45f,
                    LC = 1.63f,
                    DBPL = 0.26f,
                    LPA = 12.93f,
                    VPA = 89.09f,
                    DPA = 3.62f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 30.51f,
                    PVPA = 4.40f,
                    PFCO = 23.27f,
                    DY = 0.84f,
                    PSR = 0.83f,
                    EVEBIT = 19.15f,
                    ROE = 14.44f,
                    ROIC = 15.72f,
                    LC = 1.59f,
                    DBPL = 0.23f,
                    LPA = 13.11f,
                    VPA = 90.83f,
                    DPA = 3.79f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 28.73f,
                    PVPA = 4.03f,
                    PFCO = 42.04f,
                    DY = 0.95f,
                    PSR = 0.81f,
                    EVEBIT = 19.36f,
                    ROE = 14.01f,
                    ROIC = 13.63f,
                    LC = 1.75f,
                    DBPL = 0.37f,
                    LPA = 13.12f,
                    VPA = 93.60f,
                    DPA = 3.84f
                }));

            #endregion

            return localList;
        }
    }
}
