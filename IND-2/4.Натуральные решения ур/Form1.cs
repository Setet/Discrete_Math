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

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string writePath = @"Answer.txt";//путь записи в файл

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
            Prekol(sw);//осн функция
            sw.Close();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            RichTextBox.Text = elapsedTime;//вывод времени
        }

        void Prekol(StreamWriter sw)
        {
            int Answer = 0;//кол-во решений
            int UpperLimit = 70;//верхний лими
            int[] Razm = new int[8];//генерим массив

            for (Razm[0] = 0; Razm[0] <= 8; Razm[0]++)
            {
                for (Razm[1] = 9; Razm[1] <= UpperLimit; Razm[1]++)
                {
                    for (Razm[2] = 0; Razm[2] <= 7; Razm[2]++)
                    {
                        for (Razm[3] = 10; Razm[3] <= UpperLimit; Razm[3]++)
                        {
                            for (Razm[4] = 0; Razm[4] <= 6; Razm[4]++)
                            {
                                for (Razm[5] = 11; Razm[5] <= UpperLimit; Razm[5]++)
                                {
                                    for (Razm[6] = 0; Razm[6] <= 5; Razm[6]++)
                                    {
                                        for (Razm[7] = 12; Razm[7] <= UpperLimit; Razm[7]++)
                                        {
                                            if (Razm[0] + Razm[1] + Razm[2] + Razm[3] + Razm[4] + Razm[5] + Razm[6] + Razm[7] == 100)//если сумма всех элементтов массива равно 100
                                            {
                                                Answer++;//+1 найденное решение
                                                for (int i = 0; i < 7; i++)
                                                {
                                                    sw.Write(Razm[i]);//записываем посимвольно элементы массива
                                                    if (i <= 6)
                                                    {
                                                        sw.Write("+");//ставим между ними +
                                                    }
                                                }
                                                sw.Write(" = 100" + "\n");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Journal.Text = "Кол-во решений = " + Answer + "\n";
        }
    }
}
