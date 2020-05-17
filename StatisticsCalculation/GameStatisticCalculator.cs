using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersSimulator.Statistics
{
    public static class GameStatisticCalculator
    {
        const int DecimalsToWrite = 0;

        public static void CalculateAndWriteStatisticConclusions(List<OneGameStatisticsDto> allGameStats, int durationOfOneMoveInSeconds)
        {
            Console.WriteLine($"\nGame statistical analysis:\n");
            CalculateAndWriteStatisticConclusionsForOneParam(allGameStats, oneGameStats => oneGameStats.Turns * durationOfOneMoveInSeconds / 60, "Duration per player [min] (15s per move assumed)");
            CalculateAndWriteStatisticConclusionsForOneParam(allGameStats, oneGameStats => oneGameStats.Jumps, "Jumps");

            //not interesting calculations:
            //CalculateAndWriteStatisticConclusionsForOneParam(allGameStats, oneGameStats => oneGameStats.Turns, "Turns");
            //CalculateAndWriteStatisticConclusionsForOneParam(allGameStats, oneGameStats => oneGameStats.BlockedTimes, "Times palyer was blocked");

            Console.WriteLine($"\nStatistical method and disclaimer:\n");
            Console.WriteLine($"* Caluclation done by using Monte Carlo analysis on {allGameStats.Count} game runs.");
            Console.WriteLine($"* Probablity of human readable conclusions is 68% as one sigma is meant by \"usually\".");
            Console.WriteLine($"* Effects of Monte Carlo uncertanity not taken into account in word \"usually\".");
        }

        private static void CalculateAndWriteStatisticConclusionsForOneParam(List<OneGameStatisticsDto> allGameStats, Func<OneGameStatisticsDto, int> parameterToCalculate, string gameParameterName)
        {
            //make a list of only selected gamer parameter from every game (i.e. filter out other game parameter types)
            IEnumerable<int> rawParameterValueFromEachGame = allGameStats.Select(parameterToCalculate);

            //do the statistics on this list of numbers
            StaticsParametersOfAnArrayDto statResultsOfAGameParameter = MathemtaticalStatisticCalculator.CalculateStatsForOneParam(rawParameterValueFromEachGame);

            //write results of the statistics analysis of the list of numbers
            WriteStasForOneGameParam(statResultsOfAGameParameter, gameParameterName);
        }

        private static void WriteStasForOneGameParam(StaticsParametersOfAnArrayDto statisticParameter, string gameParameterName)
        {
            //lower and uuper boundary values with certanity of 68% (i.e. values in range of one sigma to the left or to the rigt from the averge value)
            double stdDevLowerBoundDecimal = statisticParameter.Avg - statisticParameter.StdDev;
            double stdDevUpperBoundDecimal = statisticParameter.Avg + statisticParameter.StdDev;

            double deviationInPercentsDecimal = CalculateDeviationInPercents(statisticParameter);
            
            string decimalsFormatting = GetDecimalsFormatting(DecimalsToWrite);

            //formating decimals to string
            string avg = statisticParameter.Avg.ToString(decimalsFormatting);
            string stdDev = statisticParameter.StdDev.ToString(decimalsFormatting);
            string min = statisticParameter.Min.ToString(decimalsFormatting);
            string max = statisticParameter.Max.ToString(decimalsFormatting);
            string stdDevLowerBound = stdDevLowerBoundDecimal.ToString(decimalsFormatting);
            string stdDevUpperBound = stdDevUpperBoundDecimal.ToString(decimalsFormatting);
            string deviationInPercents = deviationInPercentsDecimal.ToString(decimalsFormatting);

            Console.WriteLine($"{gameParameterName}: avg = {avg}, std dev = {stdDev}, min = {min}, max = {max}.");
            Console.WriteLine($"Game will usually have {avg} +- {stdDev} (i.e. {stdDevLowerBound} - {stdDevUpperBound}) {gameParameterName.ToLower()}.\n"); // this statement has certanity of 68%
        }

        /// <summary>
        /// Determines C# formatting used in ToString() method so that specified number of decimals is printed to string.
        /// Zero is also valid.
        /// </summary>
        private static string GetDecimalsFormatting(int numberOfDecimals)
        {
            return "#." + string.Concat(Enumerable.Repeat("0", numberOfDecimals));
        }

        /// <summary>
        /// Clulcates relative deviation from the absolute one which is default.
        /// Caluclate how many percents values deviate instead of for HOW MUCH they deviate. 
        /// </summary>
        /// <param name="statisticParameter"></param>
        /// <returns></returns>
        private static double CalculateDeviationInPercents(StaticsParametersOfAnArrayDto statisticParameter)
        {
            double deviationInPercents;
            if (statisticParameter.Avg != 0)
            {
                deviationInPercents = statisticParameter.StdDev / statisticParameter.Avg * 100;
            }
            else
            {
                deviationInPercents = double.NaN; //could be postive or ngeative infinity or undifined, but this scneario is not important that much
            }

            return deviationInPercents;
        }

    }
}
