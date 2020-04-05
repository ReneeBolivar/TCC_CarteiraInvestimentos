using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;

namespace TCC_CarteiraInvestimento.Gestores
{
    public static class GestorEntidades
    {
        static GestorEntidades()
        {
            if (Geracoes == null) Geracoes = new List<Geracao>();
            if (ParesParaCruzamento == null) ParesParaCruzamento = new List<Tuple<Individuo, Individuo>>();
        }

        public static Populacao Populacao { get; set; }
        public static List<Geracao> Geracoes { get; set; }
        public static List<Cromossomo> CromossomosDisponiveis { get; set; }
        public static List<Tuple<Individuo, Individuo>> ParesParaCruzamento { get; set; }
    }
}
