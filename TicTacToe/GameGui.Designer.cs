namespace TicTacToe
{
    partial class GameGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button31 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button31);
            this.groupBox1.Controls.Add(this.button21);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button32);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button33);
            this.groupBox1.Controls.Add(this.button23);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Location = new System.Drawing.Point(39, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(113, 121);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(40, 40);
            this.button31.TabIndex = 31;
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(67, 121);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(40, 40);
            this.button21.TabIndex = 12;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(21, 121);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(40, 40);
            this.button11.TabIndex = 11;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(113, 76);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(40, 40);
            this.button32.TabIndex = 32;
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(67, 75);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(40, 40);
            this.button22.TabIndex = 22;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(21, 75);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(40, 40);
            this.button12.TabIndex = 12;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(113, 30);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(40, 40);
            this.button33.TabIndex = 33;
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(67, 29);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(40, 40);
            this.button23.TabIndex = 23;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(21, 29);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 40);
            this.button13.TabIndex = 13;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(217, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ChatBox";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GameGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 279);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GameGui";
            this.Text = "GameGui";
            this.Load += new System.EventHandler(this.GameGui_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button13;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}