using System;
using System.Collections.Generic;
using System.Linq;
using TCC_CarteiraInvestimento.AlgoritmoGenetico;
using TCC_CarteiraInvestimento.Entidades;
using TCC_CarteiraInvestimento.Gestores;
using TCC_CarteiraInvestimento.Utils;
using static TCC_CarteiraInvestimento.Utils.Enums;

namespace TCC_CarteiraInvestimento
{
    class MainClass
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var opcao = Menu();

                switch (opcao)
                {
                    case OpcoesMenu.CalcularZScore:
                        ZScore.GerarTabelaBalanceamento();
                        break;
                    case OpcoesMenu.Treinar:
                        Print("Iniciado treinamento...");

                        Excel.InicializarArquivo($"C:\\Users\\Renee\\Desktop\\Treinamento.xlsx");

                        AG.GerarPopulacaoInicial();
                        Print("População inicial gerada...");

                        var execCount = 0;
                        while (true)
                        {
                            Print($"Execução nº{execCount}...\n");

                            AG.AvaliarIndividuos();
                            Print("Fitness aplicado... \n");

                            SalvarHistorico(); //salvar após a avalição para manter o peso

                            if (AG.PopulacaoApta()) break;
                            Print("População inadequada...");

                            AG.SelecionarIndividuos();
                            Print("Pares de pais selecionados...");

                            AG.CruzarIndividuos();
                            Print("Gerado novos indivíduos...");

                            AG.MutarIndividuos();

                            execCount++;
                        }

                        Excel.LiberarRecursos();

                        break;
                    case OpcoesMenu.MelhorCarteira:

                        break;
                    case OpcoesMenu.PiorCarteira:
                        break;
                    case OpcoesMenu.Sair:
                        Console.ReadKey();
                        return;
                    default:
                        break;
                }
            }
        }

        private static OpcoesMenu Menu()
        {
            Print("\n\n");
            Print("----------------------");
            Print($"[{(int)OpcoesMenu.CalcularZScore}] - ZScore");
            Print($"[{(int)OpcoesMenu.Treinar}] - Treinamento");
            Print($"[{(int)OpcoesMenu.MelhorCarteira}] - Mostrar melhor indivíduo");
            Print($"[{(int)OpcoesMenu.PiorCarteira}] - Mostrar pior indivíduo");
            Print($"[{(int)OpcoesMenu.Sair}] - Sair");
            Print("----------------------");

            return (OpcoesMenu)int.Parse(Console.ReadLine());
        }

        private static void SalvarHistorico()
        {
            var gen = new Geracao()
            {
                DataGeracao = DateTime.Now,
                NumeroGeracao = GestorEntidades.Geracoes.Count + 1,
                Populacao = GestorEntidades.Populacao.Clonar<Populacao>()
            };

            GestorEntidades.Geracoes.Add(gen);

            ExportarGeracao(gen);

            MostrarUltimaGeracao();
        }

        private static void ExportarGeracao(Geracao gen)
        {
            Excel.IdentificarEtiqueta($"GEN-{gen.NumeroGeracao}");

            #region Melhor indivíduo

            var melhoresCromossomos = ObterMelhoresIndividuos();
            Excel.GravarCelula("A1", "Melhor indivíduo");
            Excel.GravarCelula("C1", $"{melhoresCromossomos.ElementAt(0).Item1}(Peso{melhoresCromossomos.ElementAt(0).Item2})");
            Excel.GravarCelula("D1", $"{melhoresCromossomos.ElementAt(1).Item1}(Peso{melhoresCromossomos.ElementAt(0).Item2})");
            Excel.GravarCelula("E1", $"{melhoresCromossomos.ElementAt(2).Item1}(Peso{melhoresCromossomos.ElementAt(0).Item2})");
            Excel.GravarCelula("F1", $"{melhoresCromossomos.ElementAt(3).Item1}(Peso{melhoresCromossomos.ElementAt(0).Item2})");
            Excel.GravarCelula("G1", $"{melhoresCromossomos.ElementAt(4).Item1}(Peso{melhoresCromossomos.ElementAt(0).Item2})");

            #endregion

            #region Pior indivíduo

            var pioresCromossomos = ObterPioresIndividuos();
            Excel.GravarCelula("A2", "Pior indivíduo");
            Excel.GravarCelula("C2", $"{pioresCromossomos.ElementAt(0).Item1}(Peso{pioresCromossomos.ElementAt(0).Item2})");
            Excel.GravarCelula("D2", $"{pioresCromossomos.ElementAt(1).Item1}(Peso{pioresCromossomos.ElementAt(0).Item2})");
            Excel.GravarCelula("E2", $"{pioresCromossomos.ElementAt(2).Item1}(Peso{pioresCromossomos.ElementAt(0).Item2})");
            Excel.GravarCelula("F2", $"{pioresCromossomos.ElementAt(3).Item1}(Peso{pioresCromossomos.ElementAt(0).Item2})");
            Excel.GravarCelula("G2", $"{pioresCromossomos.ElementAt(4).Item1}(Peso{pioresCromossomos.ElementAt(0).Item2})");

            #endregion

            #region Cabeçalho

            Excel.GravarCelula("A3", "Peso");
            Excel.GravarCelula("C3", "1º Ind.");
            Excel.GravarCelula("D3", "2º Ind.");
            Excel.GravarCelula("E3", "3º Ind.");
            Excel.GravarCelula("F3", "4º Ind.");
            Excel.GravarCelula("G3", "5º Ind."); 
            
            #endregion

            #region Indivíduos

            var linha = 4;
            foreach (var ind in gen.Populacao.Individuos.OrderByDescending(x => x.Peso))
            {
                Excel.GravarCelula($"A{linha}", ind.Peso);

                Excel.GravarCelula($"C{linha}", ind.Cromossomos[0]);
                Excel.GravarCelula($"D{linha}", ind.Cromossomos[1]);
                Excel.GravarCelula($"E{linha}", ind.Cromossomos[2]);
                Excel.GravarCelula($"F{linha}", ind.Cromossomos[3]);
                Excel.GravarCelula($"G{linha}", ind.Cromossomos[4]);

                Excel.SalvarAlteracoes();
                linha++;
            } 

            #endregion
        }

        private static List<(decimal, decimal)> ObterMelhoresIndividuos(int limite = 5)
        {
            throw new NotImplementedException();
        }

        private static List<(decimal, decimal)> ObterPioresIndividuos(int limite = 5)
        {
            throw new NotImplementedException();
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
