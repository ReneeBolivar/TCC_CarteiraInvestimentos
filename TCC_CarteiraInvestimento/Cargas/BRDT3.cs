using System;
using System.Collections.Generic;
using System.Text;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> BRDT3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "BRDT3",
                Nome = "PETROBRAS DISTRIBUIDORA SA.",
                Setor = Setor.PetroleoGasBiocombustiveis,
                PrecoAtivoNoPeriodo = ObterAtivos_BRDT3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 21.58f,
                    PVPA = 3.16f,
                    PFCO = 23.17f,
                    DY = 2.45f,
                    PSR = 0.36f,
                    EVEBIT = 14.14f,
                    ROE = 14.59f,
                    ROIC = 12.89f,
                    LC = 2.41f,
                    DBPL = 0.55f,
                    LPA = 1.07f,
                    VPA = 7.30f,
                    DPA = 0.23f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 14.87f,
                    PVPA = 2.55f,
                    PFCO = 13.66f,
                    DY = 5.17f,
                    PSR = 0.28f,
                    EVEBIT = 11.70f,
                    ROE = 17.21f,
                    ROIC = 11.85f,
                    LC = 2.36f,
                    DBPL = 0.55f,
                    LPA = 1.23f,
                    VPA = 7.16f,
                    DPA = 0.23f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 10.71f,
                    PVPA = 2.41f,
                    PFCO = 10.96f,
                    DY = 4.85f,
                    PSR = 0.29f,
                    EVEBIT = 9.99f,
                    ROE = 22.50f,
                    ROIC = 10.85f,
                    LC = 2.95f,
                    DBPL = 0.60f,
                    LPA = 1.82f,
                    VPA = 8.08f,
                    DPA = 0.23f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 9.38f,
                    PVPA = 3.09f,
                    PFCO = 9.00f,
                    DY = 5.56f,
                    PSR = 0.36f,
                    EVEBIT = 13.60f,
                    ROE = 32.97f,
                    ROIC = 5.05f,
                    LC = 2.81f,
                    DBPL = 0.58f,
                    LPA = 2.74f,
                    VPA = 8.31f,
                    DPA = 0.72f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -297.43f,
                    PVPA = 6.42f,
                    PFCO = 14.39f,
                    DY = 0.00f,
                    PSR = 0.57f,
                    EVEBIT = 148.99f,
                    ROE = -2.10f,
                    ROIC = 2.97f,
                    LC = 2.32f,
                    DBPL = 1.72f,
                    LPA = -0.14f,
                    VPA = 6.49f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -520.50f,
                    PVPA = 6.36f,
                    PFCO = 14.50f,
                    DY = 0.00f,
                    PSR = 0.47f,
                    EVEBIT = 94.47f,
                    ROE = -1.17f,
                    ROIC = 3.86f,
                    LC = 2.33f,
                    DBPL = 1.61f,
                    LPA = -0.08f,
                    VPA = 6.55f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 160.15f,
                    PVPA = 6.06f,
                    PFCO = 15.88f,
                    DY = 0.00f,
                    PSR = 0.36f,
                    EVEBIT = 35.91f,
                    ROE = 3.81f,
                    ROIC = 10.87f,
                    LC = 2.32f,
                    DBPL = 0.60f,
                    LPA = 0.26f,
                    VPA = 6.87f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 17.27f,
                    PVPA = 2.26f,
                    PFCO = 15.69f,
                    DY = 0.00f,
                    PSR = 0.29f,
                    EVEBIT = 11.38f,
                    ROE = 13.04f,
                    ROIC = 12.62f,
                    LC = 2.43f,
                    DBPL = 0.53f,
                    LPA = 0.99f,
                    VPA = 7.58f,
                    DPA = 0.23f
                }));

            #endregion

            #region Compreende todo o ano de 2016

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 1,
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

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 2,
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

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 3,
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

            localList.Add(GestorCargas.MontarAcao(empresa, 2016, 4,
                new AnaliseFundamentalista
                {
                    PL = -154.22f,
                    PVPA = 6.55f,
                    PFCO = 18.43f,
                    DY = 0.00f,
                    PSR = 0.70f,
                    EVEBIT = -4050.97f,
                    ROE = -4.25f,
                    ROIC = 1.51f,
                    LC = 2.18f,
                    DBPL = 1.74f,
                    LPA = -0.27f,
                    VPA = 6.36f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_BRDT3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 20.27m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 19.52m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 15.74m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 16.78m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 22.50m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 14.13m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 0m));

            #endregion

            return null;
        }
    }
}
