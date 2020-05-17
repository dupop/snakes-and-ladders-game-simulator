using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLaddersSimulator
{

    public class SnakeOrLadderEntity
    {
        public int HeadPosition;
        public int TailPosition;

        public SnakeOrLadderEntity(int headPosition, int tailPosition)
        {
            HeadPosition = headPosition;
            TailPosition = tailPosition;
        }

        public SnakeOrLadderVariant GetVariant()
        {
            return HeadPosition > TailPosition ? SnakeOrLadderVariant.Snake : SnakeOrLadderVariant.Ladder;
        }

    }
}
