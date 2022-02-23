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
    }
}
