using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersSimulator
{
    public static class RawStatisticDataCsvExporter
    {
        public static void ExportRawGameStatsToFile(List<OneGameStatisticsDto> allGameStats)
        {
            List<string> lines = new List<string>();

            //write stats of each game to one line
            foreach (var oneGameStats in allGameStats)
            {
                lines.Add(oneGameStats.Turns.ToString() +","+ oneGameStats.Jumps.ToString() +","+ oneGameStats.BlockedTimes.ToString());
            }

            string basicFileName = "AllGameStatistics";
            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            string fullFileName = $"{basicFileName}_{timeStamp}.csv";

            File.WriteAllLines(fullFileName, lines);
        }
    }
}
