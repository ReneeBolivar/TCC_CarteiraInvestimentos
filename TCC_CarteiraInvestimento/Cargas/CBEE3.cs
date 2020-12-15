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
        public static List<Cromossomo> CBEE3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "CBEE3",
                Nome = "AMPLA ENERGIA E SERVIÇOS S.A.",
                Setor = Setor.EnergiaEletrica,
                PrecoAtivoNoPeriodo = ObterAtivos_CBEE3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 0.00f,
                    PVPA = 0.62f,
                    PFCO = 8.87f,
                    DY = 0.00f,
                    PSR = 0.80f,
                    EVEBIT = 13.23f,
                    ROE = -0.01f,
                    ROIC = 5.33f,
                    LC = 0.86f,
                    DBPL = 1.06f,
                    LPA = 0.00f,
                    VPA = 34.49f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 16.60f,
                    PVPA = 0.58f,
                    PFCO = 4.69f,
                    DY = 0.00f,
                    PSR = 0.85f,
                    EVEBIT = 10.33f,
                    ROE = 3.47f,
                    ROIC = 5.89f,
                    LC = 1.01f,
                    DBPL = 1.07f,
                    LPA = 1.21f,
                    VPA = 34.75f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 11.26f,
                    PVPA = 0.74f,
                    PFCO = 4.93f,
                    DY = 0.00f,
                    PSR = 0.92f,
                    EVEBIT = 9.37f,
                    ROE = 6.60f,
                    ROIC = 6.89f,
                    LC = 0.97f,
                    DBPL = 1.07f,
                    LPA = 2.30f,
                    VPA = 34.91f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.09f,
                    PVPA = 0.64f,
                    PFCO = 4.48f,
                    DY = 0.00f,
                    PSR = 0.75f,
                    EVEBIT = 8.86f,
                    ROE = 4.90f,
                    ROIC = 7.36f,
                    LC = 0.65f,
                    DBPL = 1.03f,
                    LPA = 1.75f,
                    VPA = 35.65f,
                    DPA = 0.41f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = -15.86f,
                    PVPA = 2.06f,
                    PFCO = 5.00f,
                    DY = 0.00f,
                    PSR = 1.54f,
                    EVEBIT = 63.81f,
                    ROE = -12.99f,
                    ROIC = 4.48f,
                    LC = 0.82f,
                    DBPL = 1.47f,
                    LPA = -2.90f,
                    VPA = 22.34f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = -17.11f,
                    PVPA = 2.12f,
                    PFCO = 5.69f,
                    DY = 0.00f,
                    PSR = 1.41f,
                    EVEBIT = 39.17f,
                    ROE = -12.39f,
                    ROIC = 5.70f,
                    LC = 0.61f,
                    DBPL = 1.61f,
                    LPA = -2.66f,
                    VPA = 21.45f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = -9.15f,
                    PVPA = 1.25f,
                    PFCO = 4.17f,
                    DY = 0.00f,
                    PSR = 0.98f,
                    EVEBIT = 28.66f,
                    ROE = -13.67f,
                    ROIC = 5.91f,
                    LC = 0.55f,
                    DBPL = 1.89f,
                    LPA = -2.82f,
                    VPA = 20.62f,
                    DPA = 0.00f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = -21.73f,
                    PVPA = 0.67f,
                    PFCO = 4.38f,
                    DY = 0.00f,
                    PSR = 0.80f,
                    EVEBIT = 14.34f,
                    ROE = -3.07f,
                    ROIC = 6.00f,
                    LC = 0.80f,
                    DBPL = 0.92f,
                    LPA = -1.05f,
                    VPA = 34.23f,
                    DPA = 0.00f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_CBEE3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 22.9m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 22.82m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 21.6m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 20.09m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 25.9m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 34.95m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 34.57m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 25.8m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 0m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 27.56m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 24.31m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 32.67m));

            #endregion

            return null;
        }
    }
}
