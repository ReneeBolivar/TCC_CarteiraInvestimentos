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
        public static List<Cromossomo> ODPV3()
        {
            var localList = new List<Cromossomo>();
            var empresa = new Empresa
            {
                Codigo = "ODPV3",
                Nome = "ODONTOPREV S/A.",
                Setor = Setor.Saude,
                PrecoAtivoNoPeriodo = ObterAtivos_ODPV3()
            };

            #region Compreende todo o ano de 2018

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 1,
                new AnaliseFundamentalista
                {
                    PL = 12.61f,
                    PVPA = 6.79f,
                    PFCO = 19.74f,
                    DY = 3.11f,
                    PSR = 4.46f,
                    EVEBIT = 10.16f,
                    ROE = 53.97f,
                    ROIC = 36.25f,
                    LC = 1.55f,
                    DBPL = 0.00f,
                    LPA = 0.97f,
                    VPA = 1.80f,
                    DPA = 0.47f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 2,
                new AnaliseFundamentalista
                {
                    PL = 21.00f,
                    PVPA = 6.85f,
                    PFCO = 24.63f,
                    DY = 3.02f,
                    PSR = 4.61f,
                    EVEBIT = 16.13f,
                    ROE = 32.67f,
                    ROIC = 24.72f,
                    LC = 1.67f,
                    DBPL = 0.00f,
                    LPA = 0.61f,
                    VPA = 1.87f,
                    DPA = 0.39f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 3,
                new AnaliseFundamentalista
                {
                    PL = 22.39f,
                    PVPA = 7.15f,
                    PFCO = 18.95f,
                    DY = 2.07f,
                    PSR = 4.74f,
                    EVEBIT = 17.30f,
                    ROE = 31.93f,
                    ROIC = 25.03f,
                    LC = 1.21f,
                    DBPL = 0.00f,
                    LPA = 0.61f,
                    VPA = 1.91f,
                    DPA = 0.26f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2018, 4,
                new AnaliseFundamentalista
                {
                    PL = 30.37f,
                    PVPA = 8.45f,
                    PFCO = 26.88f,
                    DY = 2.04f,
                    PSR = 5.47f,
                    EVEBIT = 21.57f,
                    ROE = 27.60f,
                    ROIC = 25.18f,
                    LC = 1.36f,
                    DBPL = 0.00f,
                    LPA = 0.54f,
                    VPA = 1.94f,
                    DPA = 0.31f
                }));

            #endregion

            #region Compreende todo o ano de 2017

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 1,
                new AnaliseFundamentalista
                {
                    PL = 27.56f,
                    PVPA = 8.37f,
                    PFCO = 31.43f,
                    DY = 3.71f,
                    PSR = 4.33f,
                    EVEBIT = 19.65f,
                    ROE = 30.08f,
                    ROIC = 26.44f,
                    LC = 1.86f,
                    DBPL = 0.00f,
                    LPA = 0.41f,
                    VPA = 1.35f,
                    DPA = 0.26f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 2,
                new AnaliseFundamentalista
                {
                    PL = 14.56f,
                    PVPA = 6.73f,
                    PFCO = 33.55f,
                    DY = 2.77f,
                    PSR = 4.41f,
                    EVEBIT = 11.28f,
                    ROE = 46.30f,
                    ROIC = 33.45f,
                    LC = 1.74f,
                    DBPL = 0.00f,
                    LPA = 0.80f,
                    VPA = 1.73f,
                    DPA = 0.26f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 3,
                new AnaliseFundamentalista
                {
                    PL = 18.94f,
                    PVPA = 9.64f,
                    PFCO = 32.40f,
                    DY = 3.05f,
                    PSR = 5.96f,
                    EVEBIT = 15.08f,
                    ROE = 50.93f,
                    ROIC = 36.45f,
                    LC = 1.72f,
                    DBPL = 0.00f,
                    LPA = 0.84f,
                    VPA = 1.65f,
                    DPA = 0.40f
                }));

            localList.Add(GestorCargas.MontarAcao(empresa, 2017, 4,
                new AnaliseFundamentalista
                {
                    PL = 16.32f,
                    PVPA = 8.91f,
                    PFCO = 28.45f,
                    DY = 3.30f,
                    PSR = 5.73f,
                    EVEBIT = 13.54f,
                    ROE = 54.28f,
                    ROIC = 35.97f,
                    LC = 1.47f,
                    DBPL = 0.00f,
                    LPA = 0.95f,
                    VPA = 1.74f,
                    DPA = 0.46f
                }));

            #endregion

            return localList;
        }

        private static List<Tuple<Periodo, decimal>> ObterAtivos_ODPV3()
        {
            var ativos = new List<Tuple<Periodo, decimal>>();

            #region 2019

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2019, Trimestre = 1 }, 15.66m));

            #endregion

            #region 2018

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 1 }, 14.03m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 2 }, 12.32m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 3 }, 12.1m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2018, Trimestre = 4 }, 13.12m));

            #endregion

            #region 2017

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 1 }, 10.19m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 2 }, 10.65m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 3 }, 14.36m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2017, Trimestre = 4 }, 14.91m));

            #endregion

            #region 2016

            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 1 }, 9.97m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 2 }, 11.83m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 3 }, 11.56m));
            ativos.Add(new Tuple<Periodo, decimal>(new Periodo { Ano = 2016, Trimestre = 4 }, 11.32m));

            #endregion

            return null;
        }
    }
}
