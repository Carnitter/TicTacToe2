using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client c = new Client();

            //(new Thread(() => { Server s = new Server(); })).Start();
            //(new Thread(() => { Client c = new Client(); })).Start();
            GameGui gui = new GameGui(false);
            gui.Show();
            gui.Activate();
            gui.Visible = true;
            gui.SetDesktopLocation(0, 0);
            Application.Run(gui);
            
            
        }
    }
}
