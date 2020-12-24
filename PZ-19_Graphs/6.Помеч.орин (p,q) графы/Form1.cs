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

namespace PZ19_3
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

        static void swap(int[] raz, int i, int j)
        {
            int bufer = raz[i];
            raz[i] = raz[j];
            raz[j] = bufer;
        }

        void Main(StreamWriter sw)
        {
            int k = 2;//2 потому что,ребро может быть только между 2 вершинами

            int p = (TextBox1.Text != "") ? Convert.ToInt32(TextBox1.Text) : 0; //кол-во вершин
            int q = (TextBox2.Text != "") ? Convert.ToInt32(TextBox2.Text) : 0; //кол-во рёбер

            int[] raz = new int[p + 1];

            for (int i = 0; i < p; i++)
            {
                raz[i] = i;
            }

            int m = 0;//счетчик ребер

            Edge[] edge = new Edge[500];//Массив ребер

            edge[m].first = raz[0];
            edge[m].second = raz[1];
            m++;

            //Построения всех возможных ребер в заданном графе
            while (NextCombobjraz(raz, p, k))
            {
                edge[m].first = raz[0];
                edge[m].second = raz[1];
                m++;
            }

            RichTextBox1.Text += "Максимальное кол-во дуг = " + m + "\n";

            if (q < m)
            {
                RichTextBox1.Text += "Сочитания из ребер" + "\n";

                int graph = 0;//Счетчик числа p,q графов

                int[,] Matrix = new int[p, p];//двумерный массив как матрица смежности
                Reset(ref Matrix, p, p);//обнуление массива

                int[] socq = new int[q];//по сути сочетание(из m по q)

                for (int i = 0; i < q; i++)
                {
                    socq[i] = i;
                    RichTextBox1.Text += socq[i] + " ";
                    //Заполняем таблицу смежности
                    Matrix[edge[socq[i]].first, edge[socq[i]].second] = 1;
                }
                RichTextBox1.Text += "\n";

                PrintArray(Matrix, p, p, sw);
                graph++;
                Reset(ref Matrix, p, p);

                if (p == m)//если кол-во вершин совпадает с кол-вом рёбер
                {
                    RichTextBox1.Text += "1 граф";//то сущ только 1 граф
                }
                else
                {
                    //Строим сочитания из ребер
                    while (NextCombobjsoc(socq, m, q))
                    {
                        for (int i = 0; i < q; i++)
                        {
                            RichTextBox1.Text += socq[i] + " ";
                            //Заполняем таблицу смежности
                            Matrix[edge[socq[i]].first, edge[socq[i]].second] = 1;

                        }
                        RichTextBox1.Text += "\n";

                        PrintArray(Matrix, p, p, sw); //выводим в файл
                        graph++;//+1 граф в копилку графов
                        Reset(ref Matrix, p, p); //обнуляем
                    }
                }
                sw.Write("Кол-во ор.графов = " + graph);//вывод кол-ва графов
                RichTextBox1.Text += "Кол-во ор.графов = " + graph;
            }
            else
            {
                MessageBox.Show("Число заданных ребер больше максимального кол-во рёбер графа в принципе!!!");
            }
        }

        static bool NextCombobjsoc(int[] soc, int n, int k)
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

        static bool NextCombobjraz(int[] raz, int n, int k)
        {
            int j;
            do
            {
                j = n - 1;
                while (j != -1 && raz[j] >= raz[j + 1]) j--; //ищем пока следующий элемент будет больше предыдущего

                if (j == -1)
                    return false; //  размещений нет
                int l = n - 1;


                while (raz[j] >= raz[l]) l--; //ищем элемент больше j
                swap(raz, j, l);

                int q = j + 1, p = n - 1; // сортируем за j
                while (q < p) swap(raz, q++, p--);

            } while (j > k - 1); // повторяем пока не будет найдено следующее размещение

            return true;
        }

        static public void Reset(ref int[,] arr, int n, int m) //Обнуление массива
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = 0;
                }
            }
        }

        static public void PrintArray(int[,] arr, int n, int m, StreamWriter sw)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sw.Write(arr[i, j] + " ");
                }
                sw.WriteLine();
            }
            sw.WriteLine(" ");
        }
    }
}
