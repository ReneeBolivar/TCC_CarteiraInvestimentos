using System;
using System.Collections.Generic;
using System.Text;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;

namespace TCC_CarteiraInvestimento.Cargas
{
    public static partial class Carga
    {
        public static List<Cromossomo> ARZZ3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "ARZZ3",
                Nome = "AREZZO INDÚSTRIA E COMERSA S/A.",
                Setor = Setor.Comercio,
                PrecoAtivoNoPeriodo = ObterAtivos_ARZZ3()
            };

            #region 2018

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 22.07f,
                    PVPA = 5.08f,
                    PFCO = 23.38f,
                    DY = 4.07f,
                    PSR = 2.53f,
                    EVEBIT = 18.96f,
                    ROE = 23.08f,
                    ROIC = 17.85f,
                    LC = 2.46f,
                    DBPL = 0.25f,
                    LPA = 1.79f,
                    VPA = 7.77f,
                    DPA = 0.92f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 24.77f,
                    PVPA = 5.67f,
                    PFCO = 27.72f,
                    DY = 4.48f,
                    PSR = 2.66f,
                    EVEBIT = 20.46f,
                    ROE = 22.82f,
                    ROIC = 19.55f,
                    LC = 2.34f,
                    DBPL = 0.26f,
                    LPA = 1.73f,
                    VPA = 7.56f,
                    DPA = 0.92f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 30.86f,
                    PVPA = 6.72f,
                    PFCO = 36.36f,
                    DY = 2.36f,
                    PSR = 3.25f,
                    EVEBIT = 25.38f,
                    ROE = 21.84f,
                    ROIC = 19.92f,
                    LC = 2.38f,
                    DBPL = 0.24f,
                    LPA = 1.75f,
                    VPA = 8.03f,
                    DPA = 0.50f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 31.04f,
                    PVPA = 6.24f,
                    PFCO = 37.68f,
                    DY = 2.33f,
                    PSR = 2.95f,
                    EVEBIT = 22.56f,
                    ROE = 20.05f,
                    ROIC = 19.92f,
                    LC = 3.29f,
                    DBPL = 0.16f,
                    LPA = 1.61f,
                    VPA = 8.01f,
                    DPA = 0.72f
                }));

            #endregion

            #region 2017

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 22.58f,
                    PVPA = 4.02f,
                    PFCO = 21.20f,
                    DY = 2.67f,
                    PSR = 2.20f,
                    EVEBIT = 16.14f,
                    ROE = 17.83f,
                    ROIC = 14.71f,
                    LC = 3.19f,
                    DBPL = 0.14f,
                    LPA = 1.39f,
                    VPA = 7.81f,
                    DPA = 1.22f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 21.95f,
                    PVPA = 4.28f,
                    PFCO = 17.46f,
                    DY = 3.79f,
                    PSR = 2.23f,
                    EVEBIT = 15.95f,
                    ROE = 19.55f,
                    ROIC = 15.22f,
                    LC = 2.99f,
                    DBPL = 0.16f,
                    LPA = 1.49f,
                    VPA = 7.64f,
                    DPA = 1.22f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 35.99f,
                    PVPA = 7.72f,
                    PFCO = 27.99f,
                    DY = 4.15f,
                    PSR = 3.65f,
                    EVEBIT = 26.82f,
                    ROE = 21.41f,
                    ROIC = 17.11f,
                    LC = 2.82f,
                    DBPL = 0.15f,
                    LPA = 1.52f,
                    VPA = 7.09f,
                    DPA = 1.50f
                }));

            localList.Add(Gestores.GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 28.83f,
                    PVPA = 6.70f,
                    PFCO = 25.63f,
                    DY = 3.76f,
                    PSR = 3.29f,
                    EVEBIT = 24.76f,
                    ROE = 23.23f,
                    ROIC = 17.15f,
                    LC = 2.40f,
                    DBPL = 0.27f,
                    LPA = 1.74f,
                    VPA = 7.49f,
                    DPA = 0.92f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_ARZZ3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 48.93M));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 47.44m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 42.37m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 40.90m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 53.08m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 27.90m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 29.63m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 46.75m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 51.34m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 20.14m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 23.49m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 23.08m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 22.28m));

            #endregion

            return ativos;
        }
    }
}
