using System;
using System.Collections.Generic;
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
            GerarTabelaBalanceamento();

            Console.WriteLine("Iniciado treinamento...");

            AG.GerarPopulacaoInicial();

            while (true)
            {
                Console.WriteLine($"Geração {GestorEntidades.Geracoes.Last().NumeroGeracao}");
                AG.AvaliarIndividuos();
                SalvarHistorico(); //salvar após a avalição para manter o peso
                if (AG.PopulacaoApta()) break;
                AG.SelecionarIndividuos();
                AG.CruzarIndividuos();
                AG.MutarIndividuos();
            }

            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }

        private static void GerarTabelaBalanceamento()
        {
            List<(string codEmpresa, decimal valor, decimal score)> ObterValores(int ano, int tri) {
                GestorConfiguracao.AnoTreinamento = ano;
                GestorConfiguracao.TrimestreTreinamento = tri;
                Print($"Gerando população do ano {ano} trimestre {tri}..");
                AG.GerarPopulacaoInicial();

                return CalcularBalanceamento(ano, tri);
            }

            for (int a = 2017; a <= 2018; a++) //Anos
                for (int t = 1; t <= 4; t++) //Trimestres
                {
                    var c2017_1 = ObterValores(a, t);
                    Excel.InicializarArquivo();
                    Excel.ExportarZScore($"Ano_{a}_Trimestre_{t}", c2017_1);
                }

            Excel.LiberarRecursos();
        }

        private static List<(string codEmpresa, decimal valor, decimal score)> CalcularBalanceamento(int ano, int trismestre)
        {
            var dados = GestorEntidades.CromossomosDisponiveis
                                       .Where(x => x.Periodo.Ano == ano && x.Periodo.Trimestre == trismestre)
                                       .Select(x => 
                                        new ValueTuple<string, decimal>
                                           (x.Empresa.Codigo,
                                            x.Empresa.PrecoAtivoNoPeriodo
                                                                 .Where(y => y.Item1.Ano == ano && y.Item1.Trimestre == trismestre)
                                                                 .Select(z => z.Item2)
                                                                 .SingleOrDefault())
                                       )
                                       .ToList();

            return ZScore.Calcular(dados);
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
                Console.WriteLine($"\n**************************************************************");
                Console.WriteLine($"[Peso] - {individuo.Peso}");

                foreach (var cromossomo in individuo.Cromossomos)
                {
                    Console.WriteLine($"[Ação] - \t {cromossomo.Empresa.Codigo} \t [Setor] - {cromossomo.Empresa.Setor.ObterDescricaoEnum<Setor>()}");
                }
            }
        }

        static void Print(string message) => Console.WriteLine(message);
    }
}
