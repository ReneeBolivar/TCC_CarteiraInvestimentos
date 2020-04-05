using System;
using TCC_CarteiraInvestimento.AlgoritmoGenetico;

namespace TCC_CarteiraInvestimento
{
    class MainClass
    {
        static void Main(string[] args)
        {
            AG.GerarPopulacaoInicial();

            do
            {
                AG.AvaliarIndividuos();

            } while (true);

            Console.WriteLine("Press any key to end");
            Console.ReadKey();
        }
    }
}
