using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics; // для таймера
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> items = new List<string>();
        public int n = 0;
        string writePath = @"Out.txt";//Адрес куда записывать результат

        private void button1_Click(object sender, EventArgs e)
        {
            int q = 0;
            int k = (TextBoxK.Text != "") ? Convert.ToInt32(TextBoxK.Text) : 0; // Условный оператор, если текстбокс не пуст, то к = текстбокс, иначе к = 0

            int[] Razm = new int[k];
            RichTextBox1.Text += "";
            RichTextBox1.Text += "{";
            foreach (string Item in items)
            {
                RichTextBox1.Text += Item;
                RichTextBox.Text += Item;
                q++;
                if (q < (n))
                {
                    RichTextBox1.Text += ",";
                }
            }
            RichTextBox1.Text += "}";

            if (n >= k)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
                sw.Write(RichTextBox.Text + "\n");
                RichTextBox.Text = "";
                recfan2(Razm, n, k, sw);
                sw.Close();

                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                RichTextBox.Text = elapsedTime;
            }
            else RichTextBox.Text = "Ошибка";
        }


        void recfan2(int[] Razm, int n, int k, StreamWriter sw)
        {
            for (int i = 0; i < k; i++)
            {
                Razm[i] = 0;
                sw.Write(items[0]);//Вывод первого элемента
            }
            sw.Write("\n");

            while (CombObject(Razm, k, n))//Пока есть сочетания, пишем их
            {
                foreach (int item in Razm)
                {
                    sw.Write(items[item]);
                }
                sw.Write("\n");
            }
        }

        bool CombObject(int[] Razm, int k, int n)
        {
            int j = k - 1;
            while (j >= 0 && Razm[j] == n - 1) j--;
            if (j == -1) return false;
            Razm[j]++;

            for (int i = j + 1; i < k; i++)
                Razm[i] = Razm[j];
            return true;
        }

        private void buttonToWrite_Click(object sender, EventArgs e)
        {
            items.Add(TextBox1.Text);
            n++;
            TextBox1.Text = "";
        }
    }
}
