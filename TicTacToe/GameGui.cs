using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class GameGui : Form
    {
        public Boolean turn = false;
        public int count = 0;


        public GameGui()
        {
            InitializeComponent();
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
            
           // listBox1.Items.Add("you: " + textBox1.Text);
           // textBox1.Text = "";
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!turn)
            {
                button.Text = "X";
            }else
            {
                button.Text = "O";
            }
            button.Enabled = false;
            turn = !turn;
            winner();
        }

        public void winner()
        {
            Boolean winner = false;
            if(button11.Text == button21.Text && button21.Text == button31.Text && !button11.Enabled)
            {   
                winner = true;
            }
            else if(button12.Text == button22.Text && button22.Text == button32.Text && !button12.Enabled)
            {
                winner = true;
            }
            else if (button13.Text == button23.Text && button23.Text == button33.Text && !button13.Enabled)
            {
                winner = true;
            }
            else if (button11.Text == button12.Text && button12.Text == button13.Text && !button11.Enabled)
            {
                winner = true;
            }
            else if (button21.Text == button22.Text && button22.Text == button23.Text && !button21.Enabled)
            {
                winner = true;
            }
            else if (button31.Text == button32.Text && button32.Text == button33.Text && !button31.Enabled)
            {
                winner = true;
            }
            else if (button13.Text == button22.Text && button22.Text == button31.Text && !button13.Enabled)
            {
                winner = true;
            }
            else if (button11.Text == button22.Text && button22.Text == button33.Text && !button11.Enabled)
            {
                winner = true;
            }

            if (count == 8 && !winner)
            {
                groupBox1.Enabled = false;
                listBox1.Items.Add("Gelijkspel!");
                Console.WriteLine("Gelijkspel!");
            }


            if (winner)
            {
                if (turn)
                {
                    listBox1.Items.Add("Justin wint!");
                    Console.WriteLine("Justin wint!");
                }else
                {
                    listBox1.Items.Add("Jairo wint!");
                    Console.WriteLine("Jairo wint!");
                }
                groupBox1.Enabled = false;
            }
            count++;
        }
    }
}
