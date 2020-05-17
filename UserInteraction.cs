using SnakesAndLaddersSimulator.Statistics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersSimulator
{
    public static class UserInteraction
    {
        public static SimulationConfig AskUserForSimulationConfig()
        {
            Console.WriteLine($"\n\nDefault simulation config:\n{SimulationConfig.Default.ToString()}.");
            Console.WriteLine($"Press ENTER to begin or input custom comma separated values.");
            string userResponse = Console.ReadLine();

            SimulationConfig simulationConfig;
            if (string.IsNullOrWhiteSpace(userResponse))
            {
                simulationConfig = SimulationConfig.Default;
            }
            else
            {
                string[] configValues = userResponse.Split(' ',','); //space will also be considered as a separator

                if (configValues.Length < 4)
                {
                    Console.WriteLine($"WARNING: Some config values are missing. Using default config.");
                    simulationConfig = SimulationConfig.Default;
                }
                else
                {
                    try
                    {
                        simulationConfig = new SimulationConfig()
                        {
                            DurationOfOneMoveInSeconds = int.Parse(configValues[0]),
                            NumberOfIterations = int.Parse(configValues[1]),
                            NumberOfProgressLogs = int.Parse(configValues[2]),
                            MaxTurns = int.Parse(configValues[3])
                        };

                        Console.WriteLine($"Using user config:\n{simulationConfig.ToString()}.");

                    }
                    catch
                    {
                        Console.WriteLine($"WARNING: Parsign config values failed. Using default config.");
                        simulationConfig = SimulationConfig.Default;
                    }
                }
            }

            return simulationConfig;
        }

    }
}
