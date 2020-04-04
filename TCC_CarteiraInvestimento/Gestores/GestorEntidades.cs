using System;
using System.Collections.Generic;
using TCC_CarteiraInvestimento.Entidades;

namespace TCC_CarteiraInvestimento.Gestores
{
    public static class GestorEntidades
    {
        public static Populacao Populacao { get; set; }
        public static List<Geracao> Geracoes { get; set; }
        public static List<Tuple<Individuo, Individuo>> Casais { get; set; }
        public static List<Cromossomo> CromossomosDisponiveis { get; set; }
    }
}
