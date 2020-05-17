using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersSimulator
{
    public class GameSimluator
    {
        SnakeOrLadderEntity[] SnakesAndLadders = new SnakeOrLadderEntity[0];

        public void LoadGameBoard(SnakeOrLadderEntity[] snakesAndLadders)
        {
            SnakesAndLadders = snakesAndLadders;
        }

        public OneGameStatisticsDto Simlulate(int maxTurns, bool liveGameLogging = false)
        {
            //player starts out of the game board
            int playerPosition = 0; 
            
            int thrownDices = 0;

            int numberOfJumps = 0;
            int numberOfTimesPlayerIsBlocked = 0;

            while (true)
            {
                if (thrownDices == maxTurns)
                {
                    if(liveGameLogging) Console.WriteLine($"Max turns ({maxTurns}) reached wihtout reaching the goal! Better luck in next game!");
                    break;
                }

                int diceResult = ThrowDice();
                thrownDices++;
                if (liveGameLogging) Console.WriteLine($"\nPlayer is on position {playerPosition}. Dice gave result {diceResult} on throwing number {thrownDices}.");
                

                //check if player would be moved out of the board
                if (playerPosition + diceResult > 100)
                {
                    if (liveGameLogging) Console.WriteLine($"Player can't move. \t\t\t<-- IMPORTANT");
                    numberOfTimesPlayerIsBlocked++;
                    continue;
                }

                //move player
                playerPosition += diceResult;
                if (liveGameLogging) Console.WriteLine($"Moved player by {diceResult} to position {playerPosition}");

                //execute snake or ladder jump if there is one of those at new player's position
                SnakeOrLadderEntity snakeOrLadderAtNewPlayerPosition = SnakesAndLadders.SingleOrDefault(element => element.HeadPosition == playerPosition);
                if (snakeOrLadderAtNewPlayerPosition != null)
                {
                    int whereToJump = snakeOrLadderAtNewPlayerPosition.TailPosition;

                    if (liveGameLogging) Console.WriteLine($"Player jumped to position {whereToJump}. \t\t<-- IMPORTANT");
                    playerPosition = snakeOrLadderAtNewPlayerPosition.TailPosition;
                    numberOfJumps++;
                }

                //check if player reached game end
                if (playerPosition == 100)
                {
                    if (liveGameLogging) Console.WriteLine($"Player won the game in {thrownDices} turns.");
                    break;
                }
            }

            OneGameStatisticsDto stats = new OneGameStatisticsDto
            {
                Turns = thrownDices,
                Jumps = numberOfJumps,
                BlockedTimes = numberOfTimesPlayerIsBlocked
            };

            if (liveGameLogging) Console.WriteLine($"\nLast game statistics: Turns: {thrownDices}, Jumps: {numberOfJumps}, Times player was unable to move: {numberOfTimesPlayerIsBlocked}");
            
            return stats;
        }

        private int ThrowDice()
        {
            Random r = new Random(Guid.NewGuid().GetHashCode());
            r.Next();
            int diceResult = r.Next(1, 7);

            return diceResult;
        }
    }
}
