using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersSimulator
{
    public class SnakeOrLadderValidator
    {
        public static bool Validate(int headPosition, int tailPosition)
        {
            if (headPosition == tailPosition)
            {
                Console.WriteLine($"ERROR: Snake or ladder has length 0 [Head = {headPosition}, Tail = {tailPosition}].");
                return false;
            }

            if (headPosition < 1 || headPosition > 100)
            {
                Console.WriteLine($"ERROR: Snake or has head out of the game borad. [Head = {headPosition}, Tail = {tailPosition}].");
                return false;
            }

            if (tailPosition < 1 || tailPosition > 100)
            {
                Console.WriteLine($"ERROR: Snake or has tail out of the game borad. [Head = {headPosition}, Tail = {tailPosition}].");
                return false;
            }

            if (headPosition == 0)
            {
                Console.WriteLine($"ERROR: Snake has head at position 100. The game could never be ended with such a snake.");
                return false;
            }

            return true;
        }

        public static bool ValidateSnakesLadderCombinations(List<SnakeOrLadderEntity> snakesAndLadders)
        {
            //prevent undefined locations
            if (!ValidateNoMultipleHeadsAreAtALocation(snakesAndLadders))
            {
                return false;
            }

            //prevent double jumps
            if (!ValidateNoHeadAndATailAreOnSameLocation(snakesAndLadders))
            {
                return false;
            }

            return true;
        }

        private static bool ValidateNoHeadAndATailAreOnSameLocation(List<SnakeOrLadderEntity> snakesAndLadders)
        {

            //TODO: impl
            for (int i = 1; i < 100; i++)
            {
                int headsAtLocation = snakesAndLadders.Count(snakeOrLadded => snakeOrLadded.HeadPosition == i);
                int tailsAtLocation = snakesAndLadders.Count(snakeOrLadded => snakeOrLadded.TailPosition == i);

                if (headsAtLocation > 0 && tailsAtLocation > 0)
                {
                    Console.WriteLine($"ERROR: Location has both a head and a tail on it. This would produce a double jump. Location = {i}.");
                    return false;
                }
            }

            return true;
        }

        private static bool ValidateNoMultipleHeadsAreAtALocation(List<SnakeOrLadderEntity> snakesAndLadders)
        {
            for (int i = 1; i < 100; i++)
            {
                var snakesAndLaddersWithHeadAtLocation = snakesAndLadders.Where(snakeOrLadded => snakeOrLadded.HeadPosition == i);

                if (snakesAndLaddersWithHeadAtLocation.Count() > 1)
                {
                    Console.WriteLine($"ERROR: Multiple snakes/ladders heads at same location. Location = {i}.");
                    return false;
                }

            }

            return true;
        }

    }
}
