using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersSimulator
{
    public static class SnakeOrLadderImporter
    {
        public static SnakeOrLadderEntity[] LoadSnakesAndLadders(string filePath)
        {
            //Console.WriteLine($"Started loading snakes and ladders complete.");

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"ERROR: Files with snakes and ladders not found: Filename = {filePath}.");
                return new SnakeOrLadderEntity[0];
            }

            var lines = File.ReadAllLines(filePath);

            SnakeOrLadderEntity[] snakeOrLadderEntity = ParseLines(lines);

            Console.WriteLine($"Number of snakes and ladders loaded: {snakeOrLadderEntity.Length}.");
            return snakeOrLadderEntity;
        }

        private static SnakeOrLadderEntity[] ParseLines(string[] lines)
        {
            List<SnakeOrLadderEntity> snakesAndLadders = new List<SnakeOrLadderEntity>();

            foreach (string line in lines)
            {
                SnakeOrLadderEntity snakeOrLadder = ParseLine(line);

                if (snakeOrLadder != null)
                {
                    //Console.WriteLine($"Loadded a {snakeOrLadder.GetVariant()} from {snakeOrLadder.HeadPosition} to {snakeOrLadder.TailPosition}.");
                    snakesAndLadders.Add(snakeOrLadder);
                }
            }

            if (!SnakeOrLadderValidator.ValidateSnakesLadderCombinations(snakesAndLadders))
            {
                return new SnakeOrLadderEntity[0];
            }

            return snakesAndLadders.ToArray();
        }

        public static SnakeOrLadderEntity ParseLine(string line)
        {
            if (line.StartsWith("#"))
            {
                //Ignorring lines starting with #, those can be used for comments
                return null;
            }

            if (string.IsNullOrWhiteSpace(line))
            {
                //Ignorring empty lines
                return null;
            }

            string[] lineParts = line.Split(' ');

            if (lineParts.Length < 2)
            {
                Console.WriteLine($"ERROR: Head or tail position is missing in line. Line content: {line}");
                return null;
            }

            if (lineParts.Length > 2)
            {
                Console.WriteLine($"WARNING: Line contents additional data: {line}. Additional data in the line will be ignored.");
            }

            int headPosition;
            int tailPosition;
            try
            {
                headPosition = int.Parse(lineParts[0]);
                tailPosition = int.Parse(lineParts[1]);
            }
            catch
            {
                Console.WriteLine($"ERROR: Components of a line can't be parsed to int. Line content: {line}");
                return null;
            }

            if (!SnakeOrLadderValidator.Validate(headPosition, tailPosition))
            {
                return null;
            }

            SnakeOrLadderEntity snakeOrLadder = new SnakeOrLadderEntity(headPosition, tailPosition);

            return snakeOrLadder;
        }

    }
}
