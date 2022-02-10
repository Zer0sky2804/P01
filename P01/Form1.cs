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
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button) (ctrl as Button).Text = pismena[i].ToString();
                i++;
            }
        }
        int counter = 0;
        private void encode_Click(object sender, EventArgs e)
        {
            counter++;
            string chain = textBox1.Text;
            string newchain = "";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                char value = chain[i];
                if (value != ' ' && value != ',' && value != '.' && value != '!' && value != '?')
                {
                    int ascii;
                    if (value >= 'X') ascii = (int)value - 26 + 3;
                    else ascii = (int)value + 3;
                    newchain += (char)ascii;
                }
                else newchain += value; 
            }
            textBox1.Text = newchain;
        }

        private void decode_Click(object sender, EventArgs e)
        {
            string chain = textBox1.Text;
            string newchain = "";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                char value = chain[i];
                if (value != ' ' && value != ',' && value != '.' && value != '!' && value != '?' && counter > 0)
                {
                    int ascii;
                    if (value <= 'C') ascii = (int)value + 26 - (counter * 3) + (((counter * 3) / 26) * 26);
                    else
                    {
                        ascii = (int)value - counter * 3 + (((counter * 3) / 26) * 26);
                    }
                    newchain += (char)ascii;
                }
                else newchain += value;
            }
            textBox1.Text = newchain;
            counter = 0;
        }
    }
}
