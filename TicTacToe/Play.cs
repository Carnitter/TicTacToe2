using System;
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
        public String test;
        public int age;

        public Play()
        {
            text = "";
        }

        public String ToString()
        {
            test = "JAIRO";
            age = 21;
            return $"{text} {test} {age}";
        }


    }
}
