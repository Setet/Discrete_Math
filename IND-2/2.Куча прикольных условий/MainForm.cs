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

namespace Number2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public int q = 0;
        const int pi = 10;//кол-во элем алфавита
        string writePath = @"Answer.txt";//Адрес куда записывать результат
        string[] A = new string[pi] { "a", "b", "c", "d", "e", "f", "g", "h", "j","k" };//нач алфавит

        private void button1_Click(object sender, EventArgs e)
        {
            int n = (TextBox1.Text != "") ? Convert.ToInt32(TextBox1.Text) : 0; // длина слова
            int k = (TextBox2.Text != "") ? Convert.ToInt32(TextBox2.Text) : 0; // A повторяется менее k раз,B C ровно k раз
            int m = (TextBox3.Text != "") ? Convert.ToInt32(TextBox3.Text) : 0; // D повторяется более m раз

            int[] Razm = new int[n];//массив слов
            if (n>0)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
                RichTextBox.Text = "";
                recfan2(Razm, A, pi, n, k, m, sw);//основная функция
                sw.Close();

                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                RichTextBox.Text += "Кол-во слов = " + Convert.ToString(q)+"\n";
                RichTextBox.Text += elapsedTime;
            }
            else
            {
                MessageBox.Show("Непрвильный ввод n!!!");
            }
        }

        void recfan2(int[] Razm, string[] A, int pi, int n, int k, int m, StreamWriter sw)
        {
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0, j = 0, K = 0;//переменные кол-ва соответвующих символов в слове
            char ca = 'a', cb = 'b', cc = 'c', cd = 'd', ce = 'e', cf = 'f', cg = 'g', ch = 'h', cj = 'j', ck = 'k';//переменые с символами

            string net = "";//строка как слово

            for (int i = 0; i < n; i++)
            {
                Razm[i] = 0;
            }

            while (nextCombObject(Razm, n, pi))
            {
                foreach (int item in Razm)
                {
                    net += A[item];//заполняем строку словом
                }

                for (int i = 0; i < net.Length; i++)//цикл проверки кол-ва разных символов
                {
                    if (ca == net[i])
                    {
                        a++;
                    }
                    if (cb == net[i])
                    {
                        b++;
                    }
                    if (cc == net[i])
                    {
                        c++;
                    }
                    if (cd == net[i])
                    {
                        d++;
                    }
                    if (ce == net[i])
                    {
                        e++;
                    }
                    if (cf == net[i])
                    {
                        f++;
                    }
                    if (cg == net[i])
                    {
                        g++;
                    }
                    if (ch == net[i])
                    {
                        h++;
                    }
                    if (cj == net[i])
                    {
                        j++;
                    }
                    if (ck == net[i])
                    {
                        K++;
                    }
                }

                BruteForce(k, m,n, a, b, c, d, e, f, g, h, j, K, Razm, A, sw);

                //10 строк ниже-обнуление кол-ва значений слов
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                e = 0;
                f = 0;
                g = 0;
                h = 0;
                j = 0;
                K = 0;
                net = "";//очистка строки
            }
            sw.Write("Кол-во слов = " + q);
        }

        bool nextCombObject(int[] Razm, int n, int pi)
        {
            int j = n - 1;
            while (j >= 0 && Razm[j] == pi - 1) j--;
            if (j == -1) return false;
            Razm[j]++;
            for (int i = j + 1; i < n; i++)
                Razm[i] = 0;
            return true;
        }

        void WriteToFile(int[] Razm, string[] A, StreamWriter sw)
        {
            sw.Write(q + " : ");
            foreach (int item in Razm)
            {
                sw.Write(A[item]);
            }
            sw.Write("\n");
        }

        void BruteForce(int k, int m,int n, int a, int b, int c, int d, int e, int f, int g, int h, int j, int K, int[] Razm, string[] A, StreamWriter sw)
        {
            if (a < k)//гора всяких услой подходящего слова
            {
                if (b == k)
                {
                    if (c == k)
                    {
                        if (d > m)
                        {
                            if (d == (n - a - b - c))
                            {
                                q++;
                                WriteToFile(Razm, A, sw);
                            }
                            else
                            {
                                if (e == 1)
                                {
                                    if (f == 1)
                                    {
                                        if (g == 1)
                                        {
                                            if (h == 1)
                                            {
                                                if (j == 1)
                                                {
                                                    if (K == 1)
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                    else
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                }
                                                else
                                                {
                                                    if (K == 1)
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                    else
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (j == 1)
                                                {
                                                    if (K == 1)
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                    else
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                }
                                                else
                                                {
                                                    q++;
                                                    WriteToFile(Razm, A, sw);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (h == 1)
                                            {
                                                if (j == 1)
                                                {
                                                    if (K == 1)
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                    else
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                }
                                                else
                                                {
                                                    q++;
                                                    WriteToFile(Razm, A, sw);
                                                }
                                            }
                                            else
                                            {
                                                q++;
                                                WriteToFile(Razm, A, sw);
                                            }
                                        }
                                    }
                                    else
                                    {

                                        if (g == 1)
                                        {
                                            if (h == 1)
                                            {
                                                if (j == 1)
                                                {
                                                    if (K == 1)
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                    else
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                }
                                                else
                                                {
                                                    q++;
                                                    WriteToFile(Razm, A, sw);
                                                }
                                            }
                                            else
                                            {
                                                q++;
                                                WriteToFile(Razm, A, sw);
                                            }
                                        }
                                        else
                                        {
                                            q++;
                                            WriteToFile(Razm, A, sw);
                                        }
                                    }
                                }
                                else
                                {
                                    if (f == 1)
                                    {
                                        if (g == 1)
                                        {
                                            if (h == 1)
                                            {
                                                if (j == 1)
                                                {
                                                    if (K == 1)
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                    else
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                }
                                                else
                                                {
                                                    q++;
                                                    WriteToFile(Razm, A, sw);
                                                }
                                            }
                                            else
                                            {
                                                q++;
                                                WriteToFile(Razm, A, sw);
                                            }
                                        }
                                        else
                                        {
                                            q++;
                                            WriteToFile(Razm, A, sw);
                                        }
                                    }
                                    else
                                    {
                                        if (g == 1)
                                        {
                                            if (h == 1)
                                            {
                                                if (j == 1)
                                                {
                                                    if (K == 1)
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                    else
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                }
                                                else
                                                {
                                                    q++;
                                                    WriteToFile(Razm, A, sw);
                                                }
                                            }
                                            else
                                            {
                                                q++;
                                                WriteToFile(Razm, A, sw);
                                            }
                                        }
                                        else
                                        {
                                            if (h == 1)
                                            {
                                                if (j == 1)
                                                {
                                                    if (K == 1)
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                    else
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                }
                                                else
                                                {
                                                    q++;
                                                    WriteToFile(Razm, A, sw);
                                                }
                                            }
                                            else
                                            {
                                                if (j == 1)
                                                {
                                                    if (K == 1)
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                    else
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                }
                                                else
                                                {
                                                    if (K == 1)
                                                    {
                                                        q++;
                                                        WriteToFile(Razm, A, sw);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

            }
        }
    }
}