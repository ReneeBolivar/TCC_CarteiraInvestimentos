using System.Collections.Generic;

namespace TCC_CarteiraInvestimento.Entidades
{
    public class Populacao
    {
        public Populacao()
        {
            Individuos = new List<Individuo>();
        }

        public List<Individuo> Individuos { get; set; }
    }
}
