using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameGui : Form
    {
        public Boolean turn = false;
        public Boolean gameFinished = false;
        public Boolean winner = false;
        public int count = 0;
        public List<Button> gameButtons;
        public List<Play> allPlays;
        public Client c;
        public Server s;
        public bool server = false;
        public bool connected = false;
        //public System.Windows.Forms.Timer receivedTimer = new System.Windows.Forms.Timer();

        public GameGui(bool server)
        {
            this.server = server;
            if (server)
            {
                s = new Server();
            }else
            {
                c = new Client();
            }        
            //receivedTimer.Tick += new EventHandler(TimerTick);
            //receivedTimer.Interval = 1000;
            gameButtons = new List<Button>();
            allPlays = new List<Play>();
            InitializeComponent();
            createGame();
            //receivedTimer.Start();
            if (server)
            {
                s.receiver += checkList;
            }else
            {
                c.receiver += checkList;
            }
            
        }


        private void createGame()
        {
            for (int x = 1; x < 4; x++)
            {
                for (int y = 1; y < 4; y++)
                {
                    Button button = new Button();
                    button.Name = "button" + x + y;
                    button.Text = "";
                    button.Location = new System.Drawing.Point(20 + 45 * (x - 1), 20 + 45 * (y - 1));
                    button.Size = new System.Drawing.Size(45, 45);
                    button.UseVisualStyleBackColor = true;
                    button.Click += button_Click;
                    button.Visible = true;
                    //button.Enabled = false;
                    gameButtons.Add(button);
                    groupBox1.Controls.Add(button);
                    allPlays.Add(new Play());
                }
            }           
                     
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GameGui_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int i = gameButtons.IndexOf(button);
            if (!turn)
            {
                allPlays[i].text = "X";
                button.Text = "X";
            }else
            {
                allPlays[i].text = "O";
                button.Text = "O";
            }
            foreach(Button b in gameButtons)
            {
                b.Enabled = false;
            }
            turn = !turn;
            if (server)
            {
                s.sendData(allPlays);
            }else
            {
                c.sendData(allPlays);
            }
            
            hasWon();
        }

        public void hasWon()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => hasWon()));
            }
            else
            {
                int c = count + 1;
                listBox1.Items.Add($"Turns: {c}");
                for (int i = 0; i < 3; i++)
                {
                    if (allPlays[i].text == allPlays[i + 3].text && allPlays[i + 3].text == allPlays[i + 6].text && allPlays[i].text != "")
                    {
                        winner = true;
                    }
                }

                for (int i = 0; i < 9; i += 3)
                {
                    if (allPlays[i].text == allPlays[i + 1].text && allPlays[i + 1].text == allPlays[i + 2].text && allPlays[i].text != "")
                    {
                        winner = true;
                    }
                }
                if (allPlays[0].text == allPlays[4].text && allPlays[4].text == allPlays[8].text && allPlays[0].text != "")
                {
                    winner = true;
                }
                if (allPlays[2].text == allPlays[4].text && allPlays[4].text == allPlays[6].text && allPlays[2].text != "")
                {
                    winner = true;
                }



                if (winner)
                {
                    if (turn)
                    {
                        listBox1.Items.Add("Justin wint!");
                        Console.WriteLine("Justin wint!");
                    }
                    else
                    {
                        listBox1.Items.Add("Jairo wint!");
                        Console.WriteLine("Jairo wint!");
                    }
                    gameOver();
                }

                count = 0;
                foreach (Play p in allPlays)
                {
                    if (p.text != "")
                    {
                        gameButtons[allPlays.IndexOf(p)].Enabled = false;
                        count++;
                    }
                }
                if (count == 9 && !winner)
                {
                    gameOver();
                    listBox1.Items.Add("Gelijkspel!");
                    Console.WriteLine("Gelijkspel!");
                }
            }
        }

        public void gameOver()
        {
            groupBox1.Enabled = false;
            gameFinished = true;
            buttonRM.Visible = true;
            buttonRM.Enabled = true;
        }

        public void buttonRM_Click(object sender, EventArgs e)
        {
            resetGame();
            buttonRM.Visible = false;
            buttonRM.Enabled = false;
        }

        public void resetGame()
        {
            groupBox1.Enabled = true;
            count = 0;
            winner = false;
            gameFinished = false;
            turn = false;
            foreach(Button b in gameButtons)
            {
                b.Enabled = true;
                b.Text = "";
            }
            foreach(Play p in allPlays)
            {
                p.text = "";
            }
        }

        public void checkList(List<Play> turns)
        {
            turn = !turn;
            if (turns != null){
                allPlays = turns;
            }
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => checkList(turns)));
            }
            else
            {
                foreach (Play p in allPlays)
                {
                    gameButtons[allPlays.IndexOf(p)].Text = p.text;
                    if(p.text == "")
                    {
                        gameButtons[allPlays.IndexOf(p)].Enabled = true;
                    }
                    
                }             
            }

        }
            
        

    }


}


