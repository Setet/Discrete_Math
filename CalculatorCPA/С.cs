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
    public partial class С : Form
    {
        public С()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = 0, k = 0, step1 = 1, step2 = 1, step3 = 1, Answer = 0;
            FormTest main = this.Owner as FormTest;
            try
            {
                n += Convert.ToInt64(textBox2.Text);
                k += Convert.ToInt64(textBox1.Text);
            }
            catch (Exception)
            {
                richTextBox1.Text = "404ERROR";
            }
            if (n < k)
            {
                richTextBox1.Text = "Неправильное заполнение полей!!!";
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    step1 = step1 * i;
                }
                for (int i = 1; i <= k; i++)
                {
                    step2 = step2 * i;
                }
                for (int i = 1; i <= n-k; i++)
                {
                    step3 = step3 * i;
                }
                Answer = step1 / (step3 * step2);
                richTextBox1.Text = "";
                richTextBox1.Text += Convert.ToString(Answer);
            }
            main.labelNumber.Text +=this.richTextBox1.Text;
            this.Close();
        }
    }
}
