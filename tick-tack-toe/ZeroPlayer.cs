using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tick_tack_toe
{
    class ZeroPlayer : Player
    {
        public void NextTurn()
        {
            GameManager.GetInstance().ChangePlayer();
        }

        public void Move(Position position, TickTackToeField tickTackToeField)
        {
            tickTackToeField.PutZero(position);
        }
    }
}
