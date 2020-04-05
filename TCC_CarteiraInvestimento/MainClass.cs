using System;
using TCC_CarteiraInvestimento.AlgoritmoGenetico;

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
                //SalvarHistorioco(); //salvar após a avalição para manter o peso
                //if (AG.PopulacaoApta()) break;
                AG.SelecionarIndividuos();
                AG.CruzarIndividuos();

            }

            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
