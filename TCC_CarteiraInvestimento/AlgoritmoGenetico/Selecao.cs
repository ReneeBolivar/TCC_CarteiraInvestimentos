using System;
using System.Collections.Generic;
using System.Linq;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;
using TCC_CarteiraInvestimento.Utils;

namespace TCC_CarteiraInvestimento.AlgoritmoGenetico
{
    public static partial class AG
    {
        public static void SelecionarIndividuos()
        {
            var nobres = Elitismo(GestorEntidades.Populacao.Individuos);
            var plebeus = PodarPlebeus(Dizimacao(GestorEntidades.Populacao.Individuos));

            var qtdeParesNecessarios = (int)Math.Floor((decimal)((GestorConfiguracao.IndividuosNaPopulacao - GestorConfiguracao.Elitismo) / 2));
            Torneio(plebeus, qtdeParesNecessarios);

            GestorEntidades.Populacao.Individuos.Clear();
            GestorEntidades.Populacao.Individuos.AddRange(nobres);
        }

        private static List<Individuo> Elitismo(List<Individuo> populacao)
        {
            var individuosSelecionados = populacao.OrderByDescending(x => x.Peso)
                                                  .ToList();

            return individuosSelecionados.Take(GestorConfiguracao.Elitismo).ToList();
        }

        private static List<Individuo> Dizimacao(List<Individuo> populacao)
        {
            var individuosSelecionados = populacao.OrderBy(x => x.Peso)
                                                  .ToList();

            for (int i = 0; i < GestorConfiguracao.Dizimacao; i++)
                individuosSelecionados.RemoveAt(0);

            return individuosSelecionados;
        }

        private static List<Individuo> PodarPlebeus(List<Individuo> populacao)
        {
            var individuosSelecionados = populacao.OrderByDescending(x => x.Peso)
                                                  .ToList();

            for (int i = 0; i < GestorConfiguracao.Elitismo; i++)
                individuosSelecionados.RemoveAt(0);

            return individuosSelecionados;
        }

        public static void Torneio(List<Individuo> populacao, int qtdePares)
        {
            var pares = new List<Tuple<Individuo, Individuo>>();

            while (pares.Count() < qtdePares)
            {
                var par = new List<Individuo>();

                for (int i = 0; i < 2; i++)
                {
                    var individuosEscolhidos = new List<Individuo>();

                    // Preenche a lista local com individuos aleatórios
                    for (int j = 0; j < 3; j++)
                    {
                        var rand = Utilitario.ObterNumeroRandom(0, populacao.Count - 1);
                        individuosEscolhidos.Add(populacao.ElementAt(rand));
                    }

                    par.Add(individuosEscolhidos.OrderByDescending(x => x.Peso).First());
                    individuosEscolhidos.Clear(); 
                }

                if (par.ElementAt(0).AreEquals(par.ElementAt(1)))
                    continue;

                pares.Add(new Tuple<Individuo, Individuo>(par.ElementAt(0), par.ElementAt(1))); 
            }

            GestorEntidades.ParesParaCruzamento.Clear();
            GestorEntidades.ParesParaCruzamento.AddRange(pares);
        }
    }
}
