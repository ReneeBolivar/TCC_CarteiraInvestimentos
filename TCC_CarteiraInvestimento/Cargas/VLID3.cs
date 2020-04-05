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
        public static List<Cromossomo> VLID3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "VLID3",
                Nome = "VALID SOLUÇÕES E SERVIÇOS DE SEGURANÇA EM MEIOS DE PAGAMENTO E IDENTIFICAÇÃO S.A.",
                Setor = Setor.Servicos
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 28.43f,
                    PVPA = 1.13f,
                    PFCO = 8.07f,
                    DY = 2.02f,
                    PSR = 1.04f,
                    EVEBIT = 13.17f,
                    ROE = 3.98f,
                    ROIC = 3.99f,
                    LC = 1.95f,
                    DBPL = 0.81f,
                    LPA = 0.61f,
                    VPA = 15.41f,
                    DPA = 0.38f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 16.34f,
                    PVPA = 0.76f,
                    PFCO = 3.48f,
                    DY = 2.11f,
                    PSR = 0.92f,
                    EVEBIT = 9.95f,
                    ROE = 4.67f,
                    ROIC = 3.85f,
                    LC = 1.90f,
                    DBPL = 0.99f,
                    LPA = 0.77f,
                    VPA = 16.56f,
                    DPA = 0.38f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 19.06f,
                    PVPA = 1.01f,
                    PFCO = 4.75f,
                    DY = 4.65f,
                    PSR = 1.05f,
                    EVEBIT = 10.80f,
                    ROE = 5.27f,
                    ROIC = 4.87f,
                    LC = 2.25f,
                    DBPL = 0.79f,
                    LPA = 0.90f,
                    VPA = 17.00f,
                    DPA = 0.38f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 12.44f,
                    PVPA = 1.15f,
                    PFCO = 6.22f,
                    DY = 5.41f,
                    PSR = 1.08f,
                    EVEBIT = 11.58f,
                    ROE = 9.19f,
                    ROIC = 6.58f,
                    LC = 2.07f,
                    DBPL = 0.76f,
                    LPA = 1.55f,
                    VPA = 16.81f,
                    DPA = 0.90f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 17.38f,
                    PVPA = 1.49f,
                    PFCO = 7.81f,
                    DY = 5.18f,
                    PSR = 1.17f,
                    EVEBIT = 22.39f,
                    ROE = 8.54f,
                    ROIC = 5.20f,
                    LC = 1.71f,
                    DBPL = 0.79f,
                    LPA = 1.30f,
                    VPA = 15.20f,
                    DPA = 0.87f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 13.47f,
                    PVPA = 1.20f,
                    PFCO = 10.14f,
                    DY = 5.86f,
                    PSR = 1.14f,
                    EVEBIT = 16.99f,
                    ROE = 8.89f,
                    ROIC = 5.57f,
                    LC = 2.26f,
                    DBPL = 0.83f,
                    LPA = 1.37f,
                    VPA = 15.40f,
                    DPA = 0.87f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 22.07f,
                    PVPA = 1.22f,
                    PFCO = 13.69f,
                    DY = 3.13f,
                    PSR = 1.14f,
                    EVEBIT = 8.71f,
                    ROE = 5.54f,
                    ROIC = 4.58f,
                    LC = 2.12f,
                    DBPL = 0.83f,
                    LPA = 0.84f,
                    VPA = 15.20f,
                    DPA = 0.64f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 43.81f,
                    PVPA = 1.23f,
                    PFCO = 14.89f,
                    DY = 1.98f,
                    PSR = 1.12f,
                    EVEBIT = 18.26f,
                    ROE = 2.79f,
                    ROIC = 3.18f,
                    LC = 1.92f,
                    DBPL = 0.81f,
                    LPA = 0.43f,
                    VPA = 15.30f,
                    DPA = 0.38f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
                new AnaliseFundamentalista
                {
                    PL = 17.78f,
                    PVPA = 1.86f,
                    PFCO = 9.19f,
                    DY = 3.31f,
                    PSR = 1.45f,
                    EVEBIT = 13.30f,
                    ROE = 10.45f,
                    ROIC = 8.40f,
                    LC = 2.02f,
                    DBPL = 0.69f,
                    LPA = 1.69f,
                    VPA = 16.14f,
                    DPA = 1.05f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
                new AnaliseFundamentalista
                {
                    PL = 22.92f,
                    PVPA = 1.85f,
                    PFCO = 8.42f,
                    DY = 2.94f,
                    PSR = 1.17f,
                    EVEBIT = 16.15f,
                    ROE = 8.05f,
                    ROIC = 7.15f,
                    LC = 1.31f,
                    DBPL = 0.64f,
                    LPA = 1.20f,
                    VPA = 14.87f,
                    DPA = 0.82f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
                new AnaliseFundamentalista
                {
                    PL = 23.45f,
                    PVPA = 1.96f,
                    PFCO = 10.34f,
                    DY = 3.27f,
                    PSR = 1.42f,
                    EVEBIT = 18.90f,
                    ROE = 8.34f,
                    ROIC = 6.60f,
                    LC = 1.72f,
                    DBPL = 0.85f,
                    LPA = 1.30f,
                    VPA = 15.54f,
                    DPA = 1.01f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = 18.11f,
                    PVPA = 1.61f,
                    PFCO = 7.15f,
                    DY = 4.69f,
                    PSR = 1.20f,
                    EVEBIT = 7.63f,
                    ROE = 8.90f,
                    ROIC = 6.27f,
                    LC = 1.66f,
                    DBPL = 0.81f,
                    LPA = 1.36f,
                    VPA = 15.32f,
                    DPA = 0.87f
                }));

            #endregion


            return localList;
        }
    }
}
