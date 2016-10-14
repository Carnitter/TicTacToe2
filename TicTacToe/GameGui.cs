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
            createGame();

            
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
                    button.Location = new System.Drawing.Point(20 + 45 * (x-1), 20 + 45 * (y-1));
                    button.Size = new System.Drawing.Size(45, 45);
                    button.UseVisualStyleBackColor = true;
                    button.Click += Button_Click; ;
                    button.Visible = true;
                    groupBox1.Controls.Add(button);

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

        private void button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hallo");
          
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // listBox1.Items.Add("you: " + textBox1.Text);
            // textBox1.Text = "";
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            
        }

    }
}
