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
    public partial class P_Reiteration : Form
    {
        public P_Reiteration()
        {
            InitializeComponent();
        }
        List<string> items = new List<string>();
        public int n = 0;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            items.Add(TextBox.Text);
            n++;

            RichTextBox.Text = "";
            RichTextBox.Text += "В дек добавили "+n+"-ый"+" элемент.";
            TextBox.Text = "";
        }

        private void buttonCout_Click(object sender, EventArgs e)
        {
            RichTextBox.Text = "";
            RichTextBox.Text += "n-ы:\n";
            foreach (string Item in items)
            {
                RichTextBox.Text += Item;
                RichTextBox.Text += " ";
            }
        }

        private void buttonToWriten_Click(object sender, EventArgs e)
        {
            FormTest main = this.Owner as FormTest;
            int step1 = 0, step2 = 1;
            long Answer = 0, numerator = 1, Denominator = 1;
            foreach (string Item in items)
            {
                step1+=Convert.ToInt32(Item);
            }
            for (int i = 1; i <= step1; i++)
            {
                numerator = numerator * i;
            }
            foreach (string Item in items)
            {
                step2 = Convert.ToInt32(Item);
                for (int i = 1; i <= step2; i++)
                {
                    Denominator = Denominator * i;
                }
            }
            Answer = numerator / Denominator;
            RichTextBox.Text = Convert.ToString(Answer);
            main.labelNumber.Text += this.RichTextBox.Text;
            this.Close();
        }
    }
}
