using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tick_tack_toe
{
    interface Player
    {
        void NextTurn();
        void Move(Position position , TickTackToeField tickTackToeField);
    }
}
