using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Lines[0]);
            int y = Convert.ToInt32(textBox1.Lines[1]);
            int u = x;
            int w = y;
            int r;
            while (w > 0)
            {
                r = u % w;
                u = w;
                w = r;
            }
            int nsn = x * y / u;
            MessageBox.Show(String.Format("NSD ({0}, {1}) = {2}\nNSN ({3}, {4}) = {5}", x, y, u, x, y, nsn));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            double ap = 0;
            int p = 0;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox)
                {
                    int a = rnd.Next(5, 21);
                    (ctrl as TextBox).Text = a.ToString();
                    if (a % 7 == 0)
                    {
                        ap += a;
                        p++;
                    }
                }
                else
                
                    if (ctrl is RadioButton)
                    {          
                    (ctrl as RadioButton).Enabled= !(ctrl as RadioButton).Enabled;
                    }   
              else
                        if (ctrl is Button)
                        {

                        } 
            }
            if (p != 0)
            {
                ap = ap / p;
                label1.Text = "Aritmeticky prumer je " + ap;
            }
            else
            {
                label1.Text = "Aritmeticky prumer neexistuje.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
