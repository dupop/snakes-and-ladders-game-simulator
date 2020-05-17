using SnakesAndLaddersSimulator.Statistics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersSimulator
{
    class Program
    {
        public const string IntputFileName = "SnakesAndLadders.txt";

        static void Main(string[] args)
        {
            GameSimluator simluator = new GameSimluator();

            //import board data
            var snakesAndLadders = SnakeOrLadderImporter.LoadSnakesAndLadders(IntputFileName);
            simluator.LoadGameBoard(snakesAndLadders);

            //do a huge test
            SimulationConfig simulationConfig = UserInteraction.AskUserForSimulationConfig();
            MonteCarloAnalysis.ExecuteStatisticalAnalysis(simluator, simulationConfig);

            //exeute one test live
            Console.WriteLine("\n\nExecuting one game with live scores:");
            simluator.Simlulate(100, true);

            //keep program open
            Console.ReadLine();
        }

    }
}
