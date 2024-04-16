namespace tu_dien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 481);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.z5149859075225_c87813ffd46e655f77bf2992a5d245b5;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(176, 8);
            button1.Name = "button1";
            button1.Size = new Size(70, 470);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(17, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 472);
            comboBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(261, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(726, 482);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources._342531347_2683924171773586_2134212401784834719_n;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(641, 79);
            button3.Name = "button3";
            button3.Size = new Size(82, 400);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.cosmic_horror_encounter_by_futurerender_dg25l28_fullview;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(641, 8);
            button2.Name = "button2";
            button2.Size = new Size(82, 65);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 79);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(632, 400);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 8);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(632, 65);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 497);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}
