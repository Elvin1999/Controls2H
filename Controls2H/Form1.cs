using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls2H
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var item in groupBox1.Controls)
            {
                if(item is RadioButton rb)
                {
                    rb.BackColor=Color.LightGoldenrodYellow;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(usernamTxtb.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usernamTxtb.PasswordChar == '*')
            {
                usernamTxtb.PasswordChar = '\0';
            }
            else
            {
                usernamTxtb.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Italic | FontStyle.Bold | FontStyle.Underline);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dateTimePicker1.Value.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            richTextBox1.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.Checked)
            {
                checkBox.BackColor = Color.Green;
            }
            else
            {
                checkBox.BackColor = Color.Gray;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Text = "Master";
                radioButton1.BackColor = Color.SpringGreen;
                radioButton2.BackColor = Color.WhiteSmoke;
                radioButton1.Text = "Visa Selected";
            }
            else
            {
                radioButton1.Text = "Visa";
                radioButton2.BackColor = Color.SpringGreen;
                radioButton1.BackColor = Color.WhiteSmoke;
                radioButton2.Text = "Master Selected";
            }
        }
    }
}
