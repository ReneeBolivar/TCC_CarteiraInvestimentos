using System.Collections.Generic;

namespace TCC_CarteiraInvestimento.Entidades
{
    public class Individuo
    {
        public Individuo()
        {
            Cromossomos = new List<Cromossomo>();
        }

        public List<Cromossomo> Cromossomos { get; set; }
        public int Peso { get; set; }
    }
}
