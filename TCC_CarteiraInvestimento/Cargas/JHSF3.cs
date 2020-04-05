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
        public static List<Cromossomo> JHSF3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "JHSF3",
                Nome = "JHSF PARTICIPAÇÕES SA.",
                Setor = Setor.ConstrucaoEngenharia
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = -36.00f,
                    PVPA = 0.27f,
                    PFCO = -1.56f,
                    DY = 0.00f,
                    PSR = 4.86f,
                    EVEBIT = 11.11f,
                    ROE = -0.74f,
                    ROIC = 3.23f,
                    LC = 0.86f,
                    DBPL = 0.63f,
                    LPA = -0.03f,
                    VPA = 4.07f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = -56.50f,
                    PVPA = 0.28f,
                    PFCO = -1.58f,
                    DY = 0.00f,
                    PSR = 4.87f,
                    EVEBIT = 13.04f,
                    ROE = -0.48f,
                    ROIC = 2.91f,
                    LC = 0.87f,
                    DBPL = 0.65f,
                    LPA = -0.02f,
                    VPA = 4.06f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 7.23f,
                    PVPA = 0.44f,
                    PFCO = -2.42f,
                    DY = 0.00f,
                    PSR = 5.16f,
                    EVEBIT = 12.44f,
                    ROE = 6.10f,
                    ROIC = 6.59f,
                    LC = 0.76f,
                    DBPL = 0.64f,
                    LPA = 0.26f,
                    VPA = 4.28f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 7.00f,
                    PVPA = 0.57f,
                    PFCO = -11.85f,
                    DY = 0.00f,
                    PSR = 4.83f,
                    EVEBIT = 6.83f,
                    ROE = 8.04f,
                    ROIC = 9.04f,
                    LC = 0.97f,
                    DBPL = 0.53f,
                    LPA = 0.35f,
                    VPA = 4.32f,
                    DPA = 0.12f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -5.49f,
                    PVPA = 0.59f,
                    PFCO = -7.96f,
                    DY = 0.00f,
                    PSR = 6.80f,
                    EVEBIT = -16.44f,
                    ROE = -10.61f,
                    ROIC = -2.80f,
                    LC = 2.22f,
                    DBPL = 0.55f,
                    LPA = -0.45f,
                    VPA = 4.20f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -3.98f,
                    PVPA = 0.50f,
                    PFCO = -8.95f,
                    DY = 0.00f,
                    PSR = 5.95f,
                    EVEBIT = -12.61f,
                    ROE = -12.76f,
                    ROIC = -4.27f,
                    LC = 0.94f,
                    DBPL = 0.59f,
                    LPA = -0.53f,
                    VPA = 4.18f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -3.65f,
                    PVPA = 0.43f,
                    PFCO = -44.19f,
                    DY = 0.00f,
                    PSR = 5.61f,
                    EVEBIT = -12.16f,
                    ROE = -11.64f,
                    ROIC = -4.28f,
                    LC = 1.04f,
                    DBPL = 0.61f,
                    LPA = -0.48f,
                    VPA = 4.11f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.00f,
                    PFCO = 0.00f,
                    DY = 0.00f,
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
