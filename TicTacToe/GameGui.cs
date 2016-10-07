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
        public GameGui()
        {
            InitializeComponent();
            
        }

        

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = "x";
            button11.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = "x";
            button13.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Text = "x";
            button21.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Text = "x";
            button31.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = "x";
            button12.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Text = "x";
            button22.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Text = "x";
            button32.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Text = "x";
            button23.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Text = "x";
            button33.Enabled = false;
        }

        private void GameGui_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("you: " + textBox1.Text);
            textBox1.Text = "";
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
