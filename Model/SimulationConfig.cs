using SnakesAndLaddersSimulator.Statistics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersSimulator
{
    public class SimulationConfig
    {
        public static readonly SimulationConfig Default = new SimulationConfig()
        {
            DurationOfOneMoveInSeconds = 15,
            NumberOfIterations = 5000,
            NumberOfProgressLogs = 10,
            MaxTurns = 100
        };

        /// <summary>
        /// Assumption used to caluclate game duration according from number of turns that will be needed.
        /// </summary>
        public int DurationOfOneMoveInSeconds = 15;
        
        /// <summary>
        /// Number of Monte Carlo iterations to execute.
        /// </summary>
        public int NumberOfIterations = 1000;

        /// <summary>
        /// Number of progress logs to make during simulation execution.
        /// i.e. 10% 20%, not like 1%,2%,3%... when 100 logs are made
        /// </summary>
        public int NumberOfProgressLogs = 10; 
        
        /// <summary>
        /// Number of turns after which game simulation is aborted.
        /// </summary>
        public int MaxTurns = 100;

        public override string ToString()
        {
            return "[DurationOfOneMoveInSeconds = " + DurationOfOneMoveInSeconds +
                ", NumberOfIterations = " + NumberOfIterations +
                ", NumberOfProgressLogs = " + NumberOfProgressLogs +
                ", MaxTurns = " + MaxTurns
                + "]";
        }

    }

    
}
