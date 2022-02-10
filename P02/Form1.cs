using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char i = (sender as Button).Text[0];
            int cislo = int.Parse((i).ToString());
            string[] morseovka = { "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." };
            textBox1.Text += morseovka[cislo]+" ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cisla = "0987654321";
            int i = 0;
            foreach(Control ctrl in Controls)
            {
                if(ctrl is Button)
                {
                    (ctrl as Button).Text = cisla[i].ToString();
                    i++;
                }
            }
        }
    }
}
