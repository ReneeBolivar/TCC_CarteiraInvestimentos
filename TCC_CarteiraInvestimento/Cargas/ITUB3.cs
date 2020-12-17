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
        public static List<Cromossomo> ITUB3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "ITUB3",
                Nome = "ITAÚ UNIBANCO HOLDING S.A.",
                Setor = Setor.Financeiros,
                PrecoAtivoNoPeriodo = ObterAtivos_ITUB3()
            };

            #region 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.68f,
                    PVPA = 1.69f,
                    PFCO = -20.19f,
                    DY = 6.77f,
                    PSR = 35.71f,
                    EVEBIT = null,
                    ROE = 17.42f,
                    ROIC = null,
                    LC = 0.63f,
                    DBPL = null,
                    LPA = 3.49f,
                    VPA = 20.01f,
                    DPA = 3.34f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 11.12f,
                    PVPA = 1.84f,
                    PFCO = 19.20f,
                    DY = 8.39f,
                    PSR = 26.26f,
                    EVEBIT = null,
                    ROE = 16.56f,
                    ROIC = null,
                    LC = 0.50f,
                    DBPL = null,
                    LPA = 3.39f,
                    VPA = 20.49f,
                    DPA = 3.63f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 18.66f,
                    PVPA = 2.95f,
                    PFCO = -49.56f,
                    DY = 8.80f,
                    PSR = 36.36f,
                    EVEBIT = null,
                    ROE = 15.76f,
                    ROIC = null,
                    LC = 0.54f,
                    DBPL = null,
                    LPA = 2.02f,
                    VPA = 12.80f,
                    DPA = 2.29f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 13.33f,
                    PVPA = 2.22f,
                    PFCO = 41.03f,
                    DY = 10.64f,
                    PSR = 34.72f,
                    EVEBIT = null,
                    ROE = 16.64f,
                    ROIC = null,
                    LC = 1.02f,
                    DBPL = null,
                    LPA = 2.24f,
                    VPA = 13.45f,
                    DPA = 2.13f
                }));

            #endregion

            #region 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 9.90f,
                    PVPA = 1.72f,
                    PFCO = 102.17f,
                    DY = 5.29f,
                    PSR = 67.89f,
                    EVEBIT = null,
                    ROE = 17.33f,
                    ROIC = null,
                    LC = 0.30f,
                    DBPL = null,
                    LPA = 3.41f,
                    VPA = 19.65f,
                    DPA = 1.16f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 9.43f,
                    PVPA = 1.61f,
                    PFCO = 18.74f,
                    DY = 5.60f,
                    PSR = 40.38f,
                    EVEBIT = null,
                    ROE = 17.12f,
                    ROIC = null,
                    LC = 0.67f,
                    DBPL = null,
                    LPA = 3.45f,
                    VPA = 20.17f,
                    DPA = 1.17f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 10.47f,
                    PVPA = 1.80f,
                    PFCO = 21.10f,
                    DY = 4.75f,
                    PSR = 56.21f,
                    EVEBIT = null,
                    ROE = 17.17f,
                    ROIC = null,
                    LC = 0.94f,
                    DBPL = null,
                    LPA = 3.60f,
                    VPA = 20.99f,
                    DPA = 1.21f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 12.63f,
                    PVPA = 2.08f,
                    PFCO = -24.45f,
                    DY = 3.98f,
                    PSR = 49.99f,
                    EVEBIT = null,
                    ROE = 16.43f,
                    ROIC = null,
                    LC = 1.06f,
                    DBPL = null,
                    LPA = 3.53f,
                    VPA = 21.48f,
                    DPA = 3.21f
                }));

            #endregion

            return localList;
        }
        private static List<Tuple<Periodo, decimal>> ObterAtivos_ITUB3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 27.56m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 25.7m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 20.5m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 21.9m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 26.31m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 18.02m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 17.4m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 20.74m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 20.47m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 12.29m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 11.99m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 14.61m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 15.72m));

            #endregion

            return null;
        }

    }
}
