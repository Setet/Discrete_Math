using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class P : Form
    {
        public P()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTest main = this.Owner as FormTest;
            double n = 0, P = 1;
            try
            {
                n += Convert.ToInt64(textBox1.Text);
            }
            catch (Exception)
            {
            }
            for (int i = 1; i <= n; i++)
            {
                P = P * i;
            }
            textBox1.Text = Convert.ToString(P);
            main.labelNumber.Text += this.textBox1.Text;
            this.Close();
        }
    }
}
