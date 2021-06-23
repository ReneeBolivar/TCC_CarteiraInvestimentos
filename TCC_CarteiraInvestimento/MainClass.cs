using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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

                        Excel.InicializarArquivo($"D:\\TCC\\Treinamento.xlsx");

                        AG.GerarPopulacaoInicial();
                        Print("População inicial gerada...");

                        var execCount = 0;
                        while (true)
                        {
                            Print($"Execução nº{execCount}...\n");

                            AG.AvaliarIndividuos();
                            Print("Fitness aplicado... \n");

                            //salvar após a avalição para manter o peso
                            SalvarHistorico(GestorEntidades.Geracoes.Count + 1, GestorEntidades.Populacao.Clonar<Populacao>());

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

                        Print("## Aguardando finalizar exportações");
                        Console.ReadKey();

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

        private static void SalvarHistorico(int numeroGeracao, Populacao populacao)
        {
            lock (objectLock)
            {
                var gen = new Geracao()
                {
                    DataGeracao = DateTime.Now,
                    NumeroGeracao = numeroGeracao,
                    Populacao = populacao
                };

                GestorEntidades.Geracoes.Add(gen);

                Task.Run(() =>
                {
                    ExportarGeracao(gen);
                });
                //MostrarUltimaGeracao();
            }
        }

        static readonly object objectLock = new object();
        private static void ExportarGeracao(Geracao gen)
        {
            lock (objectLock)
            {
                Excel.IdentificarEtiqueta($"GEN-{gen.NumeroGeracao}");

                #region Melhor indivíduo

                var melhoresCromossomos = ObterMelhoresIndividuos();
                Excel.MesclarCelulas("A1", "B1");
                Excel.GravarCelula("A1", "Melhor indivíduo", melhoresCromossomos.Sum(x => x.Item2).ToString());
                Excel.GravarCelula("C1", $"{melhoresCromossomos.ElementAt(0).Item1}", $"Peso {melhoresCromossomos.ElementAt(0).Item2}");
                Excel.GravarCelula("D1", $"{melhoresCromossomos.ElementAt(1).Item1}", $"Peso {melhoresCromossomos.ElementAt(1).Item2}");
                Excel.GravarCelula("E1", $"{melhoresCromossomos.ElementAt(2).Item1}", $"Peso {melhoresCromossomos.ElementAt(2).Item2}");
                Excel.GravarCelula("F1", $"{melhoresCromossomos.ElementAt(3).Item1}", $"Peso {melhoresCromossomos.ElementAt(3).Item2}");
                Excel.GravarCelula("G1", $"{melhoresCromossomos.ElementAt(4).Item1}", $"Peso {melhoresCromossomos.ElementAt(4).Item2}");

                #endregion

                #region Pior indivíduo

                var pioresCromossomos = ObterPioresIndividuos();
                Excel.MesclarCelulas("A2", "B2");
                Excel.GravarCelula("A2", "Pior indivíduo", pioresCromossomos.Sum(x => x.Item2).ToString());
                Excel.GravarCelula("C2", $"{pioresCromossomos.ElementAt(0).Item1}", $"Peso {pioresCromossomos.ElementAt(0).Item2}");
                Excel.GravarCelula("D2", $"{pioresCromossomos.ElementAt(1).Item1}", $"Peso {pioresCromossomos.ElementAt(0).Item2}");
                Excel.GravarCelula("E2", $"{pioresCromossomos.ElementAt(2).Item1}", $"Peso {pioresCromossomos.ElementAt(0).Item2}");
                Excel.GravarCelula("F2", $"{pioresCromossomos.ElementAt(3).Item1}", $"Peso {pioresCromossomos.ElementAt(0).Item2}");
                Excel.GravarCelula("G2", $"{pioresCromossomos.ElementAt(4).Item1}", $"Peso {pioresCromossomos.ElementAt(0).Item2}");

                #endregion

                var anoAtual = GestorConfiguracao.AnoTreinamento;
                var triAtual = GestorConfiguracao.TrimestreTreinamento;
                var anoSeguinte = 0;
                var triSeguinte = 0;
                if (triAtual == 4)
                {
                    anoSeguinte = anoAtual + 1;
                    triSeguinte = 1;
                }
                else
                {
                    anoSeguinte = anoAtual;
                    triSeguinte = triAtual + 1;
                }

                #region Cabeçalho

                Excel.MesclarCelulas("A3", "B3");
                Excel.GravarCelula("A3", "Peso");
                Excel.GravarCelula("C3", "1º Ind.");
                Excel.GravarCelula("D3", "2º Ind.");
                Excel.GravarCelula("E3", "3º Ind.");
                Excel.GravarCelula("F3", "4º Ind.");
                Excel.GravarCelula("G3", "5º Ind.");

                Excel.MesclarCelulas("L3", "M3");
                Excel.MesclarCelulas("L3", "N3");
                Excel.GravarCelula("L3", $"Valores no ano {anoAtual}/{triAtual}");

                Excel.MesclarCelulas("R3", "S3");
                Excel.MesclarCelulas("R3", "T3");
                Excel.GravarCelula("R3", $"Valores no ano {anoSeguinte}/{triSeguinte}");

                #endregion

                #region Indivíduos

                var linha = 4;
                foreach (var ind in gen.Populacao.Individuos.OrderByDescending(x => x.Peso))
                {
                    Excel.GravarCelula($"A{linha}", ind.Peso);

                    //Empresas
                    Excel.GravarCelula($"C{linha}", ind.Cromossomos[0].Empresa.Codigo, ind.Cromossomos[0].Empresa.Setor.ObterDescricaoEnum<Setor>());
                    Excel.GravarCelula($"D{linha}", ind.Cromossomos[1].Empresa.Codigo, ind.Cromossomos[1].Empresa.Setor.ObterDescricaoEnum<Setor>());
                    Excel.GravarCelula($"E{linha}", ind.Cromossomos[2].Empresa.Codigo, ind.Cromossomos[2].Empresa.Setor.ObterDescricaoEnum<Setor>());
                    Excel.GravarCelula($"F{linha}", ind.Cromossomos[3].Empresa.Codigo, ind.Cromossomos[3].Empresa.Setor.ObterDescricaoEnum<Setor>());
                    Excel.GravarCelula($"G{linha}", ind.Cromossomos[4].Empresa.Codigo, ind.Cromossomos[4].Empresa.Setor.ObterDescricaoEnum<Setor>());

                    //Ativos no trimestre
                    Excel.GravarCelula($"K{linha}", ind.Cromossomos[0].Empresa.PrecoAtivoNoPeriodo.Where(x => x.Item1.Ano == anoAtual && x.Item1.Trimestre == triAtual)
                                                                                                  .Select(x => x.Item2));
                    Excel.GravarCelula($"L{linha}", ind.Cromossomos[1].Empresa.PrecoAtivoNoPeriodo.Where(x => x.Item1.Ano == anoAtual && x.Item1.Trimestre == triAtual)
                                                                                                  .Select(x => x.Item2));
                    Excel.GravarCelula($"M{linha}", ind.Cromossomos[2].Empresa.PrecoAtivoNoPeriodo.Where(x => x.Item1.Ano == anoAtual && x.Item1.Trimestre == triAtual)
                                                                                                  .Select(x => x.Item2));
                    Excel.GravarCelula($"N{linha}", ind.Cromossomos[3].Empresa.PrecoAtivoNoPeriodo.Where(x => x.Item1.Ano == anoAtual && x.Item1.Trimestre == triAtual)
                                                                                                  .Select(x => x.Item2));
                    Excel.GravarCelula($"O{linha}", ind.Cromossomos[4].Empresa.PrecoAtivoNoPeriodo.Where(x => x.Item1.Ano == anoAtual && x.Item1.Trimestre == triAtual)
                                                                                                  .Select(x => x.Item2));

                    //Ativos no trimestre seguinte
                    Excel.GravarCelula($"Q{linha}", ind.Cromossomos[0].Empresa.PrecoAtivoNoPeriodo.Where(x => x.Item1.Ano == anoSeguinte && x.Item1.Trimestre == triSeguinte)
                                                                                                  .Select(x => x.Item2));
                    Excel.GravarCelula($"R{linha}", ind.Cromossomos[1].Empresa.PrecoAtivoNoPeriodo.Where(x => x.Item1.Ano == anoSeguinte && x.Item1.Trimestre == triSeguinte)
                                                                                                  .Select(x => x.Item2));
                    Excel.GravarCelula($"S{linha}", ind.Cromossomos[2].Empresa.PrecoAtivoNoPeriodo.Where(x => x.Item1.Ano == anoSeguinte && x.Item1.Trimestre == triSeguinte)
                                                                                                  .Select(x => x.Item2));
                    Excel.GravarCelula($"T{linha}", ind.Cromossomos[3].Empresa.PrecoAtivoNoPeriodo.Where(x => x.Item1.Ano == anoSeguinte && x.Item1.Trimestre == triSeguinte)
                                                                                                  .Select(x => x.Item2));
                    Excel.GravarCelula($"U{linha}", ind.Cromossomos[4].Empresa.PrecoAtivoNoPeriodo.Where(x => x.Item1.Ano == anoSeguinte && x.Item1.Trimestre == triSeguinte)
                                                                                                  .Select(x => x.Item2));

                    Excel.SalvarAlteracoes();
                    linha++;
                }

                #endregion

                Print($"------ Geração {gen.NumeroGeracao} salva");
            }
        }

        private static List<(string, float)> ObterMelhoresIndividuos(int limite = 5)
        {
            return ObterEmpresasComAvaliacao().OrderByDescending(x => x.Item2).Take(limite).ToList();
        }

        private static List<(string, float)> ObterPioresIndividuos(int limite = 5)
        {
            return ObterEmpresasComAvaliacao().OrderBy(x => x.Item2).Take(limite).ToList();
        }

        private static List<(string, float)> ObterEmpresasComAvaliacao()
        {
            var empresas = new List<(string, float)>();
            GestorEntidades.CromossomosDisponiveis.ForEach(x =>
            {
                empresas.Add((x.Empresa.Codigo, AG.CalcularAvalicaoIndicadores(x)));
            });
            return empresas;
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
