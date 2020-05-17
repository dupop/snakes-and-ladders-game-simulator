using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersSimulator.Statistics
{
    /// <summary>
    /// Calculates various statistic parameter on a simple list of numbers
    /// </summary>
    public static class MathemtaticalStatisticCalculator
    {
        public static StaticsParametersOfAnArrayDto CalculateStatsForOneParam(IEnumerable<int> statisticParamterValueInAllGames)
        {
            StaticsParametersOfAnArrayDto statisticParameter = new StaticsParametersOfAnArrayDto
            {
                Avg = statisticParamterValueInAllGames.Average(),
                StdDev = CalculateStandardDeviation(statisticParamterValueInAllGames.Select(number => (double)number)),
                Min = statisticParamterValueInAllGames.Min(),
                Max = statisticParamterValueInAllGames.Max()
            };

            return statisticParameter;
        }

        private static double CalculateStandardDeviation(IEnumerable<double> values)
        {
            if (!values.Any())
            {
                return 0;
            }
            
            double avg = values.Average();

            double sum = values.Sum(d => Math.Pow(d - avg, 2));

            double standardDeviation = Math.Sqrt(sum / (values.Count() - 1));

            return standardDeviation;
        }
    }
}
