using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pismena = "QERTYUIOPASDFGHJKLZXCVBNM.,?! ";
            int i = 0;
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button) (ctrl as Button).Text = pismena[i].ToString();
                i++;
            }
        }

        private void encode_Click(object sender, EventArgs e)
        {
            foreach (char value in textBox1.Text)
            {
                if (value != ' ' && value != ',' || value == '.' || value == '!' || value == '?')
                {

                }
                else
                {
                    int ascii = Convert.ToInt32(value);
                    ascii += 3;
                    char znak = Convert.ToChar(ascii);
                }
            }
        }
    }
}
