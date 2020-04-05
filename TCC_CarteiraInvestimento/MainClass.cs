using System;
using System.Linq;
using TCC_CarteiraInvestimento.AlgoritmoGenetico;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;
using TCC_CarteiraInvestimento.Utils;

namespace TCC_CarteiraInvestimento
{
    class MainClass
    {
        static void Main(string[] args)
        {
            AG.GerarPopulacaoInicial();

            while (true)
            {
                AG.AvaliarIndividuos();
                SalvarHistorico(); //salvar após a avalição para manter o peso
                if (AG.PopulacaoApta()) break;
                AG.SelecionarIndividuos();
                AG.CruzarIndividuos();
            }

            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }

        private static void SalvarHistorico()
        {
            GestorEntidades.Geracoes.Add(new Geracao() 
            { 
                DataGeracao = DateTime.Now,
                NumeroGeracao = GestorEntidades.Geracoes.Count + 1,
                Populacao = GestorEntidades.Populacao.Clonar<Populacao>()
            });

            MostrarUltimaGeracao();
        }

        private static void MostrarUltimaGeracao()
        {
            Console.Clear();

            foreach (var individuo in GestorEntidades.Geracoes.Last().Populacao.Individuos)
            {
                Console.WriteLine($"[Peso] - {individuo.Peso}");

                foreach (var cromossomo in individuo.Cromossomos)
                {
                    Console.WriteLine($"[Ação] - {cromossomo.Empresa.Codigo} \t\t [Setor] - {cromossomo.Empresa.Setor.ObterDescricaoEnum<Setor>()}");
                }
            }
        }
    }
}
