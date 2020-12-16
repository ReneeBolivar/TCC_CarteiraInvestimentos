using System;
using System.Collections.Generic;
using System.Text;
using TCC_CarteiraInvestimento.Cargas;
using TCC_CarteiraInvestimento.Entidades;

namespace TCC_CarteiraInvestimento.Gestores
{
    public static class GestorCargas
    {
        public static List<Cromossomo> Cromossomos;

        static GestorCargas()
        {
            Cromossomos = new List<Cromossomo>();

            InicializarCarga();
        }

        private static void InicializarCarga()
        {
            Cromossomos.AddRange(Carga.ABCB4());
            Cromossomos.AddRange(Carga.BGIP4());
            Cromossomos.AddRange(Carga.BRAP3());
            Cromossomos.AddRange(Carga.BRSR6());
            Cromossomos.AddRange(Carga.BSLI3());
            Cromossomos.AddRange(Carga.CEDO3());
            Cromossomos.AddRange(Carga.CGAS5());
            Cromossomos.AddRange(Carga.CMIG3());
            Cromossomos.AddRange(Carga.CRPG5());
            Cromossomos.AddRange(Carga.CTSA3());
            Cromossomos.AddRange(Carga.EKTR4());
            Cromossomos.AddRange(Carga.ENBR3());
            Cromossomos.AddRange(Carga.EQTL3());
            Cromossomos.AddRange(Carga.TESA4());
            Cromossomos.AddRange(Carga.LCAM3());
            Cromossomos.AddRange(Carga.MRFG3());
            Cromossomos.AddRange(Carga.MYPK3());
            Cromossomos.AddRange(Carga.SAPR4());
            Cromossomos.AddRange(Carga.TAEE11());
            Cromossomos.AddRange(Carga.TIET11());
            Cromossomos.AddRange(Carga.TRPN3());
            Cromossomos.AddRange(Carga.CIEL3());
            Cromossomos.AddRange(Carga.FIBR3());
            Cromossomos.AddRange(Carga.ELET3());
            Cromossomos.AddRange(Carga.BRML3());
            Cromossomos.AddRange(Carga.CRIV4());
            Cromossomos.AddRange(Carga.LITG3());
            Cromossomos.AddRange(Carga.UNIP6());
            Cromossomos.AddRange(Carga.CGRA3());
            Cromossomos.AddRange(Carga.VLID3());
            Cromossomos.AddRange(Carga.WHRL3());
            Cromossomos.AddRange(Carga.BBDC3());
            Cromossomos.AddRange(Carga.BRDT3());
            Cromossomos.AddRange(Carga.BBAS3());
            Cromossomos.AddRange(Carga.ELEK4());
            Cromossomos.AddRange(Carga.MGLU3());
            Cromossomos.AddRange(Carga.GUAR3());
            Cromossomos.AddRange(Carga.GEPA3());
            Cromossomos.AddRange(Carga.SGPS3());
            Cromossomos.AddRange(Carga.BEES3());
            Cromossomos.AddRange(Carga.BBSE3());
            Cromossomos.AddRange(Carga.ALUP11());
            Cromossomos.AddRange(Carga.ABEV3());
            Cromossomos.AddRange(Carga.GOAU4());
            Cromossomos.AddRange(Carga.HYPE3());
            Cromossomos.AddRange(Carga.YDUQ3());
            Cromossomos.AddRange(Carga.TKNO4());
            Cromossomos.AddRange(Carga.NAFG3());
            Cromossomos.AddRange(Carga.HGTX3());
            Cromossomos.AddRange(Carga.QUAL3());
            Cromossomos.AddRange(Carga.SEER3());
            Cromossomos.AddRange(Carga.TIMP3());
            Cromossomos.AddRange(Carga.IDNT3());
            Cromossomos.AddRange(Carga.JHSF3());
            Cromossomos.AddRange(Carga.ODPV3());
            Cromossomos.AddRange(Carga.RAPT4());
            Cromossomos.AddRange(Carga.UGPA3());
            Cromossomos.AddRange(Carga.VULC3());
            Cromossomos.AddRange(Carga.CBEE3());
            Cromossomos.AddRange(Carga.TUPY3());
            Cromossomos.AddRange(Carga.ITUB3());
            Cromossomos.AddRange(Carga.GGBR3());
            Cromossomos.AddRange(Carga.SULA11());
            Cromossomos.AddRange(Carga.MOVI3());
            Cromossomos.AddRange(Carga.FLRY3());
            Cromossomos.AddRange(Carga.ARZZ3());
            Cromossomos.AddRange(Carga.POMO3());
            Cromossomos.AddRange(Carga.JBSS3());
            Cromossomos.AddRange(Carga.COGN3());
            Cromossomos.AddRange(Carga.DTEX3());
            Cromossomos.AddRange(Carga.VIVT4());
            Cromossomos.AddRange(Carga.IGTA3());
            Cromossomos.AddRange(Carga.SSBR3());
            Cromossomos.AddRange(Carga.B3SA3());
            Cromossomos.AddRange(Carga.HAPV3());
            Cromossomos.AddRange(Carga.PNVL3());
            Cromossomos.AddRange(Carga.RENT3());
            Cromossomos.AddRange(Carga.RADL3());
            Cromossomos.AddRange(Carga.WEGE3());
        }

        public static Cromossomo MontarAcao(Empresa empresa, int ano, int trimestre, AnaliseFundamentalista analiseFundamentalista)
        {
            var periodo = new Periodo
            {
                Ano = ano,
                Trimestre = trimestre
            };
            var cromossomo = new Cromossomo
            {
                Periodo = periodo,
                Empresa = empresa,
                AnaliseFundamentalista = analiseFundamentalista
            };

            return cromossomo;
        }
    }
}
