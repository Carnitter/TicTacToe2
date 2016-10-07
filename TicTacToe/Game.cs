using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {
        List<Play> plays = new List<Play>();

        public Game()
        {

        }

        public void update(Play play)
        {
            plays.Add(play);
            hasWon();

        }

        public int hasWon()
        {
            

        }


        
    }
}
