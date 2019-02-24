using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tick_tack_toe
{
    class TickTackToeField
    {

        public int[,] Fields { get; }

        public TickTackToeField()
        {
            Fields = new int[3,3];
        }

        public void PutZero(Position position)
        {
            Fields[position.X , position.Y] = -1;
        }

        public void PutCross(Position position)
        {
            Fields[position.X , position.Y] = 1;
        }

        public bool IsEmptyCell (Position position)
        {
            return Fields[position.X , position.Y] == 0;
        }
    }
}
