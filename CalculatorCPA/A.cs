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
    public partial class A : Form
    {
        public A()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTest main = this.Owner as FormTest;
            double n = 0, k = 0, step1 = 1, step2 = 1, step3 = 1, step4 = 1, A = 0;
            try
            {
                n += Convert.ToInt64(textBox2.Text);
                k += Convert.ToInt64(textBox1.Text);
            }
            catch (Exception)
            {
            }
            if (n < k)
            {
                MessageBox.Show("Неправильное заполнение полей!!!");
            }
            else
            {
                step3 = n - k;
                for (int i = 1; i <= n; i++)
                {
                    step1 = step1 * i;
                }
                for (int i = 1; i <= k; i++)
                {
                    step2 = step2 * i;
                }
                for (int i = 1; i <= step3; i++)
                {
                    step4 = step4 * i;
                }
                A = step1 / (step4);
                textBox1.Text = Convert.ToString(A);
            }
            main.labelNumber.Text += this.textBox1.Text;
            this.Close();
        }
    }
}
