using System.Collections.Generic;
using System.Linq;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;
using TCC_CarteiraInvestimento.Utils;
using Bogus;

namespace TCC_CarteiraInvestimento.AlgoritmoGenetico
{
    public static partial class AG
    {
        public static void CruzarIndividuos()
        {
            foreach (var par in GestorEntidades.ParesParaCruzamento)
            {
                Individuo primeiroFilho;
                Individuo segundoFilho;

                var primeiroPai = par.Item1.Cromossomos;
                var segundPai = par.Item2.Cromossomos;

                var preso = 0;
                do
                {
                    preso++;
                    if(preso == 15)
                    {
                        //swap
                        var aux = segundPai;
                        segundPai = primeiroPai;
                        primeiroPai = aux;

                        preso = 0;
                    }

                    var faker = new Faker();

                    var pontosDeCorte = new List<int> 
                    { 
                        Utilitario.ObterNumeroRandom(0, GestorConfiguracao.CromossomosPorIndividuos - 1),
                        Utilitario.ObterNumeroRandom(0, GestorConfiguracao.CromossomosPorIndividuos - 1) 
                    }.OrderBy(x => x);

                    var headP = ObterSequencia(inicio: 0, 
                                               fim: pontosDeCorte.ElementAt(0),
                                               fonteDados: primeiroPai);
                    var bodyP = ObterSequencia(inicio: pontosDeCorte.ElementAt(0) + 1,
                                               fim: pontosDeCorte.ElementAt(1),
                                               fonteDados: segundPai);
                    var tailP = ObterSequencia(inicio: pontosDeCorte.ElementAt(1) + 1, 
                                               fim: GestorConfiguracao.CromossomosPorIndividuos - 1,
                                               fonteDados: primeiroPai);
                    primeiroFilho = new Individuo(headP.Concat(bodyP).Concat(tailP).ToList());

                    var headS = ObterSequencia(inicio: 0,
                                               fim: pontosDeCorte.ElementAt(0),
                                               fonteDados: segundPai);
                    var bodyS = ObterSequencia(inicio: pontosDeCorte.ElementAt(0) + 1,
                                               fim: pontosDeCorte.ElementAt(1),
                                               fonteDados: primeiroPai);
                    var tailS = ObterSequencia(inicio: pontosDeCorte.ElementAt(1) + 1,
                                               fim: GestorConfiguracao.CromossomosPorIndividuos - 1,
                                               fonteDados: segundPai);
                    segundoFilho = new Individuo(headS.Concat(bodyS).Concat(tailS).ToList());

                } while (!IndividuoValido(primeiroFilho) || !IndividuoValido(segundoFilho));

                if (primeiroFilho.Cromossomos.Count != 5 || segundoFilho.Cromossomos.Count != 5)
                    throw new System.Exception();

                GestorEntidades.Populacao.Individuos.Add(primeiroFilho);
                GestorEntidades.Populacao.Individuos.Add(segundoFilho);

                /*
                var primeiroFilho = new Cromossomo[GestorConfiguracao.CromossomosPorIndividuos];
                var segundoFilho = new Cromossomo[GestorConfiguracao.CromossomosPorIndividuos];

                var pontoCorte = Utilitario.ObterNumeroRandom(1, GestorConfiguracao.CromossomosPorIndividuos - 1); 

                // Head
                for (int i = 0; i < pontoCorte; i++)
                {
                    primeiroFilho[i] = par.Item1.Cromossomos.ElementAt(i);
                    segundoFilho[i] = par.Item2.Cromossomos.ElementAt(i);
                }

                // Tail
                for (int i = pontoCorte; i < GestorConfiguracao.CromossomosPorIndividuos; i++)
                {
                    primeiroFilho[i] = par.Item2.Cromossomos.ElementAt(i);
                    segundoFilho[i] = par.Item1.Cromossomos.ElementAt(i);
                }

                var ind1 = new Individuo(primeiroFilho.ToList());
                var ind2 = new Individuo(segundoFilho.ToList());

                GestorEntidades.Populacao.Individuos.Add(ind1);
                GestorEntidades.Populacao.Individuos.Add(ind2);
                */
            }
        }

        static List<Cromossomo> ObterSequencia(int inicio, int fim, List<Cromossomo> fonteDados)
        {
            var seq = new List<Cromossomo>();
            for (int i = inicio; i <= fim; i++)
                seq.Add(fonteDados.ElementAt(i));

            return seq;
        }

        static bool IndividuoValido(Individuo individuo)
        {
            var qtdeCromossomos = individuo.Cromossomos.Count();
            var cromossomosUnicos = individuo.Cromossomos.Distinct();

            return qtdeCromossomos == cromossomosUnicos.Count();
        }
    }
}
