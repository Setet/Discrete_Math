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

namespace PZ19_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string writePath = @"Answer.txt";//место записи в файл

        struct Edge
        {
            public int first;
            public int second;
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            RichTextBox1.Text = "";
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            Main(sw);//осн.функция
            sw.Close();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            RichTextBox2.Text = elapsedTime;//запись времени работы программы
        }

        void Main(StreamWriter sw)
        {
            int k = 2;//2 потому что,ребро может быть только между 2 вершинами

            int p = (TextBox1.Text != "") ? Convert.ToInt32(TextBox1.Text) : 0; //кол-во вершин

            int[] soc = new int[k];//массив вершин(по факту сочетания)

            for (int i = 0; i < k; i++)
            {
                soc[i] = i;
            }

            int m = 0;//счетчик ребер

            Edge[] edge = new Edge[500];//Массив ребер

            edge[m].first = soc[0];
            edge[m].second = soc[1];
            m++;

            if (p > k)
            {
                //Построения всех возможных ребер в заданном графе
                while (NextCombobj(soc, p, k))
                {
                    edge[m].first = soc[0];
                    edge[m].second = soc[1];
                    m++;
                }
            }
            else
            {
                MessageBox.Show("Условие не выполняется!!!");
            }

            RichTextBox1.Text += "Максимальное кол-во рёбер = " + m + "\n";


            RichTextBox1.Text += "Сочитания из ребер" + "\n";

            int graph = 0;//Счетчик числа p,q графов

            int[,] Matrix = new int[p, p];//двумерный массив как матрица смежности

            for (int g = 0; g <= m; g++)
            {
                Reset(ref Matrix, p, p);//обнуление массива
                int[] socq = new int[g];//по сути сочетание(из m по q)

                for (int i = 0; i < g; i++)
                {
                    socq[i] = i;
                    RichTextBox1.Text += socq[i] + " ";
                    //Заполняем таблицу смежности
                    Matrix[edge[socq[i]].first, edge[socq[i]].second] = 1;
                    Matrix[edge[socq[i]].second, edge[socq[i]].first] = 1;
                }

                RichTextBox1.Text += "\n";

                PrintArray(Matrix, p, p, sw);
                graph++;//+1 граф в копилку графов
                Reset(ref Matrix, p, p);

                if (p == m)//если кол-во вершин совпадает с кол-вом рёбер
                {
                    RichTextBox1.Text += "1 граф";//то сущ только 1 граф
                }
                else
                {
                    //Строим сочитания из ребер
                    while (NextCombobj(socq, m, g))
                    {
                        for (int i = 0; i < g; i++)
                        {
                            RichTextBox1.Text += socq[i] + " ";
                            //Заполняем таблицу смежности
                            Matrix[edge[socq[i]].first, edge[socq[i]].second] = 1;
                            Matrix[edge[socq[i]].second, edge[socq[i]].first] = 1;

                        }
                        RichTextBox1.Text += "\n";

                        PrintArray(Matrix, p, p, sw); //выводим в файл
                        graph++;//+1 граф в копилку графов
                        Reset(ref Matrix, p, p); //обнуляем
                    }
                }
            }
            sw.Write("Кол-во графов = " + graph);//вывод кол-ва графов
            RichTextBox1.Text += "Кол-во графов = " + graph;
        }


        bool NextCombobj(int[] soc, int n, int k)
        {
            for (int i = k - 1; i >= 0; --i)//начинаем идти с конца в начало
            {
                if (soc[i] < n - k + i)
                {
                    soc[i]++;//берем следующий элемент
                    for (int j = i + 1; j < k; j++)//следующий элемент меняем на предыдущий + 1
                    {
                        soc[j] = soc[j - 1] + 1;
                    }
                    return true;
                }
            }
            return false;
        }

        void Reset(ref int[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = 0;
                }
            }
        }//обнуление массива

        void PrintArray(int[,] arr, int n, int m, StreamWriter sw)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sw.Write(arr[i, j] + " ");
                }
                sw.Write("\n");
            }
            sw.WriteLine(" ");
        }//запись матрицы смежности в файл

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            RichTextBox1.SelectionStart = RichTextBox1.Text.Length;
            RichTextBox1.ScrollToCaret();
        }
    }
}
