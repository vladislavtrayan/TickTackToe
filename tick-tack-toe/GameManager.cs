using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tick_tack_toe
{
    class GameManager
    {
        private static GameManager _instance;

        public int CurrentPlayer { get; private set; }

        private GameManager()
        {
        }

        public static GameManager GetInstance()
        {
            return _instance ?? (_instance = new GameManager());
        }

        public void ChangePlayer()
        {
            CurrentPlayer = CurrentPlayer == 1 ? 2 : 1;
        }
    }
}
