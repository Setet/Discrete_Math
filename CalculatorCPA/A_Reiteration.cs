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
    public partial class A_Reiteration : Form
    {
        public A_Reiteration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = 0, k = 0, Answer = 0;
            FormTest main = this.Owner as FormTest;
            try
            {
                n += Convert.ToInt64(textBox2.Text);
                k += Convert.ToInt64(textBox1.Text);
            }
            catch (Exception)
            {
            }
            if (n > k)
            {
                MessageBox.Show("Неправильное заполнение полей!!!");
            }
            else
            {
                Answer = Math.Pow(n, k);
            }
            textBox1.Text = Convert.ToString(Answer);
            main.labelNumber.Text += this.textBox1.Text;
            this.Close();
        }
    }
}
