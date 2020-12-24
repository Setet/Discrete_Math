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
        public int n = 0;
        string writePath = @"C:\Проги\ln1.txt";

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            int n = (TextBox2.Text != "") ? Convert.ToInt32(TextBox2.Text) : 0; // Условный оператор, если текстбокс не пуст, то n = текстбокс, иначе n = 0
            int m = (TextBox1.Text != "") ? Convert.ToInt32(TextBox1.Text) : 0; // Условный оператор, если текстбокс не пуст, то к = текстбокс, иначе к = 0
            int[] a = new int[n];

            char[] A = new char[n];
            RichTextBox1.Text = "";
            RichTextBox1.Text += "{";
            for (int i = 0; i < n; i++)
            {
                A[i] = (char)((char)97 + i);//Хочу, чтобы были буквы(номер кол-ва букв соответсвует  самим буквам).Например при 3,алфавит будет a,b,c
                RichTextBox1.Text += A[i];
                if (i < (n - 1))
                {
                    RichTextBox1.Text += ",";
                }
            }
            RichTextBox1.Text += "}";

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            Print(a, A, n, sw, m);
            sw.Close();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            RichTextBox.Text = elapsedTime;
        }

        void swap(int[] a, int i, int j)
        {
            int s = a[i];
            a[i] = a[j];
            a[j] = s;
        }

        void Print(int[] a,char[]A,int n, StreamWriter sw, int m)
        {
            int q = 1;
            for (int i = 0; i < n; i++)
            {
                a[i] = i;
            }
            while (NextSet(a, n, m))
            {
                sw.Write(q + ":");
                for (int i = 0; i < m; i++)
                {
                    sw.Write(A[a[i]]);
                }
                sw.Write("\n");
                q++;
            }

        }//запись в файл ответа

        bool NextSet(int[] a, int n,int m)
        {
            int j;
            do  // повторяем пока не будет найдено следующее размещение
            {
                j = n - 2;
                while (j != -1 && a[j] >= a[j + 1]) j--;
                if (j == -1)
                    return false; // больше размещений нет
                int k = n - 1;
                while (a[j] >= a[k]) k--;
                swap(a, j, k);
                int l = j + 1, r = n - 1; // сортируем оставшуюся часть последовательности
                while (l < r)
                    swap(a, l++, r--);
            }
            while (j > m - 1);
            return true;
        }
    }
}
