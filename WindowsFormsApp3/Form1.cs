using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your Username and pass : {userNameTxt} - {passTxtBox}");
        }

        private void openPicBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.openPicBox.Image = Properties.Resources.eye_159604;
            this.passTxtBox.PasswordChar = '\0';
        }

        private void openPicBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.openPicBox.Image = Properties.Resources.hidden_2355322;
            this.passTxtBox.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("Comic Sans MS", 14, FontStyle.Bold);
            richTextBox1.Copy();
            richTextBox1.SelectionColor = System.Drawing.Color.Blue;
        }

        private void passBtr_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void redoBtr_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void visBtr_CheckedChanged(object sender, EventArgs e)
        {
            if (visBtr.Checked)
            {
                visBtr.Text = visBtr.Text + " select";
            }
            else
            {
                visBtr.Text = "visa";
            }
        }

        private void masterBtr_CheckedChanged(object sender, EventArgs e)
        {
            if (masterBtr.Checked)
            {
                masterBtr.Text = masterBtr.Text + " select";
            }
            else
            {
                masterBtr.Text = "master";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if(item is Button bt)
                {
                    bt.ForeColor = Color.Red;
                }
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker2.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked)
            {
                checkBox3.Text = "Hide";
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
                checkBox3.Text = "Show";
            }
        }
    }
}
