﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    [Serializable]
    public class Play
    {
        public String text;

        public Play()
        {
            text = "";
        }

        public override String ToString()
        {
            return text;
        }


    }
}
