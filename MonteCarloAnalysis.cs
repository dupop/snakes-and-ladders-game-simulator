using SnakesAndLaddersSimulator.Statistics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersSimulator
{
    public static class MonteCarloAnalysis
    {
        public static void ExecuteStatisticalAnalysis(GameSimluator simluator, SimulationConfig simulationConfig)
        {
            List<OneGameStatisticsDto> allGameStats = RunSimluations(simluator, simulationConfig.NumberOfIterations, simulationConfig.NumberOfProgressLogs, simulationConfig.MaxTurns);

            //export raw results
            RawStatisticDataCsvExporter.ExportRawGameStatsToFile(allGameStats);

            //do statistical analysis
            GameStatisticCalculator.CalculateAndWriteStatisticConclusions(allGameStats, simulationConfig.DurationOfOneMoveInSeconds);
        }

        private static List<OneGameStatisticsDto> RunSimluations(GameSimluator simluator, int numberOfIterations, int numberOfProgressLogs, int maxTurns)
        {
            List<OneGameStatisticsDto> allGameStats = new List<OneGameStatisticsDto>();

            int afterHowManyRunsToMakeLog = numberOfIterations / numberOfProgressLogs;

            DateTime simluationStartTime = DateTime.Now;

            Console.WriteLine($"\n\nRunning simulation with {numberOfIterations} iterations:\n");
            for (int i = 0; i < numberOfIterations; i++)
            {
                OneGameStatisticsDto currentGameStats = simluator.Simlulate(maxTurns);

                allGameStats.Add(currentGameStats);

                bool enoughProgressMade = i % afterHowManyRunsToMakeLog == 0;
                if (enoughProgressMade)
                {
                    int progressPercentage = 100 * i / numberOfIterations;
                    Console.WriteLine($"Simulation progress: {progressPercentage}%");
                }
            }

            DateTime simluationEndTime = DateTime.Now;
            TimeSpan simluationDuration = simluationEndTime - simluationStartTime;
            Console.WriteLine($"Simulation done. Simulation actual duration: {simluationDuration.Seconds}s\n");
            return allGameStats;
        }
    }
}
